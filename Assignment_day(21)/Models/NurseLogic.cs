using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Assignment_day_21_.Models
{
    public class NurseLogic : StaffLogic
    {
        public override void RegisterStaff(Staff staff)
        {
            if (HospitalDbStore.GlobalData != null)
            {
                Staff.store.Add(staff.StaffId, "Nurse");
                ArrayList a1=new ArrayList();
                a1.Add(staff);
                HospitalDbStore.GlobalData.Add(staff.StaffId,a1);
            }
        }
        public override Dictionary<int,ArrayList> GetStatffs()
        {
            return HospitalDbStore.GlobalData;
        }
         public static void display(Nurse d1)
        {
            Console.Write($"ID :                {d1.StaffId}\n");
            Console.Write($"Name :              {d1.StaffName}\n");
            Console.Write($"Email :             {d1.Email}\n");
            Console.Write($"ContactNo :         {d1.ContactNo}\n");
            Console.Write($"ShiftStartTime :    {d1.ShiftStartTime} \n");
            Console.Write($"ShiftEndTime :      {d1.ShiftEndTime} \n");
            Console.Write($"AssignedRoom :      {d1.AssignRoomNumber}\n");
            Console.Write($"Experiance        : {d1.Experiance} \n");
            Console.Write($"MoniterDetails    : {d1.MoniterDetails}\n");
            

        }
        public static Nurse function_nur(int val)
        {
            Nurse d3 = new Nurse();
            int id_val = 0;

            Console.WriteLine("Enter ID :");
            id_val = Convert.ToInt32(Console.ReadLine());
            if (val == 2)
            {
                d3.StaffId = id_val;
            }
            if (val > 10)
            {
                if (Staff.store.ContainsKey(id_val))
                {
                    Staff.store.Remove(id_val);
                    HospitalDbStore.remove(id_val);
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
            Console.Write("Enter AssignedRoom :");
            d3.AssignRoomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Experience :");
            d3.Experiance = Convert.ToInt32(Console.ReadLine());
            Console.Write("MoniterDetils :");
            d3.MoniterDetails = Console.ReadLine();
          
            return d3;
            Console.WriteLine("\n\n SuccessFully Registered !!\n");
        }

    }
}
