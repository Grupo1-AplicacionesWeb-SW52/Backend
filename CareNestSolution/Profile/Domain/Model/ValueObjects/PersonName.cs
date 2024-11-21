namespace CareNestSolution.Profile.Domain.Model.ValueObjects;

public record PersonName(string FullName)
{
    public PersonName() : this(string.Empty){}
    
    
    public string FirstName => FullName.Split(' ')[0];
    
    
};