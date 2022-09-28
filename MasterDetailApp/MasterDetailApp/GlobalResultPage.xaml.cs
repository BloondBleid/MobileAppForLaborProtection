using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace MasterDetailApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlobalResultPage : ContentPage
    {
        private static int CountQuestion = 0;
        private static int CountRigth = 0;
        private static double PercRigth = 0;
        public GlobalResultPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CountQuestion = 0;
            CountRigth = 0;
            PercRigth = 0;

            if ((Calendar1.SelectedDate.ToString() != "") && (Calendar2.SelectedDate.ToString() != ""))
            {
                DateTime date1 = DateTime.Parse(Calendar1.SelectedDate.ToString());
                DateTime date2 = DateTime.Parse(Calendar2.SelectedDate.ToString());
                date2 = date2.AddDays(1);
                if (date1 <= date2)
                {
                    foreach (var item in TestPage.results)
                    {
                        DateTime date3 = DateTime.Parse(item.dateTimeAnsw.ToString());
                        if ((date1 <= date3) && (date2 >= date3) && (item.check == 1) && (LoginPage.userGlobal.Id == item.userId))
                        {
                            CountQuestion += 1;
                            CountRigth += 1;
                        }
                        else if ((date1 <= date3) && (date2 >= date3) && (item.check != 1) && (LoginPage.userGlobal.Id == item.userId))
                        {
                            CountQuestion += 1;
                        }
                    }
                    if (CountQuestion != 0) { PercRigth = (Convert.ToDouble(CountRigth) / Convert.ToDouble(CountQuestion)) * 100; }
                    CountQuestionLabel.Text = "Общее количество вопросов: " + CountQuestion.ToString();
                    CountRigthLabel.Text = "Общее количество правильных ответов: " + CountRigth.ToString();
                    PercRigthLabel.Text = "Процент правильных ответов: " + PercRigth.ToString("0.00") + "%";
                }
                else { CountQuestionLabel.Text = "Некорректно указаны даты, проверьте еще раз"; }
                
            }
            else { CountQuestionLabel.Text = "Не указаны даты, проверьте еще раз"; }




            List<Entry> entries = new List<Entry>()
            {
            new Entry(float.Parse(PercRigth.ToString("0.00")))
            {
                Color = SKColor.Parse("#00BFFF"),
                Label = "Правильных ответов",
                ValueLabel=PercRigth.ToString("0.00")+"%",
                ValueLabelColor = SKColor.Parse("#00BFFF"),
                TextColor = SKColor.Parse("#000000")
            },
            new Entry(100-float.Parse(PercRigth.ToString("0.00")))
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "Неправильных ответов",
                ValueLabel=(100-PercRigth).ToString("0.00")+"%",
                ValueLabelColor = SKColor.Parse("#FF1493"),
                TextColor = SKColor.Parse("#000000")
            }
            };
            //Chart1.Chart = new BarChart { Entries = entries, IsAnimated = true };
            Chart1.Chart = new DonutChart { Entries = entries, IsAnimated = true, LabelTextSize = 30f };
            //Chart1.Chart = new LineChart { Entries = entries, IsAnimated = true };
            //Chart1.Chart = new PieChart { Entries = entries, IsAnimated = true };

            //Chart1.Chart = new RadarChart { Entries = entries, IsAnimated = true };
            //Chart1.Chart = new RadialGaugeChart { Entries = entries, IsAnimated = true };
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}