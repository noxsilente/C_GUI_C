import sqlite3
import pandas as pd
import xml.etree.ElementTree as ET
from pathlib import Path

# =============================
# CONFIGURAZIONE
# =============================
XML_FILE = "rif.xml"
DB_FILE = "rif.db"

# categorie valide (vincolo logico)
VALID_CATEGORIES = {
    "P", "R", "S", "NE",
    "PRS_I", "PRS_M",
    "CRS_I", "CRS_M"
}

# =============================
# APERTURA DB
# =============================
conn = sqlite3.connect(DB_FILE)
cursor = conn.cursor()

# =============================
# CREAZIONE TABELLE
# =============================

cursor.executescript("""
-- Tabella categorie
CREATE TABLE IF NOT EXISTS categories (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    code TEXT NOT NULL UNIQUE,
    description TEXT
);

-- Tabella cartucce
CREATE TABLE IF NOT EXISTS cartridges (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    category_id INTEGER NOT NULL,
    obj TEXT NOT NULL,
    ref TEXT,
    ref2 TEXT,
    sh TEXT,
    FOREIGN KEY (category_id) REFERENCES categories(id)
);

-- =============================
-- INDICI (prestazioni)
-- =============================
CREATE INDEX IF NOT EXISTS idx_cartridges_obj
    ON cartridges(obj);

CREATE INDEX IF NOT EXISTS idx_cartridges_category
    ON cartridges(category_id);

CREATE INDEX IF NOT EXISTS idx_cartridges_cat_obj
    ON cartridges(category_id, obj);
""")

conn.commit()

# =============================
# PARSING XML
# =============================

tree = ET.parse(XML_FILE)
root = tree.getroot()

def get_or_create_category(code: str) -> int:
    """
    Restituisce l'id della categoria.
    Se non esiste la crea.
    """
    cursor.execute(
        "SELECT id FROM categories WHERE code = ?",
        (code,)
    )
    row = cursor.fetchone()
    if row:
        return row[0]

    cursor.execute(
        "INSERT INTO categories (code) VALUES (?)",
        (code,)
    )
    return cursor.lastrowid

# =============================
# INSERIMENTO DATI
# =============================

insert_sql = """
INSERT INTO cartridges
(category_id, obj, ref, ref2, sh)
VALUES (?, ?, ?, ?, ?)
"""

for element in root:
    tag = element.tag.strip()

    # ignora categorie non previste
    if tag not in VALID_CATEGORIES:
        continue

    category_id = get_or_create_category(tag)

    obj  = element.attrib.get("obj")
    ref  = element.attrib.get("ref")
    ref2 = element.attrib.get("ref2")
    sh   = element.attrib.get("sh")

    cursor.execute(
        insert_sql,
        (category_id, obj, ref, ref2, sh)
    )

conn.commit()

# =============================
# CHIUSURA
# =============================
conn.close()

print("✅ Database SQLite creato correttamente:", DB_FILE)

conn = sqlite3.connect("rif.db")

df = pd.read_sql_query('''
SELECT
ca.code AS category,
cr.obj,
cr.ref,
cr.ref2,
cr.sh
FROM cartridges cr
JOIN categories ca ON ca.id = cr.category_id 
ORDER BY category, obj

''', conn
)
print(df)
################################# PER VECCHIO PROGRAMMA
#def insert_cartridge(category_code, obj, ref, ref2, sh):
#    conn = sqlite3.connect("rif.db")
#    cur = conn.cursor()

#    cur.execute(
#        "SELECT id FROM categories WHERE code = ?",
#        (category_code,)
#    )
#    cat_id = cur.fetchone()[0]

#    cur.execute("""
#        INSERT INTO cartridges
#        (category_id, obj, ref, ref2, sh)
#        VALUES (?, ?, ?, ?, ?)
#    """, (cat_id, obj, ref, ref2, sh))

#    conn.commit()
#    conn.close()
