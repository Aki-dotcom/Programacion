using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases
{
    public class Cocinero
    {
        public Hamburguesa Clasica(IHamburguesaBuilder builder)
        => builder
            .ConPan("Clásico")
            .ConCarne("Simple")
            .ConQueso()
            .ConLechuga()
            .ConTomate()
            .ConSalsa("Ketchup")
            .Build();

        public Hamburguesa DobleCheddar(IHamburguesaBuilder builder)
            => builder
                .ConPan("Brioche")
                .ConCarne("Doble")
                .ConQueso()
                .ConCebolla()
                .ConSalsa("Cheddar")
                .Build();
    }
}
