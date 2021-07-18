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
    public class EFDifferentRepository : IDifferentRepositor
    {
        private readonly AppDbContext context;
        public EFDifferentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Different> GetServiceItems()
        {
            return context.Differents;
        }

        public Different GetServiceItemById(Guid id)
        {
            return context.Differents.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(Different entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.Differents.Remove(new Different() { Id = id });
            context.SaveChanges();
        }
    }
}
