namespace FACSharp.Sus;
using FACSharp.AL;

public class Sushi : Alimentos
{
    private string tipoSushi;

    public Sushi(string nombre, double precio, string tipoSushi) : base(nombre, precio)
    {
        this.tipoSushi = tipoSushi;
    }

    public override string Descripcion()
    {
        return $"El  {nombre} es de tipo {tipoSushi}. Su precio es {precio}.";
    }
}