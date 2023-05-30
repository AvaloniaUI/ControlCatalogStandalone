using Avalonia.Controls;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ControlCatalogStandalone.ViewModels;

public partial class TabControlPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private Dock _tabPlacement;

    public TabControlPageViewModelItem[]? Tabs { get; set; }
 
}

public class TabControlPageViewModelItem
{
    public string? Header { get; set; }
    public string? Text { get; set; }
    public Bitmap? Image { get; set; }
    public bool IsEnabled { get; set; } = true;
}
