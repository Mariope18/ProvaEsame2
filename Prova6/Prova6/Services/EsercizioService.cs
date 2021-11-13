using Prova6.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prova6.Services
{
    public class EsercizioService : IEsercizioRepository
    {
        public SQLiteAsyncConnection _database;
        public EsercizioService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<EsercizioInfo>().Wait();
        }
        public async Task<bool> AddEsercizioAsync(EsercizioInfo esercizioInfo)
        {
            if(esercizioInfo.Id > 0)
            {
                await _database.UpdateAsync(esercizioInfo);
            }
            else
            {
                await _database.InsertAsync(esercizioInfo);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteEsercizioAsync(int id)
        {
            await _database.DeleteAsync<EsercizioInfo>(id);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<EsercizioInfo>> GetEserciziAsync()
        {
            return await Task.FromResult(await _database.Table<EsercizioInfo>().ToListAsync());
        }

        public async Task<EsercizioInfo> GetEsercizioAsync(int id)
        {
            return await _database.Table<EsercizioInfo>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public Task<bool> UpdateEsercizioAsync(EsercizioInfo esercizioInfo)
        {
            throw new NotImplementedException();
        }
    }
}
