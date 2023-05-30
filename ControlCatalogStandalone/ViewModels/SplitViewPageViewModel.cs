using System;
using System.ComponentModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel; 

namespace ControlCatalogStandalone.ViewModels
{
    public partial class SplitViewPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _isLeft = true;
        [ObservableProperty]
        private int _displayMode = 3; //CompactOverlay

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(IsLeft):
                    base.OnPropertyChanged(new PropertyChangedEventArgs(nameof(PanePlacement)));
                    break;
                case nameof(DisplayMode):
                    base.OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentDisplayMode)));
                    break;
            }

            base.OnPropertyChanged(e);
        }

        public SplitViewPanePlacement PanePlacement => IsLeft ? SplitViewPanePlacement.Left : SplitViewPanePlacement.Right;
        
        public SplitViewDisplayMode CurrentDisplayMode
        {
            get
            {
                if (Enum.IsDefined(typeof(SplitViewDisplayMode), DisplayMode))
                {
                    return (SplitViewDisplayMode)DisplayMode;
                }
                return SplitViewDisplayMode.CompactOverlay;
            }
        }
    }
}
