﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();

        int Insert(T p);
        int Update(T p);
        int Delete(T p);

        T GetById(int id);

        List<T> List(Expression<Func<T, bool>> where);

        T Find(Expression<Func<T, bool>> where);
    }
}
