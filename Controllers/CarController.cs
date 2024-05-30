
using ModelsClassLibrary;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService carService;

        public CarController()
        {
            carService = new CarService();
        }

        public bool Insert (Car car)
        {
            Console.WriteLine("\nCamada Controller");
            return carService.Insert(car);
        }

        public bool Delete (int id) 
        {
            return carService.Delete(id);
        }

        public Car Get (int id) 
        { 
            return carService.Get(id);
        }

        public bool Update (Car car) 
        { 
            return carService.Update(car);
        }

        public List<Car> GetAll () 
        { 
            return carService.GetAll();
        }


    }
}
