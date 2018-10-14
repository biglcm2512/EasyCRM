using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EasyCrm.Models;


namespace EasyCrm.Views
{
    public class Registro : ContentPage
    {
        Entry userEntry = new Entry { Placeholder = "Usuario" };
        Entry nameEntry = new Entry { Placeholder = "Nombre" };
        Entry apellidoEntry = new Entry { Placeholder = "Apellido" };
        Entry cursoEntry = new Entry { Placeholder = "Curso" };
        Entry fechaEntry = new Entry { Placeholder = "Fecha" };
        Button submit = new Button { Text = "Crear Cuenta" };

        public Registro()
        {

            Label tituloLabel = new Label
            {
                Text = "REGISTRAR USUARIO",
                FontSize = 20,
                HorizontalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(0, 0, 0, 50)
            };
           


            submit.Clicked += Submit_Clicked;




            Content = new StackLayout
            {

                BackgroundColor = Color.Silver,
                Padding = 20,
                VerticalOptions = LayoutOptions.Center,
                Children = { userEntry,nameEntry, apellidoEntry, cursoEntry, fechaEntry, submit }

            };
        }

        private async void Submit_Clicked(object sender, EventArgs e)
        {
            if (
                 string.IsNullOrEmpty((userEntry.Text))
                  || string.IsNullOrEmpty((nameEntry.Text))
                  || string.IsNullOrEmpty((apellidoEntry.Text))
                  || string.IsNullOrEmpty((cursoEntry.Text))
                  || string.IsNullOrEmpty((fechaEntry.Text))

                  )
            {
                await DisplayAlert("registro", "completado", "o.k");
                return;
            }
            

            Usuario dataUser = new Usuario
            {
                user= userEntry.Text,
                nombre = nameEntry.Text,
                apellido = apellidoEntry.Text,
                curso = cursoEntry.Text,
                fecha = fechaEntry.Text
            };
            App.ListUsers.Add(dataUser);
            {
                await DisplayAlert("registro", "completado", "o.k");
                return;
            }


        }
     }
}
