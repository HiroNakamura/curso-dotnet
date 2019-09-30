# Excepciones en C#

Una **excepción** es una anomalía en el flujo normal de un programa. Un **error** es un fallo irreparable y no existe forma de resolverlo.



## Tabla con algunas excepciones

|Excepción|Descripción|
|---|---|
|System.IO.IOException|Handles I/O errors.|
|System.IndexOutOfRangeException|Handles errors generated when a method refers to an array index out of range.|
|System.ArrayTypeMismatchException|Handles errors generated when type is mismatched with the array type.|
|System.NullReferenceException|Handles errors generated from referencing a null object.|
|System.DivideByZeroException|Handles errors generated from dividing a dividend with zero.|
|System.InvalidCastException|Handles errors generated during typecasting.|
|System.OutOfMemoryException|Handles errors generated from insufficient free memory.|
|System.StackOverflowException|Handles errors generated from stack overflow.|



## Ejemplo de excepciones


Usar el bloque **try-catch**

```java

var dato = null;
object tipo = dato.GetType();

try
{
   Console.WriteLine("Tipo = {0}",tipo);
}
catch(Exception ex)
{
   Console.WriteLine("Error = {0}",ex.Message);
}
```

Usar el bloque **try-finally**

```java
try
{
  Console.WriteLine("Hola");
}
finally
{
  Console.WriteLine("Good bye!!");
}
```

## Extendiendo una Exception

**MyExcepcion.cs**

```java
public class MyExcepcion: Exception
{
   public MyExcepcion(string message): base(message){}

   ~MyExcepcion(){}
}
```

