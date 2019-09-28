# Programación Orientada a Objetos en C#

La POO es un paradigma de programación en la que se trabaja con objetos y clases, además de sus interacciones. 


## Partes fundamentales de la POO

1. Herencia.
2. Polimorfismo.
3. Abstracción.


## Ejemplo de clase


**Modelo.cs**

```java
using System;

class Modelo
    {
        public Modelo()
        {
            Console.WriteLine("Objeto Modelo creado e inicializado");
        }

        public Modelo(string nombre)
        {
            Nombre = nombre;
        }

        ~Modelo(){}

        public string Nombre
        {
            get;set;
        }
    }
```


```java
//Instanciar una clase de manera tradicional
Modelo myModelo = new Modelo();
//Usando var
var otroModelo = new Modelo();
```
