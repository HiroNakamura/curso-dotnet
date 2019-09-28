# Estructuras de control en C#


1. Secuenciales.
2. Condicionales.
3. Iterativas.


## Top-down

De arriba hacia abajo.


## Condicionales (if, if-else, if-else if-else)

```java
var verdadero = true;

if(verdadero)
{
   Console.Write("\nHola, amigos");
}


var entrada = 10;

if(entrada <= 9)
{
  Console.WriteLine("A");
}
else if(entrada > 9 && entrada < 99)
{
  Console.WriteLine("B");
}
else
{
  Console.WriteLine("C");
}



```

## Condicionales (switch)

```java
var opcion = 1;

switch(opcion)
{
  case 1: Console.WriteLine("A"); break;
  case 2: Console.WriteLine("B"); break;
  case 3: Console.WriteLine("C"); break;
  default: Console.WriteLine("X"); break;
}

```

## Iterativas (for, foreach, while, do-while)

```java

List<string> nombres = new List<string>();
nombres.Add("Gimena");
nombres.Add("Raul");
nombres.Add("Berenice");
nombres.Add("Tomas");
for(int i=0; i < nombres.Count; i++)
{
  Console.WriteLine("{0}",nombres[i]); 
}


var numeros = new int[]{89,90,102,220,321,500,650,909};
for(var numero in numeros)
{
  Console.WriteLine("{0}",numero);
}

int contador = 0;
const int MAX = 100;
while(contador++ < MAX)
{
   Console.WriteLine("{0}",contador);
}

```


