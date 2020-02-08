using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextAct : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Alex", ImageUrl = "http://www.artofmtg.com/wp-content/uploads/2020/01/Cling-to-Dust-Theros-Beyond-Death-Art-100x100.jpg"},
                new Contact { Name = "Pip", ImageUrl = "http://www.artofmtg.com/wp-content/uploads/2020/01/Underworld-Breach-Theros-Beyond-Death-Art-100x100.jpg", Status = "I rock!"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            }

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        public ContextAct()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Alex", ImageUrl = "http://www.artofmtg.com/wp-content/uploads/2020/01/Cling-to-Dust-Theros-Beyond-Death-Art-100x100.jpg"},
                new Contact { Name = "Pip", ImageUrl = "http://www.artofmtg.com/wp-content/uploads/2020/01/Underworld-Breach-Theros-Beyond-Death-Art-100x100.jpg", Status = "I rock!"}
            };

            listView.ItemsSource = _contacts;
        }
    }
}