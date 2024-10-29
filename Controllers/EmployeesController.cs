using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class EmployeeController: ControllerBase{
    private static List<Employeee> employees= new List<Employeee>{
        new Employeee{Id = 1, Name = "Virat", Email = "virat@gmail.com", Dob = new DateOnly(1990, 5, 18), Address = "Abc", PhoneNumber = "9876543210", City = "India" },
        new Employeee{Id = 1, Name = "Anushka", Email = "anushka@gmail.com", Dob = new DateOnly(1993, 5, 10), Address = "Abc", PhoneNumber = "9876543210", City = "India" }
    } ;
    [HttpGet]
    public List<Employeee> Read(){
        return employees;
    }

    [HttpPost]
    public void Create(Employeee employee){
        employees.Add(employee);
    }

    [HttpPut]
    public void Edit(int? id, Employeee employee){
        var emp=employees.Where(p=>p.Id==id).FirstOrDefault();
        emp.Name=employee.Name;
        emp.Email=employee.Email;
        emp.Dob=employee.Dob;
        emp.Address=employee.Address;
        emp.PhoneNumber=employee.PhoneNumber;
        emp.City=employee.City;
    }

    [HttpDelete]
    public void Delete(int? id){
        var emp=employees.Where(p=>p.Id==id).FirstOrDefault();
        employees.Remove(emp);
    }   
}