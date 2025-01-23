using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly MemoryCollection _memoryCollection= MemoryCollection.Instance;

        

        public void AddVehicle(Vehicle vehicle) // This method should add a vehicle to the database
        {
            _memoryCollection.Vehicles.Add(vehicle);
        }

        public Vehicle Find(string id) // This method should return a vehicle from the database
        {
           return  _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        public ICollection<Vehicle> GetVehicles() // This method should return a list of vehicles from the database
        {
            return _memoryCollection.Vehicles;
        }

        
    }
}
