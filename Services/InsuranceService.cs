

using ModelsClassLibrary;
using Repositories;

namespace Services
{
    public class InsuranceService
    {

        private InsuranceRepository insuranceRepository;

        public InsuranceService()
        {
            insuranceRepository = new InsuranceRepository();
        }

        public int Insert(Insurance insurance)
        {
            Console.WriteLine("Camada Service");
            return insuranceRepository.Insert(insurance);
        }
    }
}
