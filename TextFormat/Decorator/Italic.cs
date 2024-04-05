using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormat.Interfaces;

namespace TextFormat.Decorator
{
    internal class Italic : TextDecorator
    {
        public Italic(ITextComponent textComponent) : base(textComponent)
        {
        }

        public override string ApplyFormatting()
        {
            return "<i>" + base.ApplyFormatting() + "</i>";
        }

        public override string RemoveFormat()
        {
            string formattedText = base.RemoveFormat();
            return formattedText.Replace("<i>", "").Replace("</i>", "");
        }

    }
}
