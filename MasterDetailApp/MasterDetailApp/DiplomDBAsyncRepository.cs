using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;


namespace MasterDetailApp
{
    public class DiplomDBAsyncRepository
    {
        SQLiteAsyncConnection database;

        public DiplomDBAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Article>();
        }
        public async Task CreateTableUsers()
        {
            await database.CreateTableAsync<User>();
        }
        public async Task<List<Article>> GetItemsAsync()
        {
            return await database.Table<Article>().ToListAsync();

        }
        public async Task<List<User>> GetItemsAsyncUsers()
        {
            return await database.Table<User>().ToListAsync();

        }
        public async Task<Article> GetItemAsync(int id)
        {
            return await database.GetAsync<Article>(id);
        }
        public async Task<int> DeleteItemAsync(Article item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Article item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }

        public async Task<User> GetItemAsyncUsers(int id)
        {
            return await database.GetAsync<User>(id);
        }
        public async Task<int> DeleteItemAsyncUsers(User item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsyncUsers(User item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        public async Task<List<Results>> GetItemsAsyncResults()
        {
            return await database.Table<Results>().ToListAsync();

        }
        public async Task<Results> GetItemAsyncResults(int id)
        {
            return await database.GetAsync<Results>(id);
        }
        public async Task<int> DeleteItemAsyncResults(Results item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsyncResults(Results item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        public async Task<List<Questions>> GetItemsAsyncQuestions()
        {
            return await database.Table<Questions>().ToListAsync();

        }
        public async Task<List<Answers>> GetItemsAsyncAnswers()
        {
            return await database.Table<Answers>().ToListAsync();

        }

    }
}