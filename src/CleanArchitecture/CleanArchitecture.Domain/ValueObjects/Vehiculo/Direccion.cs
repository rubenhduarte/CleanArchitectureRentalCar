﻿namespace CleanArchitecture.Domain.ValueObjects.Vehiculo;

public record Direccion
(
    string Pais,
    string Departamento,
    string Provincia,
    string Ciudad,
    string Calle
);
