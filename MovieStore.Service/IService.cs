﻿using MovieStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Service
{
    public interface IService<T> where T : IEntity
    {
        List<T> List();
        T Add(T obj);
        bool Update(T obj);
        T Get(int id);
    }
}
