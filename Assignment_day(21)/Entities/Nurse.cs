using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment_day_21_.Entities
{
    public class Nurse:Staff
    {
        private int _AssignRoomNumber = 0;
        public int AssignRoomNumber
        {
            get { return _AssignRoomNumber; }
            set
            {
                _AssignRoomNumber = value;

            }
        }
        protected string _MoniterDetails = String.Empty;
        public string MoniterDetails { get { return _MoniterDetails; } set { _MoniterDetails = value; } }
        protected int _Experiance= 0;
        public int Experiance
        {
            get { return _Experiance; }
            set
            {
                int val = value;
                while (val < 0 && val > 30)
                {
                    Console.WriteLine("Wrong Input !!");
                    Console.WriteLine("Enter Experiance");
                    val = Convert.ToInt32(Console.ReadLine());

                    if (val >= 0)
                    {
                        value = val;
                    }
                }
                _Experiance = value;
            }
        }
        
        
    }
}
