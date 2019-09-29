# Abstracción y polimorfismo en C#

La abstracción es,básicamente, trabajar con interfaces. El polimorfismo es una característica que permite definir métodos con el mismo nombre, pero tipos y parámetros diferentes.


**IOperacion.cs**

```java

public interface IOperacion
{
    void metodo(string cad);
    void metodo(char c, string cad);
    int metodo(bool verdadero, char c);
    long metodo(byte b);
    void metodo();
}

public class OperacionImpl: IOperacion
{
    public void metodo(string cad)
    {
        //hacer algo
    }
    
    public void metodo(char c, string cad)
    {
        //hacer algo
    }
    
    public int metodo(bool verdadero, char c)
    {
        return 32;
    }
    
    public long metodo(byte b)
    {
        return 1200L;
    }
    
    public void metodo()
    {
        //hacer algo
    }
} 

```
