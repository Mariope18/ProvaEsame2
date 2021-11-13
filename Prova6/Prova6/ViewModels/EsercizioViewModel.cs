using MvvmHelpers.Commands;
using Prova6.Models;
using Prova6.Services;
using Prova6.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prova6.ViewModels
{
    public class EsercizioViewModel : BaseEsercizioViewModel
    {
        public AsyncCommand LoadEsercizioCommand { get; }
        public AsyncCommand AddEsercizioCommand { get; }
        public ObservableCollection<EsercizioInfo> EsercizioInfos {get; }

        public EsercizioViewModel()
        {
            LoadEsercizioCommand = new AsyncCommand(ExecuteLoadProductCommand);
            EsercizioInfos = new ObservableCollection<EsercizioInfo>();
            AddEsercizioCommand = new AsyncCommand(OnAddEsercizio);
        }

        private async Task OnAddEsercizio()
        {
            await Shell.Current.GoToAsync(nameof(AddEsercizioPage));
        }

        //private async void OnAddEsercizio(Object o)
        //{
        //    await Shell.Current.GoToAsync(nameof(AddEsercizioCommand));
        //}

        async Task ExecuteLoadProductCommand()
        {
            IsBusy = true;
            EsercizioInfos.Clear();
            var esercList = await App.EsercizioService.GetEserciziAsync();
            foreach (var eserc in esercList)
            {
                EsercizioInfos.Add(eserc);
            }
            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
