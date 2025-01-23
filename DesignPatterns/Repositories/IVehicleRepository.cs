using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public interface IVehicleRepository
    {
        ICollection<Vehicle> GetVehicles(); // This method should return a list of vehicles from the database

        void AddVehicle(Vehicle vehicle); // This method should add a vehicle to the database

        Vehicle Find(string id); // This method should return a vehicle from the database

    }
}
