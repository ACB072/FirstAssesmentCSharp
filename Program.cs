using static System.Console;
namespace FACSharp;
using FACSharp.AL;
using FACSharp.Pizz;
using FACSharp.Sus;
using FACSharp.Ham;
public class Program{
    public static void Main(string[] args){
        Write("Ingrese el nombre de alimento (Pizza/Hamburguesa/Sushi):");
        string? nombre = ReadLine();
        Write("Ingrese el precio del alimento: ");
        double precio = 0;
        double.TryParse(ReadLine(),out precio);
        Alimentos? alimento = null;
        switch (nombre!)
        {
            case "Pizza":
                Write("Ingrese el ingrediente de la pizza: ");
                string? ingrediente = ReadLine();
                alimento = new Pizza(nombre!, precio, ingrediente!);
                break;
            case "Hamburguesa":
                Write("Ingrese el tipo de carne de la hamburguesa: ");
                string? tipoCarne = ReadLine();
                alimento = new Hamburguesa(nombre!, precio, tipoCarne!);
                break;
            case "Sushi":
                WriteLine("Ingrese el tipo de sushi: ");
                string? tipoSushi = ReadLine();
                alimento = new Sushi(nombre!, precio, tipoSushi!);
                break;
            default:
                WriteLine("Tipo de alimento no válido.");
                break;
        }
        if (alimento!=null)
            WriteLine(alimento.Descripcion());
        WriteLine("Entre cualquier tecla");
        ReadKey();
    }
}
