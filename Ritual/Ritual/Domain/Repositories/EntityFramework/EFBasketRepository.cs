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
    public class EFBasketRepository : IBasketRepositor
    {
        private readonly AppDbContext context;
        public EFBasketRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Basket> GetServiceItems()
        {
            return context.Baskets;
        }

        public Basket GetServiceItemById(Guid id)
        {
            return context.Baskets.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(Basket entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.Baskets.Remove(new Basket() { Id = id });
            context.SaveChanges();
        }
    }
}
