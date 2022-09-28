using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp
{
    public partial class ArticlePage : ContentPage
    {
        string articleSelectedShortName;
        public ArticlePage(Article articleSelected)
        {
            InitializeComponent();
            articleSelectedShortName = articleSelected.ShortName;
            if (articleSelectedShortName == "229")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/bf053e8b969bfd861d336011f3a28eadf0eb391e/#:~:text=%D0%9F%D0%BE%D1%80%D1%8F%D0%B4%D0%BE%D0%BA%20%D1%84%D0%BE%D1%80%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F%20%D0%BA%D0%BE%D0%BC%D0%B8%D1%81%D1%81%D0%B8%D0%B9%20%D0%BF%D0%BE%20%D1%80%D0%B0%D1%81%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8E%20%D0%BD%D0%B5%D1%81%D1%87%D0%B0%D1%81%D1%82%D0%BD%D1%8B%D1%85%20%D1%81%D0%BB%D1%83%D1%87%D0%B0%D0%B5%D0%B2,-(%D0%B2%20%D1%80%D0%B5%D0%B4.&text=%D0%94%D0%BB%D1%8F%20%D1%80%D0%B0%D1%81%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F%20%D0%BD%D0%B5%D1%81%D1%87%D0%B0%D1%81%D1%82%D0%BD%D0%BE%D0%B3%D0%BE%20%D1%81%D0%BB%D1%83%D1%87%D0%B0%D1%8F%20%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%BE%D0%B4%D0%B0%D1%82%D0%B5%D0%BB%D1%8C,%D1%81%D0%BE%D1%81%D1%82%D0%B0%D0%B2%D0%B5%20%D0%BD%D0%B5%20%D0%BC%D0%B5%D0%BD%D0%B5%D0%B5%20%D1%82%D1%80%D0%B5%D1%85%20%D1%87%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA.");
            }
            else if (articleSelectedShortName == "229.1")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/1ce5350302e90df5fe40985a3cd576ab0add7456/");
            }
            else if (articleSelectedShortName == "229.2")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/7a52ef3521995e6fcf4e9332c372b18d8e0b7788/");
            }
            else if (articleSelectedShortName == "229.3")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/f86e351f6b70406ad3db71896d95835f7741f2f7/");
            }
            else if (articleSelectedShortName == "230")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/eacfe8a4c78f8f76e6125e2752f013051932e224/");
            }
            else if (articleSelectedShortName == "228")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/af6bd8b7a7ccd909061b3b2651de752b9b184c3d/");
            }
            else if (articleSelectedShortName == "221")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/cab05a75d99b7e017c3ec285a0fa658773f00292/");
            }
            else if (articleSelectedShortName == "222")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/3e7c5171c1981e11a37c157504232d542c11a6b6/");
            }
            else if (articleSelectedShortName == "223")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/fb00d55bb4d6edffa1a76655354754e29af23823/");
            }
            else if (articleSelectedShortName == "225")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/ac72247ee2007f6df12028f034524dc13bc88c2e/");
            }
            else if (articleSelectedShortName == "226")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/ec6f6e5b3594a545c64c4cd046dce564b09456ac/");
            }
            else if (articleSelectedShortName == "216")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/449c8f584a8f883770d2c4028997a4d520419113/");
            }
            else if (articleSelectedShortName == "217")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/651d8ec0bc6209d48b7ee854c22d5f62baa35239/");
            }
            else if (articleSelectedShortName == "218")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/529c419d42c16421163c6da4dff2c8da9c9241b1/");
            }
            else if (articleSelectedShortName == "220")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/5e0181357c17e32b2f7eddb8c02e84b3a604d050/");
            }
            else if (articleSelectedShortName == "213")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/076b173c2907bea794c7a0a5a2fc52843e6730c8/");
            }
            else if (articleSelectedShortName == "214")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/4fe318e6d09155659a4381ef26a85e7df9ebcf94/");
            }
            else if (articleSelectedShortName == "215")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/d9e91b55bfaa1f838e128d214a7457657f9d56a1/");
            }
            else if (articleSelectedShortName == "209")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/78f36e7afa535cf23e1e865a0f38cd3d230eecf0/");
            }
            else if (articleSelectedShortName == "210")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/ed198846c41aa4fc2123f3abe0fe692a5587c5ed/");
            }
            else if (articleSelectedShortName == "211")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/2568238cb6e07472673b972d848231db8db4514d/");
            }
            else if (articleSelectedShortName == "212")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/7f308e0acbcc986b51caba3cb634a8bdbd94e7ef/");
            }
            else if (articleSelectedShortName == "190")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/a7049ae86657fdf15c13608876c58aa5c63003da/");
            }
            else if (articleSelectedShortName == "70")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/cc065f088bd92d312b5fae714377b25f557ac44a/");
            }
            else if (articleSelectedShortName == "122")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/56236a39da1eba84f52b37d378edbffd1710628e/");
            }
            else if (articleSelectedShortName == "67")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/6078748fd8dbb18fea7eae954601330d205c3c79/");
            }
            else if (articleSelectedShortName == "197")
            {
                WebVievArticlePage.Source = new Uri("http://www.consultant.ru/document/cons_doc_LAW_34683/e8e6750962ac75d8daa6b37c6e872fe185423bf5/");
            }
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }
}