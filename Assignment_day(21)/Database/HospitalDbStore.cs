using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_day_21_.Entities;
using System.Collections;
namespace Assignment_day_21_.Database
{
    public class HospitalDbStore
    {
        /// <summary>
        /// Global Store
        /// </summary>
         public static Dictionary<int, ArrayList>? GlobalData { get; set;}=new Dictionary<int, ArrayList>();


        public static void remove(int val_ID)
        {
            if (GlobalData.ContainsKey(val_ID))
            {
               GlobalData.Remove(val_ID);
            }
            else
            {
                Console.WriteLine("WRONG ID \n");
            }
        }
        //public static ArrayList ? GlobalStaffStore { get; set; } = new ArrayList();

    }
}