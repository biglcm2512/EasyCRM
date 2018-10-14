using EasyCrm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EasyCrm.Views
{
   public class App : Application
    {
        public static List<Usuario> ListUsers;


        public App()
        {
            ListUsers = new List<Usuario>();
            Login _page = new Login();

            MainPage = new NavigationPage(_page);
           //MainPage = new NavigationPage(new Login());
           // MainPage = new Registro();

        }


    }
}
