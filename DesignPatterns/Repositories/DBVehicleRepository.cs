﻿using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class DBVehicleRepository : IVehicleRepository
    {
        public void AddVehicle(Vehicle vehicle) 
        {
            throw new NotImplementedException();
        }

        public Vehicle Find(string id) 
        {
            throw new NotImplementedException();
        }

        public ICollection<Vehicle> GetVehicles() // This method should return a list of vehicles from the database
        {
            throw new NotImplementedException();
        }
    }
}
