namespace MP1;

public class Building
{
    // Atrybuty
    protected string _buildingName;
    protected int _numberOfStory;

    // Atrybut złożony (adres)
    public Address address;

    // Atrybut klasowy (liczba pracowników)
    protected static int maxPeopleInBuilding = 120;

    // Konstruktor
    public Building(string buildingName, int numberOfStory)
    {
        this._buildingName = buildingName;
        this._numberOfStory = numberOfStory;
    }
}