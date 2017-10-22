using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Picker.Demo.ViewModels;

namespace XF.Picker.Demo.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonsPage : ContentPage {

        public PersonsPage() {

            InitializeComponent();
            BindingContext = new AllPersonsViewModel();
        }
    }
}