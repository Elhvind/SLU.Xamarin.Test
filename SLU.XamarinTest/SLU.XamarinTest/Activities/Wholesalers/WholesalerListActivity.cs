using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace SLU.XamarinTest.Activities.Wholesalers
{
    [Activity(Label = "Wholesaler list", Theme = "@style/AppTheme")]
    public class WholesalerListActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_wholesaler_list);

            // Create your application here
            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.main_navigation);
            bottomNavigation.SetOnNavigationItemSelectedListener(this);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.main_navigation_items:
                    SetContentView(Resource.Layout.activity_item_list);
                    return true;

                case Resource.Id.main_navigation_wholesalers:
                    SetContentView(Resource.Layout.activity_wholesaler_list);
                    return true;

                case Resource.Id.main_navigation_used_items:
                    return true;
            }
            return false;
        }
    }
}