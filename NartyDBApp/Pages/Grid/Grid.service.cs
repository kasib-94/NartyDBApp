using DB.DbConext;
using DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Narty.Service.Grid
{
    public class GridService
    {
        private readonly AppDbContext _appDbContext;

        public GridService(AppDbContext DbContext)
        {
            _appDbContext = DbContext;
        }

        public void SaveItem(Item przedmiot)
        {
            var item = _appDbContext.BasicItems.FirstOrDefault(x => x.ID == przedmiot.ID);

            if (item != null)
            {
                item = przedmiot;
            }
            else
            {
                _appDbContext.BasicItems.Add(przedmiot);
            }
            _appDbContext.SaveChanges();
        }
        public async Task DeleteItemAsync(int itemId)
        {
            var itemToDelete = await _appDbContext.BasicItems.FindAsync(itemId);
            if (itemToDelete != null)
            {
                _appDbContext.BasicItems.Remove(itemToDelete);
                await _appDbContext.SaveChangesAsync();
            }
        }
        //
        public List<Item> GetItems()
        {
            return _appDbContext.BasicItems.ToList();
        }

    }
}
