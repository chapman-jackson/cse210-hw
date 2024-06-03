public class Reception: Event
{
    private string _email;

    public Reception(string email, string title, string description, string date, string time, Address address) : base(title, description, date,time,address)
    {
        _email = email;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

        public string getFullDetailsString()
    {
        return $"Type: Reception : {_title} - {_description} - {_date} - {_time} - {_address.returnCustomerAddress()} - RSVP to: {_email}";
    }
}