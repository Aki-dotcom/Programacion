using Builder.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface IHamburguesaBuilder
    {
        IHamburguesaBuilder ConPan(string pan);
        IHamburguesaBuilder ConCarne(string carne);
        IHamburguesaBuilder ConQueso(bool queso = true);
        IHamburguesaBuilder ConLechuga(bool lechuga = true);
        IHamburguesaBuilder ConTomate(bool tomate = true);
        IHamburguesaBuilder ConCebolla(bool cebolla = true);
        IHamburguesaBuilder ConSalsa(string salsa);

        Hamburguesa Build();
    }
}
