using DataAcessLayer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness_Layer.Concrete
{
    public class RatingManager
    {
        Repository<Rating> repository = new Repository<Rating>();

        public List<Rating> GetRatingByCompany(int id)
        {
            return repository.List().Where(x=>x.CompanyID == id).ToList();
        }
    }
}
