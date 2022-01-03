﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<T> GetById(int id);
        Task<IReadOnlyList<T>> GetAll();
    }
}
