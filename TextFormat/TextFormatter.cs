using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormat
{
    public class TextFormatter:ITextFormatter
    {

        private Text _text;
        private List<string> _formattingOptions;

        public TextFormatter(string text)
        {
            _text = new Text(text);
            _formattingOptions = new List<string>();
        }

        public void AddFormattingOption(string option)
        {
            _formattingOptions.Add(option);
        }

        public void RemoveFormattingOption(string option)
        {
            _formattingOptions.Remove(option);
        }

        public void ApplyFormatting()
        {
            foreach (var option in _formattingOptions)
            {
                ApplyFormattingOption(option);
            }
            _text.ApplyFormatting();
        }

        private void ApplyFormattingOption(string option)
        {
            switch (option)
            {
                case "bold":
                    Console.Write("\x1B[1m");
                   
                    break;
                case "italic":
                    Console.Write("\x1B[3m");
                    break;
                case "underline":
                    Console.Write("\x1B[4m");
                    break;
                case "color":
                    Console.Write("\x1B[31m");
                    break;
                case "reset":
                    Console.Write("\x1B[0m");
                    break;

            }
        }
    }
}
