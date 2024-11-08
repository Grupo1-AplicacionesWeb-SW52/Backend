﻿namespace CareNestSolution.Parent.Domain.Model.Commands;

public record CreateParentCommand(
    int Id,
    string Name,
    string Surname,
    string Email,
    string Document,
    string PhoneNumber,
    string Password);
