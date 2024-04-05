using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormat.Interfaces;

namespace TextFormat.Decorator
{
    internal class Underline : TextDecorator
    {
        public Underline(ITextComponent textComponent) : base(textComponent)
        {
        }

        public override string ApplyFormatting()
        {
            return "<u>" + base.ApplyFormatting() + "</u>";
        }

        public override string RemoveFormat()
        {
            string formattedText = base.RemoveFormat();
            return formattedText.Replace("<u>", "").Replace("</u>", "");
        }
    }
}
