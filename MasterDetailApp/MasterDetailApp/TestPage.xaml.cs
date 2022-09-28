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
    public partial class TestPage : ContentPage
    {
        public static List<Questions> questions;
        public static List<Answers> answers;
        public static List<Results> results;
        public TestPage(User user)
        {
            InitializeComponent();
            TestLabel.Text = "Здравствуйте, " + LoginPage.userGlobal.Name.ToString() + " " + user.Surname.ToString() + "!";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            questions = await App.Database.GetItemsAsyncQuestions();
            answers = await App.Database.GetItemsAsyncAnswers();
            await Navigation.PushAsync(new Testing(LoginPage.userGlobal));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            results = await App.Database.GetItemsAsyncResults();
            await Navigation.PushAsync(new GlobalResultPage());
        }
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            results = await App.Database.GetItemsAsyncResults();
            await Navigation.PushAsync(new ChangePage(LoginPage.userGlobal));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            LoginPage.userGlobal = null;
            Navigation.PopAsync();
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}