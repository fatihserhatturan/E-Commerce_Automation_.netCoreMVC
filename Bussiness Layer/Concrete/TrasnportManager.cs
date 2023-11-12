using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness_Layer.Concrete
{
    public class TrasnportManager
    {

        ITransportDal transportDal;
        public TrasnportManager(ITransportDal transportDal)
        {
            this.transportDal = transportDal;
        }

        public int TransportAdd(Transport transport)
        {
            return transportDal.Insert(transport);
        }

        public List<Transport> GetTransportByUser(int id)
        {
            return transportDal.GetListWithOtherClass().Where(x=>x.UserID == id).ToList();
        }

        public List<Transport> GetTrasnportByNotApproved(int id)
        {
            return transportDal.GetListWithOtherClass().Where(x=>x.TransportStatus == false && x.CompanyID == id).ToList();
        }
    }
}
