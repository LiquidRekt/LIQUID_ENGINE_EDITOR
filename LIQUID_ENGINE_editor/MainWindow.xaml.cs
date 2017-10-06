using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIQUID_ENGINE_editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void coming_Soon()
        {
            MessageBox.Show("Coming Soon!");
        }

        private void create_Project(object sender, RoutedEventArgs e)
        {
            CreatingProject createProject = new CreatingProject();
            createProject.Show();
            this.Close();
        }
        private void open_Project(object sender, RoutedEventArgs e)
        {
            OpenProject openProject = new OpenProject();
            openProject.Show();
            this.Close();
        }
        private void download_Assets(object sender, RoutedEventArgs e)
        {
            DownloadAssets downloadAssets = new DownloadAssets();
            downloadAssets.Show();
            this.Close();
        }
    }
   
}
