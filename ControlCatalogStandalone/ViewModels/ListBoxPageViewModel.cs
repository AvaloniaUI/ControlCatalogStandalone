using System;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Selection;
using CommunityToolkit.Mvvm.ComponentModel;
using ControlCatalogStandalone.Pages;
using MiniMvvm;

namespace ControlCatalogStandalone.ViewModels
{
    public partial class ListBoxPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _multiple;
        [ObservableProperty]
        private bool _toggle;
        [ObservableProperty]
        private bool _alwaysSelected;
        [ObservableProperty]
        private bool _autoScrollToSelectedItem = true;
        [ObservableProperty]
        private bool _wrapSelection;
        [ObservableProperty]
        private int _counter;
        [ObservableProperty]
        private IObservable<SelectionMode> _selectionMode;

        public ListBoxPageViewModel()
        {
            Items = new ObservableCollection<ItemModel>(Enumerable.Range(1, 10000).Select(i => GenerateItem()));
            
            Selection = new SelectionModel<ItemModel>();
            Selection.Select(1);

            _selectionMode = this.WhenAnyValue(
                x => x.Multiple,
                x => x.Toggle,
                x => x.AlwaysSelected,
                (m, t, a) =>
                    (m ? Avalonia.Controls.SelectionMode.Multiple : 0) |
                    (t ? Avalonia.Controls.SelectionMode.Toggle : 0) |
                    (a ? Avalonia.Controls.SelectionMode.AlwaysSelected : 0));

            AddItemCommand = MiniCommand.Create(() => Items.Add(GenerateItem()));

            RemoveItemCommand = MiniCommand.Create(() =>
            {
                var items = Selection.SelectedItems.ToList();

                foreach (var item in items)
                {
                    Items.Remove(item);
                }
            });

            SelectRandomItemCommand = MiniCommand.Create(() =>
            {
                var random = new Random();

                using (Selection.BatchUpdate())
                {
                    Selection.Clear();
                    Selection.Select(random.Next(Items.Count - 1));
                }
            });
        }

        public ObservableCollection<ItemModel> Items { get; }
        public SelectionModel<ItemModel> Selection { get; }

        public MiniCommand AddItemCommand { get; }
        public MiniCommand RemoveItemCommand { get; }
        public MiniCommand SelectRandomItemCommand { get; }

        private ItemModel GenerateItem() => new ItemModel(_counter ++);  
    }

    /// <summary>
    /// An Item model for the <see cref="ListBoxPage"/>
    /// </summary>
    public class ItemModel
    {
        /// <summary>
        /// Creates a new ItemModel with the given ID
        /// </summary>
        /// <param name="id">The ID to display</param>
        public ItemModel(int id)
        {
            ID = id;
        }

        /// <summary>
        /// The ID of this Item
        /// </summary>
        public int ID { get; }

        public override string ToString()
        {
            return $"Item {ID}";
        }
    }
}
