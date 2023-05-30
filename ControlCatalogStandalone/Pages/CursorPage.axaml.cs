using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    public partial class CursorPage : UserControl
    {
        public CursorPage()
        {
            InitializeComponent();
            DataContext = new CursorPageViewModel();
        }

    }
}
