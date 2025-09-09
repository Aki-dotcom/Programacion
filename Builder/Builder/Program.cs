using Builder.Clases;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new HamburguesaClasicaBuilder();
            var cocinero = new Cocinero();

            
            var clasica = cocinero.Clasica(builder);
            Console.WriteLine(clasica);

            
            var doble = cocinero.DobleCheddar(new HamburguesaClasicaBuilder());
            Console.WriteLine(doble);

            
            var custom = new HamburguesaClasicaBuilder()
                .ConPan("Integral")
                .ConCarne("Simple")
                .ConQueso()
                .ConLechuga()
                .ConSalsa("Mostaza")
                .Build();

            Console.WriteLine(custom);
        }
    }
}
