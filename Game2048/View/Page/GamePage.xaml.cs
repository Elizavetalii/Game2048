using Game2048.Converter;
using System.Windows;

namespace Game2048.View.Page
{
    public partial class GamePage
    {      
        public GamePage()
        {
            InitializeComponent();
            ValueToColorConverter valueToColorConverter = new ValueToColorConverter();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Focus();
        }
    }
}
