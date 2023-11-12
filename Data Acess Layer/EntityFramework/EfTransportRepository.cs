using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAcessLayer.EntityFramework
{
    public class EfTransportRepository : Repository<Transport>, ITransportDal
    {
        public List<Transport> GetListWithOtherClass()
        {
            using(var c = new Context())
            {
                return c.Transports
                    .Include(x => x.User)
                    .Include(x => x.Company)
                    .Include(x => x.Driver)
                    .Include(x => x.Squad)
                    .Include(x => x.Vehicle)
                    .ToList();

            }
        }
    }
}
