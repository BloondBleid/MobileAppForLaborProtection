using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace MasterDetailApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(int CountRigthNow)
        {
            InitializeComponent();
            LabelResults.Text += CountRigthNow + " из " + LoginPage.userGlobal.CountQuestions;
            LabelResults3.Text = "Сложность: " + LoginPage.userGlobal.Complexity.ToString();
            if (LoginPage.userGlobal.Trained == 1) {LabelResults2.Text = "Тест пройден!";}
            else 
            {
                LabelResults2.Text = "Тест провален!";
            }
            List<Entry> entries = new List<Entry>()
            {
            new Entry(float.Parse(CountRigthNow.ToString()))
            {
                Color = SKColor.Parse("#00BFFF"),
                Label = "Правильных ответов",
                ValueLabel=CountRigthNow.ToString(),
                ValueLabelColor = SKColor.Parse("#00BFFF"),
                TextColor = SKColor.Parse("#000000")
            },
            new Entry(LoginPage.userGlobal.CountQuestions-float.Parse(CountRigthNow.ToString()))
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "Неправильных ответов",
                ValueLabel=(LoginPage.userGlobal.CountQuestions-CountRigthNow).ToString(),
                ValueLabelColor = SKColor.Parse("#FF1493"),
                TextColor = SKColor.Parse("#000000")
            }
            };
            //Chart1.Chart = new BarChart { Entries = entries, IsAnimated = true };
            Chart1.Chart = new DonutChart { Entries = entries, IsAnimated = true, LabelTextSize = 25f };
            Chart1.IsVisible = true;

        }
    }
}