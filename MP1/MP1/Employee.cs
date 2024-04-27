using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MP1;

public class Employee 
{
    // Atrybuty
    private string _name { get; set; } 
    private double _salary { get; set; }
    private int _phoneNumber { get; set; }
    private int _birthdayYear { get; set; }
    

    // Atrybut złożony (adres)
    private Address _address;

    // Atrybut opcjonalny (numer telefonu)
    private bool? _isManager;

    // Atrybut powtarzalny (umiejętności)
    private List<string> _skills;

    // Atrybut klasowy (czy zna Angielski)
    private static bool _doesSpeakEnglish = true;

    //private static int zarobki = 
    
    //Atrybut pochodny
    private int _age;
    int todayYear = (int)DateTime.Today.Year;

    public string Name { get { return _name; } set { _name = value; } }
    public int Age { get { return _age; } set { _age = value; } }
    public double Salary { get { return _salary; } set { _salary = value; } }
    public Address Address { get { return _address; } set { _address = value; } }
    public bool IsManager { get { return (bool)_isManager; } set { _isManager = value; } }
    public int YearOfBirth { get { return _birthdayYear; } set { _birthdayYear = value; } }
    public int PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
    public int BirthdayYear { get { return _birthdayYear; } set { _birthdayYear = value; } }
    public bool DoesSpeakEnglish { get { return _doesSpeakEnglish; } set { _doesSpeakEnglish = value; } }
    public List<string> Skills { get { return _skills; } set { _skills = value; } }

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

    // Metoda pochodna (zwiększająca pensję)
    public void IncreaseSalary(double percentage)
    {
        this._salary *= (1 + percentage / 100);
    }

    // Przesłonięcie metody ToString() dla wygodnego wyświetlania obiektu
    public override string ToString()
    {
        return $"Employee{{name='{_name}', age={_age}, salary={_salary}, address={_address}, isManager='{_isManager}', phoneNumber = '{_phoneNumber}', birthdayYear = '{_birthdayYear}', doesSpeakEnglish = '{_doesSpeakEnglish}' skills={string.Join(", ", _skills)}}}";
    }
    


   

    // Gettery i settery
    // Pomijam je dla czytelności, można je dodać wedle potrzeb

}