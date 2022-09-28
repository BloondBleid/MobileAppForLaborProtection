using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Testing : ContentPage
    {
        private int RigthAns;
        private int checkAns;
        private static int CountQuestion;
        private static int CountRigth;
        private int CountRigthNow = 0;
        private List<int> chisla;
        private int IdQuestion;
        private int IdAns1;
        private int IdAns2;
        private int IdAns3;
        private int IdAns4;
        private int CountQ = 0;
        public Testing(User user)
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (checkAns == RigthAns)
            {
                Results res = new Results();
                res.check = 1;
                res.dateTimeAnsw = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                res.userId = LoginPage.userGlobal.Id;
                res.forQuestionID = IdQuestion;
                CountRigthNow += 1;
                if (CountRigth <= CountRigthNow)
                {
                    LoginPage.userGlobal.Trained = 1;
                }
                await App.Database.SaveItemAsyncResults(res);
            }
            else
            {
                Results res = new Results();
                res.check = 0;
                res.dateTimeAnsw = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                res.userId = LoginPage.userGlobal.Id;
                res.forQuestionID = IdQuestion;
                await App.Database.SaveItemAsyncResults(res);
            }
            CountQuestion -= 1;
            if (CountQuestion != 0)
            {
                QuestionLabel.Text = TestPage.questions[chisla[CountQ] - 1].TextQuestion.ToString();
                IdQuestion = TestPage.questions[chisla[CountQ] - 1].Id;
                foreach (var item in TestPage.answers)
                {
                    if (item.ForQuestionID == IdQuestion)
                    {
                        Ans4LabelR.Content = item.Answer.ToString();
                        IdAns4 = item.Id;
                        if (item.CorrectAnswer == 1)
                        {
                            RigthAns = item.Id;
                        }
                    }
                }
                IdAns1 = TestPage.answers[IdAns4 - 4].Id;
                IdAns2 = TestPage.answers[IdAns4 - 3].Id;
                IdAns3 = TestPage.answers[IdAns4 - 2].Id;
                Ans1LabelR.Content = TestPage.answers[IdAns4 - 4].Answer.ToString();
                Ans2LabelR.Content = TestPage.answers[IdAns4 - 3].Answer.ToString();
                Ans3LabelR.Content = TestPage.answers[IdAns4 - 2].Answer.ToString();
            }
            else
            {
                Navigation.RemovePage(this);
                await Navigation.PushAsync(new ResultPage(CountRigthNow));
            }
            CountQ += 1;
            await App.Database.SaveItemAsyncUsers(LoginPage.userGlobal);
        }
        private async void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginPage.userGlobal.Trained = 0;
            LoginPage.userGlobal.Complexity = picker1.Items[picker1.SelectedIndex];
            if (picker1.Items[picker1.SelectedIndex] == "Мастер")
            {
                LoginPage.userGlobal.CountQuestions = 9;
                LoginPage.userGlobal.CountRigth = 8;
            }
            if (picker1.Items[picker1.SelectedIndex] == "Новичок")
            {
                LoginPage.userGlobal.CountQuestions = 3;
                LoginPage.userGlobal.CountRigth = 1;
            }
            await App.Database.SaveItemAsyncUsers(LoginPage.userGlobal);
            LabelVar.IsVisible = false;
            picker1.IsVisible = false;

            CountQuestion = LoginPage.userGlobal.CountQuestions;
            CountRigth = LoginPage.userGlobal.CountRigth;
            var rnd = new Random();
            chisla = Enumerable.Range(1, CountQuestion).OrderBy(x => rnd.Next()).Take(CountQuestion).ToList();

            QuestionLabel.Text = TestPage.questions[chisla[CountQ] - 1].TextQuestion.ToString();
            IdQuestion = TestPage.questions[chisla[CountQ] - 1].Id;
            IdAns4 = 10;
            LabelQuestionName.IsVisible = true;
            QuestionLabel.IsVisible = true;
            foreach (var item in TestPage.answers)
            {
                if (item.ForQuestionID == IdQuestion)
                {
                    Ans4LabelR.Content = item.Answer.ToString();
                    IdAns4 = item.Id;
                    if (item.CorrectAnswer == 1)
                    {
                        RigthAns = item.Id;
                    }
                }
            }
            IdAns1 = TestPage.answers[IdAns4 - 4].Id;
            IdAns2 = TestPage.answers[IdAns4 - 3].Id;
            IdAns3 = TestPage.answers[IdAns4 - 2].Id;
            Ans1LabelR.Content = TestPage.answers[IdAns4 - 4].Answer.ToString();
            Ans2LabelR.Content = TestPage.answers[IdAns4 - 3].Answer.ToString();
            Ans3LabelR.Content = TestPage.answers[IdAns4 - 2].Answer.ToString();

            Ans1LabelR.IsVisible = true;
            Ans2LabelR.IsVisible = true;
            Ans3LabelR.IsVisible = true;
            Ans4LabelR.IsVisible = true;
            Ans5LabelR.IsVisible = true;
            ButtonTesting.IsVisible = true;
            CountQ += 1;
        }

        private void Ans1LabelR_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkAns = IdAns1;
        }
        private void Ans2LabelR_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkAns = IdAns2;
        }
        private void Ans3LabelR_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkAns = IdAns3;
        }
        private void Ans4LabelR_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkAns = IdAns4;
        }
        private void Ans5LabelR_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            checkAns = 0;
        }
    }
}