using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
            {
                "I hate when old people poke you " +
                "at a wedding and say 'you're next'.  " +
                "So next time I was at a funeral I poked them and said 'you're next'.",
                "I think the worst time to have a heart attack is during a game of charades.",
                "Alcohol doesn't solve your problems but neither does milk.",
                "If a book about failures doesn't sell, is it a success?"
            };

        public QuotesPage()
        {
            InitializeComponent();
            currentQuote.Text = _quotes[_index];
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
        }
    }
}