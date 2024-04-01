using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormat
{
    public class Text: ITextFormatter
    {
        private string _text;

        public Text(string text)
        {
            _text = text;
        }

        public void ApplyFormatting()
        {
            Console.Write(_text);
        }
    }
}
