using eCommerceOffice;
using eCommerceOffice.Models;
using Microsoft.EntityFrameworkCore;

//Console.WriteLine("HelloWorld");

var db = new eCommerceOfficeContext();

//var res = db.Sectors!.Include(x => x.EmployeesSectors).ThenInclude(x => x.Employee);
//foreach (var setor in res)
//{
//    Console.WriteLine(setor.Name);

//    foreach (var emplSec in setor.EmployeesSectors)
//    {
//        Console.WriteLine("- " + emplSec.Employee.Name);
//    }
//}

var resTeam = db.Employees!.Include(x => x.Teams);
foreach (var colab in resTeam)
{
    Console.WriteLine(colab.Name);

    foreach (var team in colab.Teams)
    {
        Console.WriteLine("- " + team.Name);
    }
}
