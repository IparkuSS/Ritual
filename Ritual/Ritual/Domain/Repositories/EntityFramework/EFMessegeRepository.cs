using Microsoft.EntityFrameworkCore;
using Ritual.Domain.Entities;
using Ritual.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Repositories.EntityFramework
{
    public class EFMessegeRepository : IMessegeRepositor
    {
        private readonly AppDbContext context;
        public EFMessegeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Messege> GetServiceItems()
        {
            return context.Messege;
        }

        public Messege GetServiceItemById(Guid id)
        {
            return context.Messege.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(Messege entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.Messege.Remove(new Messege() { Id = id });
            context.SaveChanges();
        }

        public void DeleteAllItems()
        {

            context.Messege.RemoveRange(context.Messege);
            context.SaveChanges();
        }
    }
}
