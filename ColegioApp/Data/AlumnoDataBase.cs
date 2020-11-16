using ColegioApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColegioApp.Data
{
    public class AlumnoDataBase
    {
        private readonly SQLiteAsyncConnection database;

        public AlumnoDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Alumno>().Wait();
        }

        public async Task<List<Alumno>> GetAlumnosAsync()
        {
            return await database.Table<Alumno>().ToListAsync();
        }

        public Task<int> SaveAlumnoAsync(Alumno alumno)
        {
            if(alumno.ID != 0)
            {
                return  database.UpdateAsync(alumno);
            }
            else
            {
                return  database.InsertAsync(alumno);
            }
        }

        public Task<int> DeleteAlumnoAsync(Alumno alumno)
        {
            return database.DeleteAsync(alumno);
        }

    }
}
