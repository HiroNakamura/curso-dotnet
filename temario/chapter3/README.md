# Estructuras de datos en C#

Algunas estructuras de control son:

1. Arreglos.
2. Enumeraciones.
3. Listas.
4. Diccionarios (mapas).
5. Pilas (Stack, etc.).
6. Listas ligadas.


## Ejemplo de Diccionarios

```java
using System.Collections.Generic;
//...

static Dictionary<int, string> GetDiccionario()
{
    Dictionary<int, string> diccionario = new Dictionary<int, string>();
    diccionario.Add(0, "Los dolientes");
    diccionario.Add(1, "En busca de Klingsor");
    diccionario.Add(2, "Cain");
    diccionario.Add(3, "El evangelio segun JesusCristo");
    diccionario.Add(4, "La tabla de Flandes");
    diccionario.Add(5, "Adios a Dylan");
    return diccionario;
}

var myDiccionario = GetDiccionario();
var valores = miDiccionario.Values;
var llaves = miDiccionario.Keys;
Console.WriteLine("Llaves:");
foreach(var llave in llaves)
{
   Console.WriteLine("Llave: {0}",llave);
}
Console.WriteLine("Valores:");
foreach(var valor in valores)
{
   Console.WriteLine("Valor: {0}",valor);
}

```


## Ejemplo de enumeraciones

**Colores.cs**

```java

public enum Colores
{  
  RED, GREEN, BLUE, YELLOW, MAGENTA, BLACK
};

```

**Idiomas.cs**

```java
public enum Idiomas
{
  INGLES,ESPANOL,FRANCES,PORTUGUES,ITALIANO,ALEMAN,RUSO,MANDARIN,JAPONES
}

```

