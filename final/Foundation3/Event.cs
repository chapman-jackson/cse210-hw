public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _time = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string getStandardDetailsString()
    {
        return $"{_title}: {_description} - {_date} - @ {_time} - {_address.returnCustomerAddress()}";
    }

    public string getShortDescriptionString()
    {
        return $"{_title} - {_description} - {_date}";
    }
}