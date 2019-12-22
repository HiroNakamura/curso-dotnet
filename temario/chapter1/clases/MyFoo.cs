namespace clases
{
	public class MyFoo
	{
        public MyFoo(){}
        ~MyFoo(){}
        
        public string Nombre
        {
        	get;set;
        }

        public override string ToString()
        {
        	return string.Format("MyFoo{ nombre = {0}",Nombre);
        }
    }
}