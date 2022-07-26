using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Assignment_day_21_.Entities;
namespace Assignment_day_21_.Models
{
    public class DoctorLogic : StaffLogic
    {
        public override void RegisterStaff(Staff staff)
        {
            if (HospitalDbStore.GlobalData != null)
            {
                Staff.store.Add(staff.StaffId, "Doctor");
                ArrayList a1 = new ArrayList();
                a1.Add(staff);
                HospitalDbStore.GlobalData.Add(staff.StaffId,a1);
            }
        }
        public override Dictionary<int,ArrayList> GetStatffs()
        {
            return HospitalDbStore.GlobalData;
        }

        public static void display_1(Doctor d1)
        {
            Console.Write($"ID :                {d1.StaffId}\n");
            Console.Write($"Name :              {d1.StaffName}\n");
            Console.Write($"Email :             {d1.Email}\n");
            Console.Write($"ContactNo :         {d1.ContactNo}\n");
            Console.Write($"ShiftStartTime :    {d1.ShiftStartTime} \n");
            Console.Write($"ShiftEndTime :      {d1.ShiftEndTime} \n");
            Console.Write($"Specializaton :     {d1.Specilization} \n");
            Console.Write($"Fees :              {d1.Fees} \n");
            Console.Write($"MaxPatientsPerDay : {d1.MaxPatientsPerDay} \n");
            
        }

          public static  Doctor  function_doc(int val)
          {
            Doctor d3 = new Doctor();
            int id_val = 0;

            Console.WriteLine("Enter ID :");
            id_val = Convert.ToInt32(Console.ReadLine());
            if (val == 1)
            {
                d3.StaffId = id_val;
            }

            if (val > 10)
            {
                if (Staff.store.ContainsKey(id_val))
                {
                    Staff.store.Remove(id_val);
                    HospitalDbStore.GlobalData.Remove(id_val);
                    d3.StaffId = id_val;
                }
                else
                {
                    Console.WriteLine("Wrong ID \n");
                    return null;
                }
            }
            Console.Write("Enter Name :");
            d3.StaffName = Console.ReadLine();
            Console.Write("Enter Email :");
            d3.Email = Console.ReadLine();
            Console.Write("Enter ContactNo :");
            d3.ContactNo = Console.ReadLine();
            Console.Write("Enter ShiftStartTime :");
            d3.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ShiftEndTime :");
            d3.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Specializaton :");
            d3.Specilization = Console.ReadLine();
            Console.Write("Enter Fees :");
            d3.Fees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter MaxPatientsPerDay :");
            d3.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
            
            return d3;
            Console.WriteLine("\n\n SuccessFully Registered !!\n");
        }

       

    }
}
