using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day_21_.Models
{
    public class Search
    {

        public bool search_valid(int id)
        {

            bool flag = (Staff.store.ContainsKey(id)) ? true : false;
            return flag;
        }
        public void fun_all()
        {
            foreach (var item in HospitalDbStore.GlobalData.Keys)
            {
                if (Staff.store[item] == "Doctor")
                {
                    var it_1 = (Doctor)HospitalDbStore.GlobalData[item][0];

                    DoctorLogic.display_1(it_1);
                }
                else if (Staff.store[item] == "Nurse")
                {
                    var it_1 = (Nurse)HospitalDbStore.GlobalData[item][0];
                    NurseLogic.display(it_1);
                }


            }
            Console.WriteLine("\n\n");
        }
        public void function_doc(int val_1, string str, int ID_val)
        {
            string str_ALL = String.Empty;
            string str_Edu = String.Empty;
            string str_Sp = String.Empty;
            int count = 0;
            if (ID_val == int.MinValue)
            {
                if (val_1 == 3)
                    str_ALL = "ALL";
                else if (val_1 == 4)
                {
                    Console.Write("Enter Search Eduction : ");
                    str_Edu = Console.ReadLine();
                }
                else if (val_1 == 5)
                {
                    Console.Write("Enter Search Specilization : ");
                    str_Sp = Console.ReadLine();
                }

                foreach (var item in HospitalDbStore.GlobalData.Keys)
                {
                    if (Staff.store[item] == "Doctor" || ID_val != int.MinValue && Staff.store[ID_val] == "Doctor")
                    {
                        var it_1 = (Doctor)HospitalDbStore.GlobalData[item][0];

                        if (it_1.Education == str_Edu || it_1.Specilization == str_Sp || str_ALL == "ALL" || it_1.StaffName == str || it_1.StaffId == ID_val)
                        { DoctorLogic.display_1(it_1); count++;
                            Console.WriteLine("\n\n");
                        }
                    }

                }
                if (str != String.Empty && count == 0)
                {
                    Console.WriteLine($"No Record with {str} in Doctor DATABASE !!\n");
                }
                Console.WriteLine("\n\n");
            }
            else if (ID_val == int.MinValue + 1 && str != String.Empty)
            {
                int count_1 = 0;
                Console.WriteLine($"\nDATABASE With NAME {str}\n");
                foreach (var item in HospitalDbStore.GlobalData.Keys)
                {
                    if (Staff.store[item] == "Doctor")
                    {
                        var it_1 = (Doctor)HospitalDbStore.GlobalData[item][0];
                        if (it_1.StaffName == str)
                        { DoctorLogic.display_1(it_1); count++; }
                    }
                    else if (Staff.store[item] == "Nurse")
                    {
                        var it_1 = (Nurse)HospitalDbStore.GlobalData[item][0];
                        if (it_1.StaffName == str)
                        { NurseLogic.display(it_1); count++; }
                    }
                }

                if (count == 0)
                    Console.WriteLine("\nNO DATA FOUND !!\n");
                Console.WriteLine("\n\n");
            }
            else if (search_valid(ID_val))
            {
                if (Staff.store[ID_val] == "Doctor")
                {
                    var it = (Doctor)HospitalDbStore.GlobalData[ID_val][0];
                    DoctorLogic.display_1(it);
                }
                else if (Staff.store[ID_val] == "Nurse")
                {
                    var it = (Nurse)HospitalDbStore.GlobalData[ID_val][0];
                    NurseLogic.display(it);
                }
                Console.WriteLine("\n\n");
            }

        }
        public   void search_op()
        {
            char ch = 'y';
            do
            {
                Console.WriteLine("\n\nSearch ID                       : Enter  1");
                Console.WriteLine("Search By Name                  : Enter  2");
                Console.WriteLine("Search All Doctor               : Enter  3");
                Console.WriteLine("Search Doctor By Education      : Enter  4");
                Console.WriteLine("Search Doctor by Specialization : Enter  5");
                Console.WriteLine("Show ALL Data                   : Enter  6");
                Console.Write("\n\nEnter  : ");
                var val_1 = Convert.ToInt32(Console.ReadLine());


                if (val_1 <= 0 || val_1 > 6)
                {
                    Console.WriteLine("Wrong Input !!\n");
                }
                else
                {
                    if (val_1 == 1)
                    {
                        Console.WriteLine("Enter Search ID :");
                        var s_ID = Convert.ToInt32(Console.ReadLine());
                        if (search_valid(s_ID))
                        {
                            Console.WriteLine($"ID Belongs to : {Staff.store[s_ID]}\n");
                            function_doc(1, String.Empty, s_ID);
                        }
                        else
                            Console.WriteLine("\nWrong Input !!\n");
                    }
                    else if (val_1 == 3 || val_1 == 4 || val_1 == 5)
                    {
                        string str = String.Empty;
                        function_doc(val_1, str, int.MinValue);
                    }
                    else if (val_1 == 2)
                    {
                        Console.Write("Enter Search Name : ");
                        string str_s = Console.ReadLine();

                        function_doc(val_1, str_s, int.MinValue);
                    }
                    else if (val_1 == 6)
                    {
                        fun_all();
                    }
                }

                Console.WriteLine("\nTo Continue Press Y or y !!\n");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }
    }
}
