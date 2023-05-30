using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ControlCatalogStandalone.ViewModels;

namespace ControlCatalogStandalone.Pages
{
    public partial class ExpanderPage : UserControl
    {
        public ExpanderPage()
        {
            InitializeComponent();
            DataContext = new ExpanderPageViewModel();

            var CollapsingDisabledExpander = this.Get<Expander>("CollapsingDisabledExpander");
            var ExpandingDisabledExpander = this.Get<Expander>("ExpandingDisabledExpander");

            CollapsingDisabledExpander.Collapsing += (s, e) => { e.Cancel = true; };
            ExpandingDisabledExpander.Expanding += (s, e) => { e.Cancel = true; };
        }

    }
}
