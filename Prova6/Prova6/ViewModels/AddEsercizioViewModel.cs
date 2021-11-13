using MvvmHelpers.Commands;
using Prova6.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prova6.ViewModels
{
    public class AddEsercizioViewModel:BaseEsercizioViewModel
    {
        public AsyncCommand SaveCommand { get; }
        public AsyncCommand CancelCommand { get; }

        public AddEsercizioViewModel()
        {
            SaveCommand = new AsyncCommand(OnSave);
            CancelCommand = new AsyncCommand(OnCancel);


            EsercizioInfo = new EsercizioInfo();
        }

        private async Task OnSave()
        {
            var esercizio = EsercizioInfo;
            await App.EsercizioService.AddEsercizioAsync(esercizio);

            await Shell.Current.GoToAsync("..");
        }
        private async Task OnCancel()
        { 
            await Shell.Current.GoToAsync("..");
        }
    }
}
