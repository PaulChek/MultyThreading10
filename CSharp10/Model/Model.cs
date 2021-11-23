namespace CSharp10.Model;


#region UserModel
public record User {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? username { get; set; }
    public string? Email { get; set; }
    public Address? Address { get; set; }
    public string? Phone { get; set; }
    public string? website { get; set; }
    public Company? Company { get; set; }
    override public string ToString() => $"Name: {Name} \nNick: {username} \nEmail: {Email}";
    internal void Deconstruct(out string? name, out string? phone) {
        name = username;
        phone = Phone;
    }
}
public class Address {
    public string? Street { get; set; }
    public string? Suite { get; set; }
    public string? City { get; set; }
    public string? Zipcode { get; set; }
    public Geo? Geo { get; set; }
}

public class Geo {
    public string? Lat { get; set; }
    public string? Lng { get; set; }
}

public class Company {
    public string? Name { get; set; }
    public string? CatchPhrase { get; set; }
    public string? Bs { get; set; }
}
#endregion

