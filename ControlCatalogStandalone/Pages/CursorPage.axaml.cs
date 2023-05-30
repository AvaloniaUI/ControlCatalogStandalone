using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    public partial class CursorPage : UserControl
    {
        public CursorPage()
        {
            this.InitializeComponent();
            DataContext = new CursorPageViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
