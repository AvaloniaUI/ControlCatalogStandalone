using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    public partial class SplitViewPage : UserControl
    {
        public SplitViewPage()
        {
            InitializeComponent();
            DataContext = new SplitViewPageViewModel();
        }

    }
}
