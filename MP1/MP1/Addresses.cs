using System.Globalization;
using System.Text.Json;

namespace MP1;

public class Addresses
{
    public List<Address> _addresses;

    public Addresses()
    {
        _addresses = new List<Address>();
    }
    
    // Dodawanie pracownika do listy
    public void AddAddress(Address address)
    {
        _addresses.Add(address);
    }

    // Metoda do serializacji wszystkich pracowników do formatu JSON
    public string SerializeAllToJson()
    {
        return JsonSerializer.Serialize(_addresses);
    }
    
}