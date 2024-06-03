public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date,time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string getFullDetailsString()
    {
        return $"Type: Lecture : {_title} - {_description} - {_date} - {_time} - {_address.returnCustomerAddress()} Capacity: {_capacity}";
    }
}