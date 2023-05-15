namespace FACSharp.Pizz;
using FACSharp.AL;

public class Pizza : Alimentos
{
    private string ingrediente;

    public Pizza(string nombre, double precio, string ingrediente) : base(nombre, precio)
    {
        this.ingrediente = ingrediente;
    }

    public override string Descripcion()
    {
        return $"La {nombre} tiene el ingrediente: {ingrediente}. Su precio es {precio}.";
    }
}