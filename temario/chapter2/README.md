# Estructuras de control en C#


1. Secuenciales o Top-down.
2. Condicionales o Selectivas.
3. Iterativas o Repetitivas.


## Top-down (secuenciales)

De arriba hacia abajo.

```java
Console.WriteLine("Presiona una tecla:");
Console.ReadLine();

int operacion = 34 +41;
var verdadero = 34 > 1000;//false
bool falso = 100 > 99 || 0<2;
char caracter = '\u1109';
bool esDigito = Char.IsDigit(caracter);
```


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
foreach(var numero in numeros)
{
  Console.WriteLine("{0}",numero);
}

int contador = 0;
const int MAX = 100;
while(contador++ < MAX)
{
   Console.WriteLine("{0}",contador);
}

int cont = lista.Count;
while(cont-- > 0)
{
  Console.WriteLine("{0}",lista[cont]);
}

```


