using System;
using clases;

namespace interfaces
{
	public class ServicioDImpl: ServicioD
	{

		public ServicioDImpl()
		{
			Console.WriteLine("Se ha creado e inicializado objeto ServicioDImpl");
		}

		~ServicioDImpl(){}
		

		public void Datos()
		{
		   GetModelo.Mostrar();	
		}

		public Modelo GetModelo
		{
			get;set;
		}

		public decimal Operacion(int x, int y)
		{
			return x+y;
		} 

	}
}


