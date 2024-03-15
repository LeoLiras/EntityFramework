using eCommerceOffice;
using eCommerceOffice.Models;
using Microsoft.EntityFrameworkCore;

//Console.WriteLine("HelloWorld");

var db = new eCommerceOfficeContext();

#region Many-To-Many for EF Core <= 3.1
//var res = db.Sectors!.Include(x => x.EmployeesSectors).ThenInclude(x => x.Employee);
//foreach (var setor in res)
//{
//    Console.WriteLine(setor.Name);

//    foreach (var emplSec in setor.EmployeesSectors)
//    {
//        Console.WriteLine("- " + emplSec.Employee.Name);
//    }
//}
#endregion

#region Many-To-Many for EF Core 5+
//var resTeam = db.Employees!.Include(x => x.Teams);
//foreach (var colab in resTeam)
//{
//    Console.WriteLine(colab.Name);

//    foreach (var team in colab.Teams)
//    {
//        Console.WriteLine("- " + team.Name);
//    }
//}
#endregion

#region Many-To-Many + Playload for EF Core 5+
var emplVehicle = db.Employees!.Include(x => x.EmployeesVehicles)!.ThenInclude(x => x.Vehicle);
foreach(var empl in emplVehicle)
{
    Console.WriteLine(empl.Name);
    foreach(var bond in empl.EmployeesVehicles!)
    {
        Console.WriteLine($"- {bond.Vehicle!.Name} ({bond.Vehicle.Identification}): {bond.InitialBondDate}");
    }
}
#endregion

