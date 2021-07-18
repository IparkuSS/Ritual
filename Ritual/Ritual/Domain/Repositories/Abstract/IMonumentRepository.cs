using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ritual.Domain.Entities;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface IMonumentRepository
    {
        IQueryable<Monument> GetServiceItems();
        Monument GetServiceItemById(Guid id);
        void SaveServiceItem(Monument entity);
        void DeleteServiceItem(Guid id);
    }
}
