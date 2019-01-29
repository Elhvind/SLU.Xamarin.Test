using SLU.XamarinFormsTest.Models.Items;
using SLU.XamarinFormsTest.Services;
using SLU.XamarinFormsTest.ViewModels.Items;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SLU.XamarinFormsTest.Pages.Items
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemListPage : ContentPage
    {
        private readonly IItemsService _itemService;

        public ItemListPage()
        {
            _itemService = new ItemsService();

            InitializeComponent();

            BindingContext = new ItemListViewModel();

            LoadItems();
        }

        public async void ItemListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var tappedItem = (ItemDTO)e.Item;

            await DisplayAlert(tappedItem.Name, $"Pris: {tappedItem.Price}", "OK");

            var itemListView = (ListView)sender;

            //Deselect Item
            itemListView.SelectedItem = null;
        }

        private async void LoadItems()
        {
            var allItems = _itemService.GetAll();
            ItemListView.ItemsSource = await allItems;
        }
    }
}