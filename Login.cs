using EasyCrm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EasyCrm.Views
{
    public class Login : ContentPage
    {
     
        
        public static Entry userEntry = new Entry { Placeholder = "Usuario" };
        Entry passEntry = new Entry { Placeholder = "Contraseña", IsPassword = true };
        Button submit = new Button { Text = "Aceptar" };

        

        Label RegistoLabel = new Label
             {
                Text = "REGISTRARME",
                FontSize = 15,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center
             };

        Label OlvidopassLabel = new Label
        {
            Text = "RECUPERAR CONTRASEÑA",
            FontSize = 15,
            TextColor = Color.Black,
            HorizontalTextAlignment = TextAlignment.Center
        };



        public Login()
        {
           

            TapGestureRecognizer tapForgot = new TapGestureRecognizer();
            TapGestureRecognizer tapCreateAccount = new TapGestureRecognizer();
            

            tapCreateAccount.Tapped += TapCreateAccount_Tapped;
            tapForgot.Tapped += TapForgot_Tapped;
            submit.Clicked += Submit_Clicked;


            RegistoLabel.GestureRecognizers.Add(tapCreateAccount);
            OlvidopassLabel.GestureRecognizers.Add(tapForgot);

            ScrollView scroll = new ScrollView();

            Content = new StackLayout
            {
                BackgroundColor = Color.Silver,
                Padding = 20,
                VerticalOptions = LayoutOptions.Center,
                Children = { userEntry, passEntry, submit, RegistoLabel, OlvidopassLabel }

            };
        }

        private async void Submit_Clicked(object sender, EventArgs e)
        {
            if (
                  string.IsNullOrEmpty((userEntry.Text))
                   || string.IsNullOrEmpty((passEntry.Text))
                  
                   )
            {
                await DisplayAlert("Notificacion", "Por favor complete todos los campos", "Aceptar");
                return;
            }

            Usuario Usuinvalido=null;


            foreach (Usuario usera in App.ListUsers)
            {
                if (usera.user.Equals(userEntry.Text))

                {

                    Usuinvalido = usera;
                    await Navigation.PushAsync(new Principal());
                    Navigation.RemovePage(this);
                }
            }
            if (Usuinvalido != null) {

                await Navigation.PushAsync(new Principal());
                Navigation.RemovePage(this);
               // await DisplayAlert("NOTIFICACION", "El usuario"+Usuinvalido.usuario, "ACEPTAR");
            }
            else
            {
                await DisplayAlert("NOTIFICACION", "No existe el usuario", "ACEPTAR");
            }
        }

        private async void TapForgot_Tapped(object sender, EventArgs e)
        {
          
            if (userEntry.Text.Equals(""))
            {
              await DisplayAlert("ALERTA", "DIGITE USUARIO", "ACEPTAR");
            return ;
            }
           else
            {
             await Navigation.PushAsync(new OlvidoPassword());
            }


        }

        private async void TapCreateAccount_Tapped(object sender, EventArgs e)
        {
           await  Navigation.PushAsync(new Registro());
   
        }
    }
}
