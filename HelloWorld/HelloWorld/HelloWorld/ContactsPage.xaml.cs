using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : MasterDetailPage
    {
        void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //For mobile specifically:

            //if (e.SelectedItem == null)
            //{
            //    return;
            //}

            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactsDetails(contact));
            IsPresented = false; //is Master presented?
        }

        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Alex", ImageUrl = "http://www.tiptopglobe.com/forum/images/avatars/gallery/filmy/Batman.jpg"},
                new Contact {Name = "Pip", ImageUrl = "http://www.freeavatarsonline.com/avatars/nature/lightning-strike-100x100.jpg"}
            };
        }
    }
}