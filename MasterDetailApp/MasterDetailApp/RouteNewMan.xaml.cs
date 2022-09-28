using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.DocIO;
using System.Reflection;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp
{
    public partial class RouteNewMan : ContentPage
    {
        public RouteNewMan()
        {
            InitializeComponent();
            
        }
        private async void DocList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) 
            { return; }
            else { 
            bool result = await DisplayAlert("Подтвердить действие", "Вы хотите просмотреть или скачать документ?", "Просмотреть", "Скачать");

            if ((e.SelectedItem.ToString() == "Разрешения на проведение работ в охранных зонах сети газораспределения")&&(result  == true))
            {
                var uri = new Uri("https://1drv.ms/w/s!Al669aJSNVVthwqtmOWJIRm0EQmW?e=Pjcv9f");
                await Navigation.PushAsync(new Documents(uri));
            }
            else if((e.SelectedItem.ToString() == "Лист ознакомления со сторонами организации 2022")&& (result == true))
            {
                var uri = new Uri("https://1drv.ms/w/s!Al669aJSNVVthwsKOBboKWlqG1PB?e=L9n0j4");
                await Navigation.PushAsync(new Documents(uri));
            }
            else if ((e.SelectedItem.ToString() == "Акт передачи объекта ООО «Газпром трансгаз Казань» для производства работ сторонней организацией")&& (result == true))
            {
                var uri = new Uri("https://1drv.ms/w/s!Al669aJSNVVthwwsg0G6aJ-IuQZa?e=RTCjEk");
                await Navigation.PushAsync(new Documents(uri));
            }
            else if ((e.SelectedItem.ToString() == "Акт-допуск для производства работ на территории структурного подразделения ООО «Газпром трансгаз Казань» ЭПУ «газ»") && (result == true))
            {
                var uri = new Uri("https://1drv.ms/w/s!Al669aJSNVVthwXEH-Msxugbmpdx?e=5CNWDG");
                await Navigation.PushAsync(new Documents(uri));
            }
            else if ((e.SelectedItem.ToString() == "(Доп. информация) Ключевые правила безопасности ПАО «ГАЗПРОМ»")&& (result == true))
            {
                var uri = new Uri("https://1drv.ms/u/s!Al669aJSNVVthw3rEURSY3mCEt1D?e=jjIxGl");
                await Navigation.PushAsync(new Documents(uri));
            }
            else if ((e.SelectedItem.ToString() == "(Доп. информация) Политика ПАО «ГАЗПРОМ» в области охраны труда, промышленной и пожарной безопасности, безопасности дорожного движения")&& (result == true))
            {
                var uri = new Uri("https://1drv.ms/u/s!Al669aJSNVVthw66onsSktwperLf?e=3MIpS0");
                await Navigation.PushAsync(new Documents(uri));
            }

            if ((e.SelectedItem.ToString() == "Разрешения на проведение работ в охранных зонах сети газораспределения") && (result == false))
            {
                var uri = new Uri("https://drive.google.com/uc?export=download&id=1d1b-g5IYGoj0hX0Fec3ueuCz4wVK9zIF");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            else if ((e.SelectedItem.ToString() == "Лист ознакомления со сторонами организации 2022") && (result == false))
            {
                var uri = new Uri("https://drive.google.com/uc?export=download&id=1dL1eBz7KVt8OvgyA6GEG0h_mEuhsSh5d");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            else if ((e.SelectedItem.ToString() == "Акт передачи объекта ООО «Газпром трансгаз Казань» для производства работ сторонней организацией") && (result == false))
            {
                var uri = new Uri("https://drive.google.com/uc?export=download&id=11N5fKjlc9GYnR6lvKxSvdS9veDVZN1nX");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            else if ((e.SelectedItem.ToString() == "Акт-допуск для производства работ на территории структурного подразделения ООО «Газпром трансгаз Казань» ЭПУ «газ»") && (result == false))
            {
                var uri = new Uri("https://drive.google.com/uc?export=download&id=1kxQuAoPocZlRR0PHeJ1UbVEiuGh8fbwO");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            else if ((e.SelectedItem.ToString() == "(Доп. информация) Ключевые правила безопасности ПАО «ГАЗПРОМ»") && (result == false))
            {
                var uri = new Uri("https://drive.google.com/uc?export=download&id=1pmL2MkjWuIgMoZUUoH_hhegoXhPKKlAe");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            else if ((e.SelectedItem.ToString() == "(Доп. информация) Политика ПАО «ГАЗПРОМ» в области охраны труда, промышленной и пожарной безопасности, безопасности дорожного движения") && (result == false))
            {
                var uri = new Uri("https://drive.google.com/uc?export=download&id=1DOA2HdopmIhq2ZWwc4LYVpkVx46jsuF4");
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            DocList1.SelectedItem = null;
            }

        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }


    }
}