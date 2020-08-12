using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TDW.Properties;
using System.IO;
using System.Windows.Media.Media3D;
using HelixToolkit;
using HelixToolkit.Wpf;

namespace TDW
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MAIN : Window
    {
        Model3DGroup ammo;
        Model3D shot;
        public Model3D model { get; set;}
         public MAIN()
        {
            InitializeComponent();
            ModelImporter imp = new ModelImporter();
            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.Beige));
            imp.DefaultMaterial = material;
            ammo = new Model3DGroup();
            shot = imp.Load(@"RES/A_IMG/BC/50BMG.obj");
            ammo.Children.Add(shot);
            this.model = ammo;
            
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_Min(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }
        private void Move_window(object sender, MouseButtonEventArgs e) 
        {
            this.DragMove();
        }
    }
}
