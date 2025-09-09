using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases
{
    public class Hamburguesa
    {
        public string Pan { get; internal set; } = "";
        public string Carne { get; internal set; } = "";
        public bool Queso { get; internal set; }
        public bool Lechuga { get; internal set; }
        public bool Tomate { get; internal set; }
        public bool Cebolla { get; internal set; }
        public string Salsa { get; internal set; } = "";

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Hamburguesa con pan: {Pan}");
            sb.AppendLine($"Carne: {Carne}");
            if (Queso) sb.AppendLine("Queso");
            if (Lechuga) sb.AppendLine("Lechuga");
            if (Tomate) sb.AppendLine("Tomate");
            if (Cebolla) sb.AppendLine("Cebolla");
            sb.AppendLine($"Salsa: {Salsa}");
            return sb.ToString();
        }
    }
}
