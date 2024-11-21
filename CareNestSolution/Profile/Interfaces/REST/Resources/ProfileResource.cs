﻿namespace CareNestSolution.Profile.Interfaces.REST.Resources;

public record ProfileResource(
    int Id,
    string FullName,
    string Email,
    string StreetAddress);