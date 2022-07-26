using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_21_.Entities
{
    public class Staff
    {

        
        public static Dictionary<int, string> store = new Dictionary<int, string>();
        protected int _StaffId = 0;
        public int StaffId
        {
            get
            {
                return _StaffId;
            }
            set
            {
                while (value <= 0 || store.ContainsKey(value))
                {
                    if (store.ContainsKey(value))
                        Console.WriteLine("ID Already Present !!\n");
                    Console.WriteLine("Enter ID :");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                
                _StaffId = value;
            }
        }
        protected string _StaffName = String.Empty;
        public string StaffName
        {
            get { return _StaffName; }
            set
            {
                bool flag = true;
                int count = 0;
                while (flag)
                {
                    count = 0;
                    string str_sp = "\"@|!#$%&*/()=?»«@£§€{}-;~`'<>_,";
                    foreach (char c in value)
                    {
                        if (str_sp.Contains(c))
                        {
                            count = 1;
                            break;
                        }

                    }

                    if (count>= 1)
                    {
                        Console.WriteLine("Wrong Input !! Try Again .. \n");

                        Console.Write("\nEnter Name : ");

                         value=   Console.ReadLine();
                        

                    }
                    else
                    {
                        _StaffName = value;
                        flag = false;
                    }


                }

            }
        }
        protected string _Email = String.Empty;
        public string Email
        {
            get { return _Email; }
            set
            {
                bool flag = true;

                string str = String.Empty;
                if (value.Length > 12)
                    str = value.Substring(value.Length - 10);

                if (value == String.Empty && str.Length < 13 || str.Contains("@gmail.com") == false)
                    while (flag)
                    {

                        Console.WriteLine("Wrong Input Enter Again..\n");
                        Console.Write("\nEnter  Email ID :");

                        string val = Console.ReadLine();

                        string val_1 = String.Empty;
                        if (val.Length > 12)
                            val_1 = val.Substring(val.Length - 10);

                        if (val.Length > 12 && val_1.Contains("@gmail.com") == true)
                        {
                            _Email = val;
                            flag = false;
                        }

                    }
                else
                    _Email = value;
            }
        }

        protected string _ContactNo = String.Empty;
        public string ContactNo
        {
            get { return _ContactNo; }
            set
            {
                _ContactNo = value;
            }
        }
        protected int _ShiftStartTime = 0;

        public int ShiftStartTime
        {

            get
            {

                return _ShiftStartTime;
            }
            set
            {
                _ShiftStartTime = value;
            }
        }
        protected int _ShiftEndTime = 0;
        public int ShiftEndTime
        {
            get
            {
                return _ShiftEndTime;
            }
            set
            {
                _ShiftEndTime = value;
            }
        }
        
    }

   
}
