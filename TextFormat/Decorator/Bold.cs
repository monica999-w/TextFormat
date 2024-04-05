using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormat.Interfaces;

namespace TextFormat.Decorator
{
    internal class Bold : TextDecorator
    {
        public Bold(ITextComponent textComponent) : base(textComponent)
        {
        }

        public override string ApplyFormatting()
        {
            return "<b>" + base.ApplyFormatting() + "</b>";
        }
        public override string RemoveFormat()
        {
            string formattedText = base.RemoveFormat();
            return formattedText.Replace("<b>", "").Replace("</b>", "");
        }
    }
}
