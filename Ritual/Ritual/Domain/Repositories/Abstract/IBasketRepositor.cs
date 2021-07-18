using Ritual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface IBasketRepositor
    {

        IQueryable<Basket> GetServiceItems();
        Basket GetServiceItemById(Guid id);
        void SaveServiceItem(Basket entity);
        void DeleteServiceItem(Guid id);

    }
}
