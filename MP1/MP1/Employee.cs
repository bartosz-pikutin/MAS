using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace MP1;

class Employee
{
    // Atrybuty
    private string _name { get; set; } 
    private int _age { get; set; }
    private double _salary { get; set; }
    private int _phoneNumber { get; set; }
    private int _birthdayYear { get; set; }

    // Atrybut złożony (adres)
    private Address _address;

    // Atrybut opcjonalny (numer telefonu)
    private Boolean _isManager;

    // Atrybut powtarzalny (umiejętności)
    private List<string> _skills;

    // Atrybut klasowy (czy zna Angielski)
    private static Boolean? _doesSpeakEnglish = true;

    //private static int zarobki = 
    
    //Atrybut pochodny
    private static int Age;
    int todayYear = (int)DateTime.Today.Year;

    // Konstruktor
    public Employee(string name, int age, double salary, int birthdayYear, [Optional] Boolean isManager)
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
        return $"Employee{{name='{_name}', age={_age}, salary={_salary}, address={_address}, isManager='{_isManager}', phoneNumber = '{_phoneNumber}', birthdayYear = '{_birthdayYear}', age = '{_age}', doesSpeakEnglish = '{_doesSpeakEnglish}' skills={string.Join(", ", _skills)}}}";
    }

    // Gettery i settery
    // Pomijam je dla czytelności, można je dodać wedle potrzeb

}