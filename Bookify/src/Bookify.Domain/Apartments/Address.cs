namespace Bookify.Domain.Apartments;
// Value Object which represent an address
public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);