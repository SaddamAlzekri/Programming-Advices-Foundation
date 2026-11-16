using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllowancesProgram_DataAccess;
using System.Data;

 namespace AllowanesProgram_Business
{
    public class clsAllowances
    {
        public int PerformanceRating { get; set; }
        public decimal Salary { get; set; }
        public float IncrementRating { get; set; }
        public int LowPerformanceRating { get; set; }
        public int HighPerformanceRating { get; set; }

        public clsAllowances()
        {
            PerformanceRating = 0;
            Salary = 0;
            IncrementRating = 0;
            LowPerformanceRating = 0;
            HighPerformanceRating = 0;
        }

        public static DataTable GetAllAllowances()
        {
            return clsAllowancesData.GetAllAllowances();
        }

        public bool UpdateAllowances()
        {
            return clsAllowancesData.UpdateAllowances();
        }

        public bool UpdateAllowancesByProgramming(DataTable _dt)
        {
            return clsAllowancesData.UpdateAllowancesByProgramming(_dt);
        }

    }
}
