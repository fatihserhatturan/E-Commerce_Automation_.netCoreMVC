using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness_Layer.Concrete
{
    public class CompanyAboutManager
    {
        ITransportDal transportDal;
        public CompanyAboutManager(ITransportDal transportDal)
        {
            this.transportDal = transportDal;
        }

        Repository<Vehicle> RepositoryVehicle = new Repository<Vehicle>();
        Repository<Driver> RepositoryDriver = new Repository<Driver>();
        Repository<Squad> RepositorySquad = new Repository<Squad>();
        Repository<Company> RepositoryCompany = new Repository<Company>();
       // Repository<Transport> RepositoryTransport = new Repository<Transport>();

        public List<Vehicle> GetVehiclesByCompany(int id)
        {
            return RepositoryVehicle.List().Where(x=>x.CompanyID == id).ToList();
        }

        public int DeleteVehicle(int id)
        {
            Vehicle vehicle = RepositoryVehicle.Find(x=> x.CompanyID == id);
            vehicle.VehicleStatus = false;

            return RepositoryVehicle.Update(vehicle);

        }

        public int AddVehicle(Vehicle vehicle)
        {
            return RepositoryVehicle.Insert(vehicle);
        }
        public List<Driver> GetDriversByCompany(int id)
        {
            return RepositoryDriver.List().Where(x => x.CompanyID == id).ToList();
        }

        public int DeleteDriver(int id)
        {
            Driver driver = RepositoryDriver.Find(x => x.CompanyID == id);
            driver.DriverStatus = false;

            return RepositoryDriver.Update(driver);

        }

        public int AddDriver(Driver Driver)
        {
            return RepositoryDriver.Insert(Driver);
        }

        public List<Squad> GetSquadByCompany(int id)
        {
            return RepositorySquad.List().Where(x=> x.CompanyID == id).ToList();
        }

        public int DeleteSquad(int id)
        {
            Squad squad = RepositorySquad.Find(x => x.CompanyID == id);
            squad.SquadStatus = false;

            return RepositorySquad.Update(squad);

        }

        public int AddSquad(Squad squad)
        {
            return RepositorySquad.Insert(squad);
        }

        public List<Company> GetDataByCompany(int id)
        {
            return RepositoryCompany.List(x=> x.CompanyID == id).ToList();
        }

        public List<Transport> GetDataByTransport(int id)
        {
            return transportDal.GetListWithOtherClass().Where(x=>x.CompanyID==id).ToList();
        }

        public int UpdateCompany(Company company)
        {
            Company c = RepositoryCompany.Find(x=>x.CompanyID==company.CompanyID);
            c.CompanyEmail = company.CompanyEmail;
            c.CompanyName = company.CompanyName;
            c.CompanyID = company.CompanyID;
            c.CompanyImage = company.CompanyImage;
            c.CompanyPassword = company.CompanyPassword;
            c.CompanyDescription = company.CompanyDescription;
            c.CompanyRating = company.CompanyRating;

            return RepositoryCompany.Update(c);


        }

        public Transport GetTransport(int id)
        {
            return transportDal.Find(x=>x.TransportID==id);
        }
    }
}
