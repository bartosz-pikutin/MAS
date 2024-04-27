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
        Employee emp1 = new Employee("John Doe",50000, 1980, true);
        
        
        Employee emp2 = new Employee("Jane Smith",45000, 1989, false);

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
        Employees allEmployees = new Employees();
        Addresses allAddresses = new Addresses();

        allAddresses.AddAddress(emp1.Address);
        allAddresses.AddAddress(emp2.Address);
        allAddresses.AddAddress(address1);
        allAddresses.AddAddress(address2);
        
        // Dodawanie pracowników do listy
        allEmployees.AddEmployee(emp1);
        allEmployees.AddEmployee(emp2);

        // Serializacja wszystkich pracowników do JSON
        string allAdressesJson = allAddresses.SerializeAllToJson();
        string allEmployeesJson = allEmployees.SerializeAllToJson();
        File.WriteAllText("EmployeeData.json", allEmployeesJson);
        File.WriteAllText("AddressData.json", allAdressesJson);
        

        // Wyświetlanie pracowników
        Console.WriteLine(emp1);
        Console.WriteLine(emp2);

        // Wyświetlanie liczby pracowników za pomocą metody klasowej
    }
}
