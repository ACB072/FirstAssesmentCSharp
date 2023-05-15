namespace FACSharp.Ham;
using FACSharp.AL;

public class Hamburguesa : Alimentos
{
    private string tipoCarne;

    public Hamburguesa(string nombre, double precio, string tipoCarne) : base(nombre, precio)
    {
        this.tipoCarne = tipoCarne;
    }

    public override string Descripcion()
    {
        return $"La {nombre} está hecha con carne de {tipoCarne}. Su precio es {precio}.";
    }
}
