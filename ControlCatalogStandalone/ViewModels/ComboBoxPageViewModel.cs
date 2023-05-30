using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Selection;
using CommunityToolkit.Mvvm.ComponentModel;
using MiniMvvm; 

namespace ControlCatalogStandalone.ViewModels
{
    public partial class ComboBoxPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _wrapSelection;
 

        public ObservableCollection<IdAndName> Values { get; set; } = new ObservableCollection<IdAndName>
        {
            new IdAndName(){ Id = "Id 1", Name = "Name 1" },
            new IdAndName(){ Id = "Id 2", Name = "Name 2" },
            new IdAndName(){ Id = "Id 3", Name = "Name 3" },
            new IdAndName(){ Id = "Id 4", Name = "Name 4" },
            new IdAndName(){ Id = "Id 5", Name = "Name 5" },
        };
    }

    public class IdAndName
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
