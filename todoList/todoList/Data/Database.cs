using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using todoList.views;

namespace todoList.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection database;
        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Person>().Wait();
        }
        public Task<List<Person>> GetPeopleAsync()
        {
            return database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person contact)
        {
            
            return database.InsertAsync(contact);
        }

        // Delete registers
        public Task<int> DeletePersonAsync(Person contact)
        {
            return database.DeleteAsync(contact);
        }

        // update registers
        public Task<int> UpdatePersonAsync(Person contact)
        {
            return database.UpdateAsync(contact);
        }
        public Task<int> findDataToDelete(String firstname)
        {
            var Data = database.QueryAsync<Person>("SELECT Id FROM Person WHERE FirstName = ?",firstname);
           
            return database.DeleteAsync(Data);
        }

    }
}
