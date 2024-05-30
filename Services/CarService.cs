using ModelsClassLibrary;
using Repositories;
using System.Diagnostics.CodeAnalysis;

namespace Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService()
        {
            carRepository = new CarRepository(); 
        }

        public bool Insert (Car car)
        {
            Console.WriteLine("Camada Service");
            return carRepository.Insert(car);
        }

        public bool Update (Car car) 
        { 
            return carRepository.Update(car);
        }

        public Car Get (int id) 
        {
            return carRepository.Get(id);

        }

        public bool Delete (int id) 
        { 
            return carRepository.Delete(id);
        }

        public List<Car> GetAll() 
        { 
            return carRepository.GetAll();
        }


    }
}
