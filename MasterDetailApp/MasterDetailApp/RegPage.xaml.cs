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
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //SaveItemAsync(Article item)
            if (EntryPassword1.Text == EntryPassword2.Text)
            {
                User userReg = new User();
                userReg.Name = EntryName.Text;
                userReg.Surname = EntrySurname.Text;
                userReg.Patronymic = EntryPatronymic.Text;
                userReg.Email = EntryEmail.Text;
                userReg.Login = EntryLogin.Text;
                userReg.Password = EntryPassword1.Text;
                userReg.Category = 1;
                userReg.Trained = 0;
                userReg.CountQuestions = 3;
                userReg.CountRigth = 1;
                userReg.Complexity = "Новичок";
                await App.Database.SaveItemAsyncUsers(userReg);
                await Navigation.PopAsync();
            }
            else 
            { 
                RegLabel1.TextColor = Color.Red;
                RegLabel1.Text = "Повторите попытку!";
            }
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}