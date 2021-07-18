using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ritual.Domain.Entities;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface ICrossRepository
    {
        IQueryable<Cross> GetServiceItems();
        Cross GetServiceItemById(Guid id);
        void SaveServiceItem(Cross entity);
        void DeleteServiceItem(Guid id);
    }
}
