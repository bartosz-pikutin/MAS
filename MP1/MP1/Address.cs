namespace MP1;

public class Address
{
    private string street;
    private string city;
    private int zipCode;

    // Konstruktor
    public Address(string street, string city, int zipCode)
    {
        this.street = street;
        this.city = city;
        this.zipCode = zipCode;
    }

    // Przesłonięcie metody ToString()
    public override string ToString()
    {
        return $"Address{{street='{street}', city='{city}', zipCode='{zipCode}'}}";
    }
}
