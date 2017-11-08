﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProkatAuto22.Classes
{
    class AutomobileClass
    {
        public string ModelCar { get; set; }
        public string ClassCar { get; set; }
        public string TypeCar { get; set; }
        public string PriceHour { get; set; }
        public string PhotoCar { get; set; }
        public string DriverCar { get; set; }
        public string YearIssue { get; set; }
        public string MaxSpeed { get; set; }
        public string CapacityCar { get; set; }
        public string CapacityTrunk { get; set; }

        private DataBaseClass DB;

        public AutomobileClass()
        {
            DB = new DataBaseClass();
        }

        public void InsertCar()
        {
            DB.AddNewCarDB(this);
        }
    }
}
