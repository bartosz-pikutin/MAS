using System;
using System.Collections.Generic;

namespace MP1
{
    // Klasa Room dziedzicząca po klasie Building
    public class Room : Building
    {
        // Atrybuty
        private string _roomName;
        private int _capacity;

        // Konstruktor
        public Room(string buildingName, int numberOfStory, string roomName, int capacity) : base(buildingName, numberOfStory)
        {
            this._roomName = roomName;
            this._capacity = capacity;
        }

        // Przesłonięcie - metoda ToString() zwraca informacje o pokoju
        public override string ToString()
        {
            return $"Room Name: {_roomName}, Building Name: {_buildingName}, Number of Stories: {_numberOfStory}, Capacity: {_capacity}";
        }

        // Metoda do ustawienia atrybutu złożonego (adres)
        public void SetAddress(Address address)
        {
            base.address = address;
        }

        // Metoda do ustawienia atrybutu klasowego (liczba pracowników)
        public static void SetMaxPeopleInBuilding(int maxPeople)
        {
            maxPeopleInBuilding = maxPeople;
        }
    }
}