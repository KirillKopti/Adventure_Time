using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Adventure_Time
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profilImage.Source = ImageSource.FromFile("AT.jpg");
            aboutAT.ItemsSource = GetMenuList();
            var homePage = typeof(Characters.FinntheKidPage);

        }

        private IEnumerable GetMenuList()
        {
            throw new NotImplementedException();
        }
    }
}
