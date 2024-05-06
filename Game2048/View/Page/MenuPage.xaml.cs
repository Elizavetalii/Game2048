using Game2048.ViewModel.Base;

namespace Game2048.View.Page
{
    public partial class MenuPage 
    {
        static bool isDark = true;
        public MenuPage()
        {
            InitializeComponent();
            if(App.Theme == "ThemeLight")
            {
                Themes.Content = "To Dark";
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (isDark)
            {
                Themes.Content = "To Dark";
                App.Theme = "ThemeLight";
            }
            else
            {
                Themes.Content = "To Light";
                App.Theme = "ThemeDark";
            }
            isDark = !isDark;       
        }
    }
}
