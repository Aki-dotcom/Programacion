using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases
{
    public class HamburguesaClasicaBuilder:IHamburguesaBuilder
    {
        private Hamburguesa _hamburguesa = new();

        public IHamburguesaBuilder ConPan(string pan)
        {
            _hamburguesa.Pan = pan;
            return this;
        }

        public IHamburguesaBuilder ConCarne(string carne)
        {
            _hamburguesa.Carne = carne;
            return this;
        }

        public IHamburguesaBuilder ConQueso(bool queso = true)
        {
            _hamburguesa.Queso = queso;
            return this;
        }

        public IHamburguesaBuilder ConLechuga(bool lechuga = true)
        {
            _hamburguesa.Lechuga = lechuga;
            return this;
        }

        public IHamburguesaBuilder ConTomate(bool tomate = true)
        {
            _hamburguesa.Tomate = tomate;
            return this;
        }

        public IHamburguesaBuilder ConCebolla(bool cebolla = true)
        {
            _hamburguesa.Cebolla = cebolla;
            return this;
        }

        public IHamburguesaBuilder ConSalsa(string salsa)
        {
            _hamburguesa.Salsa = salsa;
            return this;
        }
        public Hamburguesa Build()
        {
            if (string.IsNullOrWhiteSpace(_hamburguesa.Pan))
                throw new InvalidOperationException("La hamburguesa debe tener pan.");

            if (string.IsNullOrWhiteSpace(_hamburguesa.Carne))
                throw new InvalidOperationException("La hamburguesa debe tener carne.");

            var resultado = _hamburguesa;
            _hamburguesa = new Hamburguesa();
            return resultado;
        }
    }
}
