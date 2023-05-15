## Escenario de Alimentos: Código 08

Usted ha sido contratado para trabajar como `CSharp developer` en una empresa local de su ciudad.

El negocio central es la comercialización de alimentos:

Usted iniciará un proyecto que incluirá la elaboración de `site` en Internet para la gestión de las alimentos.

Las alimentos que se comercializan son pizzas, hamburguesas y sushis, pero próximamente se añadirán mas variedades a la comercialización según como vayan siendo cerrados acuerdos diferentes chefs.

Debe crear el proyecto de iniciación para comenzar a desarrollar en las siguientes jornadas toda la aplicación.

Hoy deberá entregar la validación de funcionalidad, con la jerarquía de clases, y con el funcionamiento de una aplicación de consola; incluyendo toda la información proporcionada en este documento. Y completarlas según las instrucciones recibidas.

- Jerarquía de clases:

```
Alimentos: pizza, hamburguesa, sushi.
```

``` CSharp




```

####  Aplicación principal

```CSharp
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
```



