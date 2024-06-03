using ModelsClassLibrary;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class InsuranceController
    {

        private InsuranceService insuranceService;

        public InsuranceController()
        {
            insuranceService = new InsuranceService();
        }

        public int Insert(Insurance insurance)
        {
            Console.WriteLine("\nCamada Controller");
            return insuranceService.Insert(insurance);
        }
    }
}
