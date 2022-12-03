﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //context enttiylerimi tutuyor
        //Dbset araciligiyla atama yapiliyor
        Context c = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = c.Set<T>();
        }
        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();        
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _object.Where(where).ToList();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }
    }
}