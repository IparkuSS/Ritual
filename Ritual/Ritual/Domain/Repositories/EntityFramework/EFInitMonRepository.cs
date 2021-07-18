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
    public class EFInitMonRepository : IInitMonRepositor
    {
        private readonly AppDbContext context;
        public EFInitMonRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<InitMon> GetServiceItems()
        {
            return context.InitMons;
        }

        public InitMon GetServiceItemById(Guid id)
        {
            return context.InitMons.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(InitMon entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.InitMons.Remove(new InitMon() { Id = id });
            context.SaveChanges();
        }
    }
}
