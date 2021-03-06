# Tipos de datos en C#


| Tipo C#  | Intervalo  |   Precisión |   Tipo .NET|   Default|
|---|---|---|---|---|
| sbyte  |De -128 a 127   |  Entero de 8 bits con signo |  System.SByte | 0  |
| byte |  De 0 a 255 | Entero de 8 bits sin signo  |  System.Byte | 0  |
| short  | De -32 768 a 32 767  |  Entero de 16 bits con signo	 |  System.Int16 | 0  |
| ushort   | De 0 a 65.535  |  Entero de 16 bits sin signo | System.UInt16  | 0  |
| int  | De -2.147.483.648 a 2.147.483.647  | Entero de 32 bits con signo  |  System.Int32 |  0 |
| uint  | De 0 a 4.294.967.295  | Entero de 32 bits sin signo  |  System.UInt32 | 0  |
| long  |  De -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | Entero de 64 bits con signo  |  System.Int64 | 0  |
| ulong | De 0 a 18.446.744.073.709.551.615  |  Entero de 64 bits sin signo |  System.UInt64 | 0  |
| float  |  De ±1,5 x 10-45 a ±3,4 x 1038 | 7 dígitos  |  System.Single | 0.0f  |
| double | De ±5,0 × 10−324 a ±1,7 × 10308  | 15-16 dígitos  | System.Double  |  0.0d |
| decimal  | De ±1,0 x 10-28 to ±7,9228 x 1028   |  28-29 dígitos significativos |  System.Decimal | 0m  |
| char | U+0000 a U+FFFF  |  Carácter Unicode de 16 bits | System.Char  | \x0000  |
| bool  | Booleano  | true o false  | System.Boolean  |  false |


[Tipos de datos integrados](http://joffremoncayo.com/blog/2018/10/03/tipos-de-datos-integrados-en-csharp/)


|Tipo C# 	|Descripción 	|Tipo .NET|
|---|---|---|
|object |	Es la clase base para todos los demás tipos, incluidos los tipos integrados simples.| 	System.Object|
|string| 	Una secuencia de caracteres Unicode. 	|System.String|
|dynamic |	Es un tipo diseñado para ser usado con assemblies escritos en lenguajes dinámicos| 	No corresponde a un tipo .NET|



## Ejemplos de tipo de datos

```java
bool esVerdadero = 33 > 11;
var entero = System.Int32;
var defecto = default(entero); 
object objeto = null;
long llave = 12000L;
char caracter = '\u99877';
Modelo modelo = new Modelo();
var str = "juan".ToUpper();
object obj = null;

```

## Obtener tipo de dato con GetType

```java
var tipo = System.Single;

 try
 {
    tipo = obj.GetType();
    Console.WriteLine("Tipo = {0}",tipo);
}
catch(Exception ex)
{
    Console.WriteLine("Error = {0}",ex.Message);
}


var numero = 123;
var tipo_ = numero.GetType();
Console.WriteLine("{0}",tipo_);

object[] tipos = {(int) 34, "Programando en C#", true, (long)12000, (sbyte) -3, };
foreach(var tipo in tipos){
  Type t = tipo.GetType();
  
  if (t.Equals(typeof(byte))){
     Console.WriteLine("{0} es de tipo byte",tipo);
  }
  //...
  
}

```

## Uso de typeof

```java

int numero = 33;

if(numero.GetType() == typeof(int)){
   Console.WriteLine("{0} es int", numero);
}

Type t = typeof(obj1);
Console.WriteLine("{0} es de tipo {1}",obj1,t);

```

## Uso de is

```java

var dato = 0;
if("Programando en C#" is string){
    dato = 2;
}

```



## String en C#

```java
var nombre = "Juliana Garcia";
Console.WriteLine("{0}",nombre);
string cadena = new string("Hola, mundo!!");
string str = "\n***Una cadena @@@\t";
string clone_str = str.Clone();
bool contiene = "En un bosque oscuro.".Contains("bosque");

bool bandera = false;
if("doc.xml".EndsWith("xml"))
{
   bandera = true;
}

string salida = "GITHUB".Equals("GITHUB")? "Bienvenido a Github" : "Bienvenido...";
string mayuscula = "andromeda".ToUpper();
string minuscula = "ORION".ToLower();
string inicio = "Gladiola y Florestan".StartsWith("Hortencia");
string espacio = " Mi Kibalstin ".Trim();
```


