// See https://aka.ms/new-console-template for more information
//


using System.Data.SqlClient;
using System.Reflection;
using Test4_Mounika_Department;


DBConnection objDBConnection=new DBConnection();
objDBConnection.Method1();
NewDepartment objNewDepartment = new NewDepartment();
objNewDepartment.AddDepartment();
NewDepartment2 objNewDepartment2 = new NewDepartment2();
objNewDepartment2.Department();
objNewDepartment2.DeleteDepartment();




