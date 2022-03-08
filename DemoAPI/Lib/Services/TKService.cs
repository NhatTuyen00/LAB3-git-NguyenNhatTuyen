using Lib.Entity;
using Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Services
{
    public class TKservice
    {
        private ITKRepository TKRepository { get; set; }
        private ApplicationDbContext dbContext;

        public TKservice(ApplicationDbContext dbContext, ITKRepository TKRepository)
        {
            this.dbContext = dbContext;
            this.TKRepository = TKRepository;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public List<TK> GetTKList()
        {
            return TKRepository.GetTKList();
        }
        public void InsertTK(TK tk)
        {
            TKRepository.Add(tk);
            Save();
        }
        public void DeleteTK(TK tk)
        {
            TKRepository.Delete(tk);
            Save();
        }
        public void UpdateTK(TK tk)
        {
            TKRepository.Update(tk);
            Save();
        }
    }
}