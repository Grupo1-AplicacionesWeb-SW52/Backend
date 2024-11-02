namespace CareNestSolution.CareNest.Domain.Model.Queries;

public record GetParentByIdQuery(int Id);
public record GetBarentByEmailQuery(string Email);
public record GetAllParentsQuery();