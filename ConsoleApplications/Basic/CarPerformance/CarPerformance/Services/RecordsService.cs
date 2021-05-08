using CarPerformance.Entities;
using CarPerformance.Repositories;

namespace CarPerformance.Services
{
    
    public class RecordsService
    {
        private readonly CarRepositoryInMemory _repository;
        public RecordsService()
        {
            this._repository = new CarRepositoryInMemory();
        }
        public Car GetCarById(int id)
        {
            Car car = _repository.GetCarById(id);
            return car;
        }

        public void InsertNewCar(Car car)
        {
            _repository.InsertCar(car);
        }
    }
}