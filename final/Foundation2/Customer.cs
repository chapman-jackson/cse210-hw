public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string returnCustomerInformation()
    {
        return $"Customer: {_name} | Address: {_address.returnCustomerAddress()}";
    }

     public bool isInUnitedStates()
    {
        return _address.isInUnitedStates();
    }
}