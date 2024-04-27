using System;
using System.Collections.Generic;
using MP1;
using System.Text.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektów pracowników
        Employee emp1 = new Employee("John Doe",50000, 1980);
        Employee emp2 = new Employee("Jane Smith",45000, 1989, true);

        Address address1 = new Address("Korkowa 22", "Warszawa", 00020);
        Address address2 = new Address("Zlota 23", "Sulejowek", 05070);
        
        // Dodawanie adresów
        emp1.SetAddress(new Address("123 Main St", "Anytown", 12345));
        emp2.SetAddress(new Address("456 Oak St", "Othertown", 67890));

        // Dodawanie numerów telefonów
        emp1.SetPhoneNumber(555234212);
        emp2.SetPhoneNumber(348975293);

        // Dodawanie umiejętności
        emp1.AddSkill("Java");
        emp1.AddSkill("Python");
        emp2.AddSkill("C++");
        
        
        // Dodawanie pracowników do listy
        

        // Serializacja wszystkich pracowników do JSON
        
        Employee.SerializeAllToJson();
        
        

        // Wyświetlanie pracowników
        Console.WriteLine(emp1);
        Console.WriteLine(emp2);

        // Wyświetlanie liczby pracowników za pomocą metody klasowej
    }
}
