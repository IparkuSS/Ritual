using Ritual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface IInitMonRepositor
    {
        IQueryable<InitMon> GetServiceItems();
        InitMon GetServiceItemById(Guid id);
        void SaveServiceItem(InitMon entity);
        void DeleteServiceItem(Guid id);
    }
}
