namespace CareNestSolution.CareNest.Domain.Model.Queries;

public record GetCaregiverByIdQuery(int Id);

public record GetCaregiversByLocationQuery(string Location);

public record GetAllCaregiversQuery();