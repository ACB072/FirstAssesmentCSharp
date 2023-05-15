namespace FACSharp.AL;

public abstract class Alimentos
{
    protected string nombre;
    protected double precio;

    public Alimentos(string nombre, double precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }

    public abstract string Descripcion();
}
