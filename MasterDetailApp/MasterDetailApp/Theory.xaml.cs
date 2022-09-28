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
    public partial class Theory : ContentPage
    {
        public Theory()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            ArticlesList.ItemsSource = await App.Database.GetItemsAsync();
            base.OnAppearing();
        }
        private void ArticlesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Article selectedArticle = (Article)e.SelectedItem;
            ArticlePage articlePage = new ArticlePage(selectedArticle);
            articlePage.BindingContext = selectedArticle;
            Navigation.PushAsync(articlePage);
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}