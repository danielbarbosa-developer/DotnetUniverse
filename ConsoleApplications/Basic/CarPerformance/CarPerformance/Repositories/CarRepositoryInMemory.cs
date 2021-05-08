using System.Collections.Generic;
using CarPerformance.Entities;

namespace CarPerformance.Repositories
{
    public class CarRepositoryInMemory
    {
        private Dictionary<int,Car> _carsInMemory;

        public CarRepositoryInMemory()
        {
            
        }
    }
}