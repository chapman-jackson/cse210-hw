public class Outdoor : Event
{
    private string _weather;

    public Outdoor( string weather,string title, string description, string date, string time, Address address) : base(title, description, date,time,address)
    {
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

        public string getFullDetailsString()
    {
        return $"Type: Outdoors : {_title} - {_description} - {_date} - {_time} - {_address.returnCustomerAddress()} - {_weather}";
    }
}