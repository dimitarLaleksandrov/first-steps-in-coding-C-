using EFScafolding;
using Microsoft.EntityFrameworkCore;

using (SoftUniContext context = new SoftUniContext())
{
    DateTime oldEmploeeData = new DateTime(2000, 1, 1);
    List<Employee> emploees = await context.Employees
        .Where(e => e.HireDate < oldEmploeeData)
        .ToListAsync();

    foreach (var emploee in emploees)
    {
        Console.WriteLine($"{emploee.FirstName} {emploee.LastName}");
    }

    var richPerson = await context.Employees
         .AsNoTracking()
         .OrderByDescending(e => e.Salary)
         .Select(e => new
         {
             FirstName = e.FirstName,
             LastName = e.LastName,
             Salary = e.Salary
         }).FirstOrDefaultAsync();
    Console.WriteLine($"{richPerson?.FirstName} {richPerson?.LastName} : {richPerson?.Salary}");


    int emploeeCount = await context.Employees.CountAsync();
    int pageLnght = 10;
    int pages = emploeeCount / pageLnght;
    for (int i = 0; i < pages; i++)
    {
        var empoees = await context.Employees
             .AsNoTracking()
             .OrderBy(e => e.FirstName)
             .ThenBy(e => e.LastName)
             .Select(e => new
             {
                 FirstName = e.FirstName,
                 LastName = e.LastName,
                 Salary = e.Salary
             }).Skip(i * pageLnght)
             .Take(pageLnght)
             .ToListAsync();

        foreach (var emploee in empoees)
        {
            Console.WriteLine($"{emploee?.FirstName} {emploee?.LastName} : {emploee?.Salary}");
        }
        Console.ReadLine();
    }


    await context.Projects
         .AddAsync(new Project()
         {
             Name = "Judge",
             StartDate = DateTime.Today
         });
    await context.SaveChangesAsync();
}
