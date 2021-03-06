﻿using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace SLU.XamarinTest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);
            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.main_navigation);
            bottomNavigation.SetOnNavigationItemSelectedListener(this);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.main_navigation_items:
                    textMessage.SetText(Resource.String.title_items);
                    return true;

                case Resource.Id.main_navigation_wholesalers:
                    textMessage.SetText(Resource.String.title_wholesalers);
                    return true;

                case Resource.Id.main_navigation_used_items:
                    textMessage.SetText(Resource.String.title_used_items);
                    return true;
            }
            return false;
        }
    }
}