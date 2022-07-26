// See https://aka.ms/new-console-template for more information


StaffLogic logic = new DoctorLogic();

Doctor d1 = new Doctor()
{
    StaffId = 101,
    StaffName = "Dr. No",
    Email="adsf@gmail.com",
    ContactNo="234345",
    ShiftStartTime=3,
    ShiftEndTime=5,
    Education = "M.B.B.S",
    Specilization = "Eye",
    Fees=340,
    MaxPatientsPerDay=23,
     
};
logic.RegisterStaff(d1);

Doctor d2 = new Doctor()
{
    StaffId = 121,
    StaffName = "Dr. No",
    Email = "adeee@gmail.com",
    ContactNo = "924345",
    ShiftStartTime = 4,
    ShiftEndTime = 8,
    Education = "M.B.B.S",
    Specilization = "Heart",
    Fees = 340,
    MaxPatientsPerDay = 27,

};
logic.RegisterStaff(d2);


logic = new NurseLogic();
Nurse n1 = new Nurse()
{
    StaffId = 152,
    StaffName = "DoLittle",
    Email = "sddddf@gmail.com",
    ContactNo = "924345",
    ShiftStartTime = 3,
    ShiftEndTime = 9,
    AssignRoomNumber=45,
    Experiance = 3,
};

logic.RegisterStaff(n1);

var Staffs = logic.GetStatffs();

//Console.WriteLine();
//Console.WriteLine("Statff are as below");
//Console.WriteLine(JsonSerializer.Serialize(Staffs));
//Console.ReadLine();

char ch = 'y';


void fun_update()
{
    Console.WriteLine("\nTo Update in Doctor       Enter 1 ");
    Console.WriteLine("\nTo Update in Nurse        Enter 2 ");
    Console.WriteLine("\nTo Update in Technician   Enter 3 ");
    int val = Convert.ToInt32(Console.ReadLine());
    if (val == 1)
    { Doctor d1 = DoctorLogic.function_doc(val+10);
        if(d1!=null)
          logic.RegisterStaff(d1);
    }
    else if(val==2)
    {
        Nurse n1 = NurseLogic.function_nur(val+10);
        if(n1!=null)
         logic.RegisterStaff(n1);
    }
    else 
     Console.WriteLine("Wrong INPUT !!\n");
}

void fun_register()
{
    Console.WriteLine("\nTo Register in Doctor       Enter 1 ");
    Console.WriteLine("To Register in Nurse        Enter 2 ");
    Console.WriteLine("To Register in Technician   Enter 3 ");
    int val = Convert.ToInt32(Console.ReadLine());
    if (val == 1)
    {
        Doctor d1 = DoctorLogic.function_doc(val);
        if (d1 != null)
            logic.RegisterStaff(d1);
    }
    else if (val == 2)
    {
        Nurse n1 = NurseLogic.function_nur(val);
        if (n1 != null)
            logic.RegisterStaff(n1);
    }
    else
    {
        Console.WriteLine("Wrong INPUT !!\n");
    }
}

void fun_delete()
{
    Console.Write("Enter ID to Delete : ");
    int val = Convert.ToInt32(Console.ReadLine());

    if(Staff.store.ContainsKey(val))
    {
        Staff.store.Remove(val);
        HospitalDbStore.remove(val);
    }
    else
    {
        Console.WriteLine("\nID NOT FOUND !! \n");
    }
}

Console.WriteLine("\n\t\t\t------------------------------------------------LETS  START  --------------------------------------------\n\n");
do
{
    Console.WriteLine("\n\nRegister New Record  Enter 1 ");
    Console.WriteLine("Update   Record      Enter 2 ");
    Console.WriteLine("Delete   Record      Enter 3 ");
    Console.WriteLine("Search   Record      Enter 4 ");
    Console.Write("\nEnter  : ");
    int val = Convert.ToInt32(Console.ReadLine());
    
    if(val==1)
    {
        fun_register();
    }
    else if(val==2)
    {
        fun_update();
    }
    else if(val==3)
    {
        fun_delete();
    }
    else if(val==4)
    {
        Search s1 = new Search();
        s1.search_op();
    }
} while (ch == 'Y' || ch == 'y');
