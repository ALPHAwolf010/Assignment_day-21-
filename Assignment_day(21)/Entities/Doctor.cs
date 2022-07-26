using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_21_.Entities
{
    public class Doctor : Staff
    {
        protected string _Specilization =String.Empty;
        
        public string Specilization
        {
            get { return _Specilization; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    string[] arr = { "Cancer", "Heart", "Pathology", "Radiology", "Orthopeic", "Eye", "Dental" };
                    foreach (string var in arr)
                    {
                        if (var == value)
                        {
                            flag = false;
                            _Specilization = value;
                            break;
                        }
                    }

                    if (flag == true)
                    {
                        Console.WriteLine("Wrong Input Enter Again ..\n");
                        Console.Write("\nEnter Specialization : ");
                        string var1 = Console.ReadLine();

                        value = var1;
                    }

                }
            }
        }
        protected int _Fees = 0;
        public int Fees { get { return _Fees; } set { _Fees = value; } }
        protected int _MaxPatientsPerDay = 0;
        public int MaxPatientsPerDay { get { return _MaxPatientsPerDay; } set { while (value <= 0) 
                {
                    Console.WriteLine("Wrong Input !!");
                    Console.WriteLine("Enter MaxPatrientPerDay :");
                    value=Convert.ToInt32(Console.ReadLine());  
                } _MaxPatientsPerDay = value; } }

        protected string _Education=String.Empty;
        public string Education { get {return _Education; } set { _Education = value; } }
    }
}
