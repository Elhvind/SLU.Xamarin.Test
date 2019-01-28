using SLU.XamarinFormsTest.Services;
using Xamarin.Forms;

namespace SLU.XamarinFormsTest
{
    public partial class MainPage : ContentPage
    {
        private readonly IItemsService _itemService;

        public MainPage()
        {
            _itemService = new ItemsService();

            InitializeComponent();

            var allItems = _itemService.GetAll();
            itemList.ItemsSource = allItems;
        }
    }
}
