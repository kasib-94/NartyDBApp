using DB.DbConext;
using DB.Models;
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

        public void CreateItem(Item przedmiot)
        {
            _appDbContext.BasicItems.Add(przedmiot);
            _appDbContext.SaveChanges();

        }


    }
}
