using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    public partial class TabStripPage : UserControl
    {
        public TabStripPage()
        {
            InitializeComponent();

            DataContext = new TabControlPageViewModel
            {
                Tabs = new []
                {
                    new TabControlPageViewModelItem()
                    {
                        Header = "Item 1",
                    },
                    new TabControlPageViewModelItem
                    {
                        Header = "Item 2",
                    },
                    new TabControlPageViewModelItem
                    {
                        Header = "Disabled",
                        IsEnabled = false,
                    },
                }
            };
        }

    }
}
