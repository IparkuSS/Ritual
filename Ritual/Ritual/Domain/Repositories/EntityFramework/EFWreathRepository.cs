using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ritual.Domain.Entities;
using Ritual.Domain.Repositories.Abstract;


namespace Ritual.Domain.Repositories.EntityFramework
{
    public class EFWreathRepository : IWreathRepository
    {
        private readonly AppDbContext context;
        public EFWreathRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Wreath> getWreaths()
        {
            return context.Wreath;
        }

        public Wreath GetWreathsId(Guid id)
        {
            return context.Wreath.FirstOrDefault(x => x.Id == id);
        }

        public void SaveWreath(Wreath entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteWreath(Guid id)
        {
            context.Wreath.Remove(new Wreath() { Id = id });
            context.SaveChanges();
        }
    }

}
