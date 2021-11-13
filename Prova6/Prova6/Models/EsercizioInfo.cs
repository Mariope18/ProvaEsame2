using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova6.Models
{
    public class EsercizioInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
