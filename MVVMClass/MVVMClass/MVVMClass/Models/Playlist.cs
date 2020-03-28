using MVVMClass.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVMClass.Models
{
    public class Playlist : BaseViewModel
    {
        public string Title { get; set; }
        private bool IsFavorite { get; set; }
    }
}