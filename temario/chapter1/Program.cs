using System;
using System.IO;

namespace chapter1
{
    class Program
    {
        public static readonly int MAX = 100;
        public const int TAM = 500;
        
        static void Main(string[] args)
        {
            TiposDeDatos();
            Parametros(args);

            Console.WriteLine("\t*** Datos ***\n");
            char c = '\u2003';
            GetTipos(c);
            bool verdadero = false;
            GetTipos(verdadero);
            object myObj = new Object();
            GetTipos(myObj);
            var numerosInt = new int[]{1,2,3};
            GetTipos(numerosInt);
            string producto = "Nintendo Premium";
            GetTipos(producto);
            float flotanteNum = 34.2f;
            GetTipos(flotanteNum);
            Program myProg = new Program();
            GetTipos(myProg);
            Int32 entero32 = default(Int32);
            GetTipos(entero32);
            DateTime hoy = DateTime.Today;
            GetTipos(hoy);
            Console.WriteLine("----------------------------------------");
            Operaciones();
            Imprimir();
            VerTipos();
            string espacios = QuitarEspacios("12 33 ");
            Console.WriteLine("Entrada = {0}",espacios);
            IntroduceDatos();
        }
        
        static void EsTipo()
        {
            var cadena = "\nEl alcance de\n\tla gata comelona.".ToUpper();
            var longitud = cadena.Length;
            
            if(cadena is string)
            {
               Console.WriteLine("{0} es string",cadena);
            }
            
            if(longitud is int)
            {
                Console.WriteLine("{0} es int",longitud);
            }
        }

        static string QuitarEspacios(string cadena)
        {
            string resultado = "";
            for(int i=0; i < cadena.Length; i++)
            {
                if(!cadena[i].Equals(" "))
                {
                    resultado += cadena[i];
                    resultado = resultado.Trim();
                }
                
            }
            return resultado;
        }
        static void IntroduceDatos()
        {
            Console.WriteLine("Introduce un numero:");
            string numeroStr = Console.ReadLine();
            Console.WriteLine("Numero: {0}",numeroStr);
            Console.WriteLine("Introduce un otro numero:");
            int numero = Int32.Parse(QuitarEspacios(Console.ReadLine()));
            Console.WriteLine("Numero: {0}",numero);
            Console.WriteLine("Introduce un valor booleano:");
            bool booleano = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Booeano: {0}",booleano);
        }

        static void GetTipos(object dato)
        {
            Console.WriteLine("Dato: {0}",dato);
            Console.WriteLine("Tipo: {0}",dato.GetType());
        }

        static void Operaciones()
        {
            bool verdadero = 12 > 3 && 45 >= 99;//false
            Console.WriteLine("{0}",verdadero);
            verdadero = 45 >= 99 || 33 == 33;//true
            Console.WriteLine("{0}",verdadero);
            verdadero = 12 > 3 && 45 >= 9;//true
            Console.WriteLine("{0}",verdadero);
            verdadero = false && false;//false
            Console.WriteLine("{0}",verdadero);
            verdadero = !(100 <= 0 && -9 > 0);//true
            Console.WriteLine("{0}",verdadero);
        }
        
        static void Imprimir()
        {
           Console.WriteLine("Constante TAM:{0}", TAM);
           Console.WriteLine("Constante MAX:{0}", MAX);
        }
        
        static void Parametros(string[] datos)
        {
            if (datos.Length > 0)
            {
                Console.WriteLine("No. parametros: {0}",datos.Length);
                foreach (string dato in datos)
                {
                    Console.WriteLine("Hola: {0}",dato);
                }
            }
            else
            {
                Console.WriteLine("No hay parametros!!!");
            }
        }
        
        
        static void TiposDeDatos()
        {
            DateTime dateTime = new DateTime(2019, 9, 24);
            byte b = 12;
            char car = '\u1002';
            bool verdadero = 13 > 2;
            decimal numero = 120;
            int entero = 90;
            float flotante = 34.2f;
            double real = 0.000021;
            long clave = 123300L;
            short s = -12;
            sbyte sb = 9;
            ushort us = 1;
            uint enter = 89;
            ulong largo = 2333L;
            object obj = null;
            Object myObj = new Object();
            const string hola_mundo = "Ciao, mondo!!";
            var cliente = new string[]{"Carlos","Uribe","555-54-432"};
            dynamic dinamico = "Dinamico";
            Console.WriteLine("Tipos de datos:");
            Console.WriteLine("sbyte: {0}", sb);
            Console.WriteLine("short: {0}", s);
            Console.WriteLine("int: {0}", entero);
            Console.WriteLine("long: {0}", clave);
            Console.WriteLine("byte: {0}", b);
            Console.WriteLine("ushort: {0}", us);
            Console.WriteLine("uint: {0}", enter);
            Console.WriteLine("ulong: {0}", largo);
            Console.WriteLine("float: {0}", flotante);
            Console.WriteLine("double: {0}", real);
            Console.WriteLine("decimal: {0}", numero);
            Console.WriteLine("object: {0}", obj);
            Console.WriteLine("Object: {0}", myObj);
            Console.WriteLine("char: {0}", car);
            Console.WriteLine("bool: {0}", verdadero);
            Console.WriteLine("MAX: {0}", MAX);
            Console.WriteLine("hola_mundo: {0}",hola_mundo);
            Console.WriteLine("Nombre: {0} {1}",cliente[0],cliente[1]);
            Console.WriteLine("Telefono: {0}",cliente[2]);
            Console.WriteLine("DateTime: {0}",dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine("{0} : {1}",dinamico,dinamico.GetType());
            dinamico = 900;
            Console.WriteLine("{0} : {1}",dinamico,dinamico.GetType());
            dinamico = '\u8990';
            Console.WriteLine("{0} : {1}",dinamico,dinamico.GetType());
            
            dinamico = null;
            try{
                Console.WriteLine("{0} : {1}",dinamico,dinamico.GetType());
            }catch(Exception ex)
            {
                Console.WriteLine("Error: {0}",ex.Message);
            }
            object tipo = s.GetType();
            Console.WriteLine("Tipo = {0}",tipo);
            tipo = verdadero.GetType();
            Console.WriteLine("Tipo = {0}",tipo);
            tipo = entero.GetType();
            Console.WriteLine("Tipo = {0}",tipo);
            tipo = myObj.GetType();
            Console.WriteLine("Tipo = {0}",tipo);
            tipo = dateTime.GetType();
            Console.WriteLine("Tipo = {0}",tipo);
            
            try
            {
                tipo = obj.GetType();
                Console.WriteLine("Tipo = {0}",tipo);
            }catch(Exception ex)
            {
                Console.WriteLine("Error = {0}",ex.Message);
            }
            
            tipo = numero.GetType();
            Console.WriteLine("Tipo = {0}",tipo);

        }

        static void VerTipos()
        {
            dynamic[] dinamicos = {(byte) 32, (int) 43, '\u3211',"Europa renacida",false, new Object(),(float) 5.6f};
            foreach(var din in dinamicos)
            {
                if(din.GetType()==typeof(int))
                {
                    Console.WriteLine("int = {0}",din);
                }

                if(din.GetType()==typeof(byte))
                {
                    Console.WriteLine("byte = {0}",din);
                }

                if(din.GetType()==typeof(char))
                {
                    Console.WriteLine("char = {0}",din);
                }

                if(din.GetType()==typeof(string))
                {
                    Console.WriteLine("string = {0}",din);
                }

            }
        }
        
        
    }
}
