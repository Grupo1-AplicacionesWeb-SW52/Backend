using CareNestSolution.Profile.Domain.Model.ValueObjects;

namespace CareNestSolution.Profile.Domain.Model.Queries;

public record GetProfileByEmailQuery(EmailAddress Email);