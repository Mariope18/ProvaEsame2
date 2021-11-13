using Prova6.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prova6.Services
{
    public interface IEsercizioRepository
    {
        Task<bool> AddEsercizioAsync(EsercizioInfo esercizioInfo);
        Task<bool> UpdateEsercizioAsync(EsercizioInfo esercizioInfo);
        Task<bool> DeleteEsercizioAsync(int id);
        Task<EsercizioInfo> GetEsercizioAsync(int id);
        Task<IEnumerable<EsercizioInfo>> GetEserciziAsync();
    }
}
