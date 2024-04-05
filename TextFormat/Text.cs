using TextFormat.Interfaces;

namespace TextFormat
{
    public class Text: ITextComponent
    {
        private string _text;

        public Text(string text)
        {
            _text = text;
        }

        public string ApplyFormatting()
        {
            return _text;
        }

    }
}
