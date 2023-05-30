using Avalonia;
using CommunityToolkit.Mvvm.ComponentModel;
using MiniMvvm;

namespace ControlCatalogStandalone.ViewModels
{
    public partial class ExpanderPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private object _cornerRadius = AvaloniaProperty.UnsetValue;
        [ObservableProperty]
        private bool _rounded;
    }
}
