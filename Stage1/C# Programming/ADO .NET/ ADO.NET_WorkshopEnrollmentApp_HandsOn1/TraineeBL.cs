using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
    public class TraineeBL
    {
        
        
            public bool SaveTraineeDetails(TraineeBO objBO)
            {
                try
                {
                TraineeDA tDA = new TraineeDA();
                bool result = tDA.AddTraineeDetails(objBO);
                if (result)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
    }
    }
}
