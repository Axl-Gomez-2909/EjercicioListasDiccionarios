// Crear la lista de productos
List<string> tecnologiaeinformatica = new List<string>
        {
            "Laptop",
            "Smartphone",
            "Impresora multifunción",
            "Reloj inteligente",
            "Cámara digital",
            "Auriculares inalámbricos",
            "Altavoces Bluetooth",
            "Disco duro externo",
            "Monitor de computadora",
            "Teclado mecánico"
        };

// Insertar un nuevo producto en el índice 3
tecnologiaeinformatica.Insert(3, "Router inalámbrico ");

// Remover el último elemento de la lista
tecnologiaeinformatica.RemoveAt(tecnologiaeinformatica.Count - 1);

// Mostrar la lista en la consola
Console.WriteLine("Lista de productos:");
foreach (var producto in tecnologiaeinformatica)
{
    Console.WriteLine(producto);
}

Console.WriteLine("");

// Crear un diccionario con datos de departamentos 
Dictionary<string, string> departamento1 = new Dictionary<string, string>
        {
            { "nombre", "Cortés" },
            { "cabecera", "San Pedro Sula" },
            { "superficie", "3,954 km²" },
            { "poblacion", "1,759,607" }
        };

Dictionary<string, string> departamento2 = new Dictionary<string, string>
        {
            { "nombre", "Francisco Morazán" },
            { "cabecera", "Tegucigalpa" },
            { "superficie", "8,459 km²" },
            { "poblacion", "1,630,537" }
        };

// Crear un diccionario que contenga los dos departamentos
Dictionary<string, Dictionary<string, string>> diccionarioDepartamentos = new Dictionary<string, Dictionary<string, string>>
        {
            { "Cortés", departamento1 },
            { "Francisco Morazán", departamento2 }
        };


// Mostrar el diccionario en la consola con su respectiva llave y valor
foreach (var departamento in diccionarioDepartamentos)
{
    Console.WriteLine($"Datos del departamento de {departamento.Key}:");
    foreach (var dato in departamento.Value)
    {
        Console.WriteLine($"{dato.Key}: {dato.Value}");
    }
    Console.WriteLine();
}