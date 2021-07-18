using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ritual.Domain.Entities;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface IDifferentRepositor
    {
        IQueryable<Different> GetServiceItems();
        Different GetServiceItemById(Guid id);
        void SaveServiceItem(Different entity);
        void DeleteServiceItem(Guid id);
    }
}
