using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness_Layer.Concrete
{
    public  class SquadManager
    {

        Repository<Squad> Repository = new Repository<Squad>();

        public List<Squad> GetSquadByCompany(int id)
        {
            return Repository.List().Where(x => x.CompanyID == id).ToList();
        }
    }
}
