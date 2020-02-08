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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("A", "A")
                {
                     new Contact { Name = "Alex", ImageUrl = "http://www.artofmtg.com/wp-content/uploads/2020/01/Cling-to-Dust-Theros-Beyond-Death-Art-100x100.jpg"},
                },

               new ContactGroup("P", "P")
               {
                   new Contact { Name = "Pip", ImageUrl = "http://www.artofmtg.com/wp-content/uploads/2020/01/Underworld-Breach-Theros-Beyond-Death-Art-100x100.jpg", Status = "I rock!"}
               }               
            };
        }
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");

            //listView.SelectedItem = null;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }       
    }
}