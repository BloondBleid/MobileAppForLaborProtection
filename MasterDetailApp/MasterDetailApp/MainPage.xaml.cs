using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailApp
{ 
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.FromHex("#3498db")
            };
            IsPresented = true;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (LoginPage.userGlobal != null ) {
                Detail = new NavigationPage(new AboutCompany())
                {
                    BarBackgroundColor = Color.FromHex("#3498db")
                };
                IsPresented = false;
                Detail.Navigation.PushAsync(new TestPage(LoginPage.userGlobal));
            }
            else {
                Detail = new NavigationPage(new AboutCompany())
                {
                    BarBackgroundColor = Color.FromHex("#3498db")
                };
                IsPresented = false;
                Detail.Navigation.PushAsync(new LoginPage());
            }
            
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.FromHex("#3498db")
            };
            IsPresented = false;
            Detail.Navigation.PushAsync(new Theory());
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.FromHex("#3498db")
            };
            IsPresented = false;
            Detail.Navigation.PushAsync(new RouteNewMan());
        }
        private void Button4_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.FromHex("#3498db")
            };
            IsPresented = false;
            Detail.Navigation.PushAsync(new About());
        }
        private void Button5_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.FromHex("#3498db")
            };
            IsPresented = false;
        }
        private void Button6_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutCompany())
            {
                BarBackgroundColor = Color.FromHex("#3498db")
            };
            IsPresented = false;
            Detail.Navigation.PushAsync(new News());
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
