using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace MP1;

public class Employee
{

    public static List<Employee> employeesExtension = new List<Employee>();
    // Atrybuty
    public string _name { get; set; } 
    public double _salary { get; set; }
    public int _phoneNumber { get; set; }
    public int _birthdayYear { get; set; }
    
    

    // Atrybut złożony (adres)
    public Address _address;

    // Atrybut opcjonalny (numer telefonu)
    public bool? _isManager;

    // Atrybut powtarzalny (umiejętności)
    private List<string> _skills;

    // Atrybut klasowy (czy zna Angielski)
    public static bool _doesSpeakEnglish = true;

    //private static int zarobki = 
    
    //Atrybut pochodny
    public int _age;
    int todayYear = (int)DateTime.Today.Year;
    
    
  
    public string SerializeJson()
    {
        return JsonSerializer.Serialize(this);
    }
    
    // Konstruktor
    public Employee(string name, double salary, int birthdayYear, [Optional] Boolean isManager)
    {
        this._name = name;
        this._age = todayYear - birthdayYear;
        this._salary = salary;
        this._birthdayYear = birthdayYear;
        this._skills = new List<string>();
        this._isManager = isManager;
        addToExtension(this);
    }
    
    // Metoda do ustawiania adresu pracownika
    public void SetAddress(Address address)
    {
        this._address = address;
    }

    // Metoda do ustawiania numeru telefonu pracownika
    public void SetPhoneNumber(int phoneNumber)
    {
        this._phoneNumber = phoneNumber;
    }
    
    // Metoda do dodawania umiejętności pracownika
    public void AddSkill(string skill)
    {
        this._skills.Add(skill);
    }

    // Przesłonięcie metody ToString() dla wygodnego wyświetlania obiektu
    public override string ToString()
    {
        return $"Employee{{name='{_name}', age={_age}, salary={_salary}, address={_address}, isManager='{_isManager}', phoneNumber = '{_phoneNumber}', birthdayYear = '{_birthdayYear}', doesSpeakEnglish = '{_doesSpeakEnglish}' skills={string.Join(", ", _skills)}}}";
    }

    public static void addToExtension(Employee employee)
    {
        employeesExtension.Add(employee);
    }

    public static void SerializeAllToJson()
     {
         string dataForJson = JsonConvert.SerializeObject(employeesExtension);
         File.WriteAllText("EmployeeData.json", dataForJson);
     }
   

    // Gettery i settery
    // Pomijam je dla czytelności, można je dodać wedle potrzeb

}