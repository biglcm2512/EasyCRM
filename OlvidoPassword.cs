using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EasyCrm.Views
{
   public class OlvidoPassword : ContentPage
    {

        
        Entry userEntry = new Entry {
       
            Placeholder = Login.userEntry.Text

        };
        Button submit = new Button { Text = "Recuperar" };


        public OlvidoPassword()
        {
            

            Content = new StackLayout
            {
                BackgroundColor = Color.Silver,
                Padding = 20,
                VerticalOptions = LayoutOptions.Center,
                Children = { UserEntryO, submit  }

            };


        }

        public Entry UserEntryO { get => userEntry; set => userEntry = value; }
    }
}
