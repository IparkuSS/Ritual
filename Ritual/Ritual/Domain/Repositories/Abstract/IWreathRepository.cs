﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ritual.Domain.Entities;

namespace Ritual.Domain.Repositories.Abstract
{
    public interface IWreathRepository
    {
        IQueryable<Wreath> getWreaths();
        Wreath GetWreathsId(Guid id);
        void SaveWreath(Wreath entity);
        void DeleteWreath(Guid id);
    }
}
