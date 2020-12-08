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
                Detail = "Фин Обладает строгим моральным кодексом, Финн поклялся, " +
                "что поможет любому, кто в этом нуждается, и часто совершает героические " +
                "подвиги со своим лучим дрцгом Джеком",
                ImagePath = "Fin.jpg",
                TargetPage = typeof(Characters.FinntheKid)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "Джейк это волшебный пес, который помагает своему лучшему другу Фину в приключениях",
                ImagePath = "Jake.jpg",
                TargetPage = typeof(Characters.Jake)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "БиМО — это игровая видео-приставка Финна и Джейка, " +
                "а также портативная розетка, плеер, камера, будильник, тостер, " +
                "фонарик, стробоскоп, программа для редактирования видео, " +
                "видео-плеер,зарядное устройство, магнитофон и просто друг и сосед.",
                ImagePath = "BMO.jpg",
                TargetPage = typeof(Characters.BMO)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "Жвачка, как правило, очень добрая и сострадательная, " +
                "у нее сильное чувство справедливости, хотя она показывает темную сторону, " +
                "когда ее провоцируют. Она очень умна и отвечает за создание Конфетных Людей, " +
                "а также за создание различных устройств, включая миниатюрную машину времени. ",
                ImagePath = "bubblegum.jpg",
                TargetPage = typeof(Characters.PrincessGum)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "Она вампир но в отличие от традиционного вампира, Марселин не нужно пить кровь, чтобы выжить; скорее она просто пьёт красный цвет. " +
                "Марселин также музыкантша, что играет на электронной бас-гитаре. " +
                "Она сделала из своего боевого топора, что когда-то был семейной реликвией.",
                ImagePath = "marceline.jpg",
                TargetPage = typeof(Characters.Marceline)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "AdventureTime",
                Detail = "Ледяной Король — пожилой мужчина низкого роста с голубым цветом кожи, " +
                "крючковатыми пальцами на руках, тонкими пальцами на ногах, " +
                "острыми зубами и носом, наподобие гоблинского.",
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
