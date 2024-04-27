// using System.Globalization;
// using System.Text.Json;
//
// namespace MP1;
//
// public class Employees
// {
//     public List<Employee> _employees;
//
//     public Employees()
//     {
//         _employees = new List<Employee>();
//     }
//     
//     // Dodawanie pracownika do listy
//     public void AddEmployee(Employee employee)
//     {
//         _employees.Add(employee);
//     }
//
//     // Metoda do serializacji wszystkich pracowników do formatu JSON
//     public string SerializeAllToJson()
//     {
//         return JsonSerializer.Serialize(_employees, new JsonSerializerOptions(JsonSerializerDefaults.Web));
//     }
//
//    /* public string DeserializeAllFromJson()
//     {
//         return JsonSerializer.Deserialize(EmployeesData.json)
//     }
// */
//
// }