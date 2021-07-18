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
    public class EFMonumentRepository : IMonumentRepository
    {
        private readonly AppDbContext context;
        public EFMonumentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Monument> GetServiceItems()
        {
            return context.Monuments;
        }

        public Monument GetServiceItemById(Guid id)
        {
            return context.Monuments.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(Monument entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.Monuments.Remove(new Monument() { Id = id });
            context.SaveChanges();
        }
    }
}
