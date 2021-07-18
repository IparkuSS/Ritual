using Ritual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface IMessegeRepositor
    {
        IQueryable<Messege> GetServiceItems();
        Messege GetServiceItemById(Guid id);
        void SaveServiceItem(Messege entity);
        void DeleteServiceItem(Guid id);
        void DeleteAllItems();
    }
}
