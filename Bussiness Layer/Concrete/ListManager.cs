using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Bussiness_Layer.Concrete
{
    public class ListManager
    {
        Repository<Company> repoCompany = new Repository<Company> ();

        public List<Company> CompanyList()
        {
            return repoCompany.List();
        }

        public List<Company> GetCompanyByID(int id)
        {
            return repoCompany.List().Where(x=>x.CompanyID == id).ToList();
        }

        
    }
}
