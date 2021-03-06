using Prova6.Models;
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
    public partial class AddEsercizioPage : ContentPage
    {
        public EsercizioInfo EsercizioInfo { get; set; }
        public AddEsercizioPage()
        {
            InitializeComponent();
            BindingContext = new AddEsercizioViewModel();
        }
    }
}