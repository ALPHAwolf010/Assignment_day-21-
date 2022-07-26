using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_day_21_.Entities;
using Assignment_day_21_.Database;
using System.Collections;
namespace Assignment_day_21_.Models
{
    public abstract class StaffLogic
    {
        public abstract void RegisterStaff(Staff statff);
        public abstract Dictionary<int,ArrayList> GetStatffs();

    }
}
