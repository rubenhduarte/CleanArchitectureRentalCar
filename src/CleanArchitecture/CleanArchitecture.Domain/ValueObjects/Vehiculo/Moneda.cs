namespace CleanArchitecture.Domain.ValueObjects.Vehiculo;

public record Moneda
    (
    decimal monto,
    TipoMoneda tipoMoneda
    )
{

    public static Moneda operator +(Moneda primerValor, Moneda segundoValor)
    {

        if (primerValor.tipoMoneda != segundoValor.tipoMoneda)
        {
            throw new InvalidOperationException("El tipo de moneda debe ser el mismo");
        }

        return new Moneda(primerValor.monto + segundoValor.monto, primerValor.tipoMoneda);
    }

    public static Moneda Zero() => new(0, TipoMoneda.None);
    public static Moneda Zero(TipoMoneda tipoMoneda) => new(0, tipoMoneda);

    public bool isZero() => this == Zero(tipoMoneda);


}
