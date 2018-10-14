using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EasyCrm.Models;
using EasyCrm.Views.ListViews;

namespace EasyCrm.Views
{
    public class Principal : ContentPage
    {
        ListView ListUser;

        public Principal()
        {
            StackLayout contentPrincipal = new StackLayout { HorizontalOptions = LayoutOptions.Center };


            ListUser = new ListView();

            ListUser.ItemsSource = App.ListUsers;
            ListUser.ItemTemplate = new DataTemplate(typeof(ViewUser));
            ListUser.RowHeight = 60;
            ListUser.IsPullToRefreshEnabled = true;
            ListUser.Refreshing += ListUser_Refreshing;

            ListUser.ItemSelected += (sender, e) =>
            {
                ((ListView)sender).SelectedItem = null;
            };

            ListUser.ItemTapped += (sender, e) =>
            {

            };

        }

        private void ListUser_Refreshing(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    
 }

