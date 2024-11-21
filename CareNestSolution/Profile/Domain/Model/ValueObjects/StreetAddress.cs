namespace CareNestSolution.Profile.Domain.Model.ValueObjects;

public record StreetAddress(string Address, string District)
{
    public StreetAddress(): this(string.Empty, string.Empty){}
    
    public StreetAddress(string address): this(address, string.Empty){}
    
    
    
    public string FullAddress => $"{Address}, {District}";
};