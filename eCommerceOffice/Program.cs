using eCommerceOffice;
using eCommerceOffice.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceOfficeContext();

var res = db.Sectors!.Include(x => x.EmployeesSectors).ThenInclude(x => x.Employee);
foreach(var setor in res)
{
    Console.WriteLine(setor.Name);

    foreach(var emplSec in setor.EmployeesSectors)
    {
        Console.WriteLine(emplSec.Employee.Name);
    }
}
