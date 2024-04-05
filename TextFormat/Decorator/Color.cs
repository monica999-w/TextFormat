using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormat.Interfaces;

namespace TextFormat.Decorator
{
    internal class Color : TextDecorator
    {
        private string _color;

        public Color(ITextComponent textComponent, string color) : base(textComponent)
        {
            _color = color;
        }

        public override string ApplyFormatting()
        {
            return "<span style=\"color:" + _color + "\">" + base.ApplyFormatting() + "</span>";
        }

        public override string RemoveFormat()
        {
            string formattedText = base.RemoveFormat();
            return formattedText.Replace("<span style=\"color:" + _color + "\">", "").Replace("</span>", "");
        }
    }
}
