using Prova6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prova6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedaPage : ContentPage
    {
        EsercizioViewModel esercizioViewModel;
        public SchedaPage()
        {
            InitializeComponent();
            BindingContext = esercizioViewModel = new EsercizioViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            esercizioViewModel.OnAppearing();
        }
    }
}