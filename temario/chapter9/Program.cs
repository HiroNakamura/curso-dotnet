using System;
using System.Globalization;
using System.Collections.Generic;
using clases;

namespace chapter9
{
    class Program
    {
        static void Main(string[] args)
        {
            MockTestA();
            MockTestB();
            MockTestC();
            MockTestD();
            MockTestE();
        }

        static void MockTestE()
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado("Juan Cortes", DateTime.Now));
            empleados.Add(new Empleado("Mariana Alvarez", DateTime.Now));
            empleados.Add(new Empleado("Erika Lara", DateTime.Now));
            empleados.Add(new Empleado("Federico Lopez", DateTime.Now));
            empleados.Add(new Empleado("Saul Corona", DateTime.Now));
            Console.WriteLine("\n\tEmpleados:\n");
            foreach(var empleado in empleados)
            {
                Console.WriteLine("{0}",empleado);
                Console.WriteLine("Nombre: {0}",empleado.Nombre);
                Console.WriteLine("Fecha de ingreso: {0}",empleado.Ingreso);
                Console.WriteLine("========================================");
            }
            DateTime valor = new DateTime(2019, 10, 12);
            foreach(var empleado in empleados)
            {
                empleado.Ingreso = valor;
            }
            Console.WriteLine("\n\tEmpleados [con fecha actualizada]:\n");
            foreach(var empleado in empleados)
            {
                Console.WriteLine("{0}",empleado);
                Console.WriteLine("Nombre: {0}",empleado.Nombre);
                Console.WriteLine("Fecha de ingreso: {0}",empleado.Ingreso);
                Console.WriteLine("========================================");
            }
        }

        static void MockTestD()
        {
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "es-MX","es-ES","es-AR","en-US", "en-GB", "fr-FR","de-DE", "ru-RU" };
            
            Console.WriteLine("Formatos en varios países:");
            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}: {1}", cultureName,localDate.ToString(culture));
            }
        }

        static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }

        static void MockTestC()
        {
            DateTime valor = new DateTime(2019, 10, 12);
            Console.WriteLine(valor);
            if(valor == DateTime.Today)
            {
                Console.WriteLine("Hoy es {0}",valor);
            }

            Console.WriteLine("Ayer fue: {0}",GetYesterday());

        }

        static void MockTestB()
        {
            DateTime miFecha = DateTime.Now;  
            Console.WriteLine(miFecha.ToString("MM/dd/yyyy"));  
            Console.WriteLine(miFecha.ToString("dddd, dd MMMM yyyy"));  
            Console.WriteLine(miFecha.ToString("dddd, dd MMMM yyyy"));  
            Console.WriteLine(miFecha.ToString("dddd, dd MMMM yyyy"));  
            Console.WriteLine(miFecha.ToString("dddd, dd MMMM yyyy"));  
            Console.WriteLine(miFecha.ToString("dddd, dd MMMM yyyy"));  
            Console.WriteLine(miFecha.ToString("dddd, dd MMMM yyyy HH:mm:ss"));  
            Console.WriteLine(miFecha.ToString("MM/dd/yyyy HH:mm"));  
            Console.WriteLine(miFecha.ToString("MM/dd/yyyy hh:mm tt"));  
            Console.WriteLine(miFecha.ToString("MM/dd/yyyy H:mm"));  
            Console.WriteLine(miFecha.ToString("MM/dd/yyyy h:mm tt"));  
            Console.WriteLine(miFecha.ToString("MM/dd/yyyy HH:mm:ss"));  
            Console.WriteLine(miFecha.ToString("MMMM dd"));  
            Console.WriteLine(miFecha.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));  
            Console.WriteLine(miFecha.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));  
            Console.WriteLine(miFecha.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));  
            Console.WriteLine(miFecha.ToString("HH:mm"));  
            Console.WriteLine(miFecha.ToString("hh:mm tt"));  
            Console.WriteLine(miFecha.ToString("H:mm"));  
            Console.WriteLine(miFecha.ToString("h:mm tt"));  
            Console.WriteLine(miFecha.ToString("HH:mm:ss"));  
            Console.WriteLine(miFecha.ToString("yyyy MMMM"));
            Console.WriteLine("Presiona una tecla para continuar...");  
            Console.ReadKey();
        }

        static void MockTestA()
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("Fecha: {0}",dateTime.Date);
            Console.WriteLine("Dia: {0}",dateTime.Day);
            Console.WriteLine("Dia de la semana: {0}",dateTime.DayOfWeek);
            Console.WriteLine("Dia del año: {0}",dateTime.DayOfYear);
            Console.WriteLine();
            dateTime = DateTime.Now;
            Console.WriteLine("Fecha: {0}",dateTime.Date);
            Console.WriteLine("Dia: {0}",dateTime.Day);
            Console.WriteLine("Dia de la semana: {0}",dateTime.DayOfWeek);
            Console.WriteLine("Dia del año: {0}",dateTime.DayOfYear);
            var endYear = 365 - dateTime.DayOfYear;
            Console.WriteLine("Faltan: {0} dias para que sea fin de año",endYear);


        }
    }
}
