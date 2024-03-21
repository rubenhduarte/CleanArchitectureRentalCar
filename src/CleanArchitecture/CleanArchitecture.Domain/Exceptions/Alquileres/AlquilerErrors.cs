using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Exceptions.Alquileres;

public static class AlquilerErrors
{

    public static Error NotFound = new Error(
        "Alquiler.Found",
        "El alquiler con el Id especificado no fue encontrado");

    public static Error OlverLap = new Error(
        "Alquiler.Olverlap",
        "El alquiler esta siendo tomado por 2 o mas clientes al mismo tiempo en la misma fecha."
        );

    public static Error NotReserved = new Error(
        "Alquiler.NotReserved",
        "El alquiler no esta reservado."
        );

    public static Error NotConfirmed = new Error(
        "Alquiler.NotReserved",
        "El alquiler no esta confirmado."
        );

    public static Error AlreadyStarted = new Error(
        "Alquiler.AlreadyStated",
        "El alquiler ya ha comenzado."
        );


}
