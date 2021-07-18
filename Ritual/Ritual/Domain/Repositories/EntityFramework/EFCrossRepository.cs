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
    public class EFCrossRepository : ICrossRepository
    {
        private readonly AppDbContext context;
        public EFCrossRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Cross> GetServiceItems()
        {
            return context.Croses;
        }

        public Cross GetServiceItemById(Guid id)
        {
            return context.Croses.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(Cross entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.Croses.Remove(new Cross() { Id = id });
            context.SaveChanges();
        }
    }
}
