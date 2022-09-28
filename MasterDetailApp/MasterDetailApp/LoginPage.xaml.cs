using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public static User userGlobal;
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            await App.Database.CreateTableUsers();
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool Chek1 = false;
            List<User> users = await App.Database.GetItemsAsyncUsers() ;
            foreach (var item in users)
            {   
                if ((EntryLogin.Text == item.Login) && (EntryPassword.Text == item.Password))  
                {
                    Chek1 = true;
                    userGlobal = item;
                    Navigation.RemovePage(this);
                    await Navigation.PushAsync(new TestPage(item));
                }
            }
            if (Chek1 == false)
            {
                LoginPageLabel.Text = "Неверный логин или пароль";
            }

        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegPage());
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}