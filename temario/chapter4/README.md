# Programación Orientada a Objetos en C#

La POO es un paradigma de programación en la que se trabaja con objetos y clases, además de sus interacciones. 


## Partes fundamentales de la POO

1. Encapsulación.
2. Herencia.
3. Polimorfismo.
4. Abstracción.


|Concepto|Definición|
|---|---|
|Encapsulación|Proteger los datos. Variables de instancia privados y métodos de acceso públicos|
|Herencia|Extender una clase base, definir una clase de una ya existente|
|Polimorfismo|Diferentes objetos responden de manera diferente al mismo mensaje|
|Abstracción|Trabajar con interfaces|



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

**Ejemplo de instanciación**

```java
//Instanciar una clase de manera tradicional
Modelo myModelo = new Modelo();
//Usando var
var otroModelo = new Modelo();
```

**Ejemplo de herencia**

```java
class Modelo
{

}

class SuperModelo: Modelo
{

}

```

**Ejemplo de uso (implementación) de interfaces**

```java
interface IServicio
{
   void Saludar();
}

class ServicioImpl: IServicio
{
   public void Saludar()
   {
      //...
   }
}


```





