using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen3PK.Models;
using System.Threading.Tasks;

namespace Examen3PK.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<CPagos>().Wait();
        }
        public Task<int> SavePersona(CPagos person)
        {
            if (person.Idpago != 0)
            {
                return db.UpdateAsync(person);
                ;
            }
            else
            {
                return db.InsertAsync(person);
            }
        }
        public Task<List<CPagos>> GetPersonasAync()
        {
            return db.Table<CPagos>().ToListAsync();
        }
        public Task<int> Grabarpersona(CPagos person)
        {
            if (person.Idpago != 0)
            {
                return db.UpdateAsync(person);
            }
            else
            {
                return db.InsertAsync(person);
            }
        }
        public Task<int> DropPersonaAsync(CPagos person)
        {
            return db.DeleteAsync(person);
        }


    }
}
