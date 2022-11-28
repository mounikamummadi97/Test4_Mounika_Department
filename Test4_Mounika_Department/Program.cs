// See https://aka.ms/new-console-template for more information
//


using System.Data.SqlClient;
using System.Reflection;
using Test4_Mounika_Department;
 int item =0;
Console.WriteLine("1.Welcome to Department Database");
Console.WriteLine("2.Insert into Department table ");
Console.WriteLine("3.Update the values of Department table ");
Console.WriteLine("4.Delete the values of Department table");
item = int.Parse(Console.ReadLine());
switch (item)
  { 
       case 1:
        Console.WriteLine("Database connected successfully");
        DBConnection objDBConnection=new DBConnection();
        objDBConnection.Method1();
        break;
        case 2:
            NewDepartment objNewDepartment = new NewDepartment();
            objNewDepartment.AddDepartment();
        break;
        case 3:
        NewDepartment2 objNewDepartment2 = new NewDepartment2();
        objNewDepartment2.UpdateDepartment();
        break;
         case 4:
        NewDepartment2 objNewDepartment3 = new NewDepartment2();
        objNewDepartment3.DeleteDepartment();
         break;
}


