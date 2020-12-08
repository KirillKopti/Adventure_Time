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
            var homePage = typeof(Characters.FinntheKid);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "",
                ImagePath = "Fin.jpg",
                TargetPage = typeof(Characters.FinntheKid)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "",
                ImagePath = "Jake.jpg",
                TargetPage = typeof(Characters.Jake)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "",
                ImagePath = "BMO.jpg",
                TargetPage = typeof(Characters.BMO)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "",
                ImagePath = "bubblegum.jpg",
                TargetPage = typeof(Characters.PrincessGum)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "",
                ImagePath = "marceline.jpg",
                TargetPage = typeof(Characters.Marceline)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "",
                ImagePath = "IceKing.jpg",
                TargetPage = typeof(Characters.IceKing)
            });
        }
        private void AboutAT_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecdetMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selctedPage = selecdetMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selctedPage));
            IsPresented = false;
        }
        
    }
}
