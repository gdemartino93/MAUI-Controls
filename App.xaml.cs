using MAUI_Controls.CollectionsControls;

namespace MAUI_Controls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TableViewDemo();
        }
    }
}
