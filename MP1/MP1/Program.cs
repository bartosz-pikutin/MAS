﻿using MP1;


class Program
{
    static void Main(string[] args)
    {
        //Tworzenie obiektów pracowników
        Employee emp1 = new Employee("John Doe",50000, 1980);
        Employee emp2 = new Employee("Jane Smith",45000, 1989, true);
        
        Address address1 = new Address("Korkowa 22", "Warszawa", 00020);
        Address address2 = new Address("Zlota 23", "Sulejowek", 05070);

        Building b = new Building("IIIIII", 76);
        Building i = new Building("Chromowa", 22);
        b.SetAddress(new Address("Krzywa 1112", "Gdynia", 00020));

        Room room1 = new Room("krzywy", 12, "niski", 5);
        Console.WriteLine("\n" + room1);
        
        
        // Dodawanie adresów
        emp1.SetAddress(new Address("123 Main St", "Anytown", 12345));
        emp2.SetAddress(new Address("456 Oak St", "Othertown", 67890));
        
        // Dodawanie numerów telefonów
        emp1.SetPhoneNumber(555234212, 2);
        emp2.SetPhoneNumber(348975293);
        
        // Dodawanie umiejętności
        emp1.AddSkill("Java");
        emp1.AddSkill("Python");
        emp2.AddSkill("C++");
        
        
        
        
        // Dodawanie pracowników do listy
        

        // Serializacja wszystkich pracowników do JSON
        
        Employee.SerializeAllToJson();
        //Employee.DeserializeFromJson();
        //Employee.employeesExtension.ForEach(x=>Console.WriteLine(x.ToString()));
        

        // Wyświetlanie pracowników
        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
        
        Console.WriteLine(Employee.CountEmployees());
        
        Console.WriteLine("\n" + b);
        

        // Wyświetlanie liczby pracowników za pomocą metody klasowej
    }
}
