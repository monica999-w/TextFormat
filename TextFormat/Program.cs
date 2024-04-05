using TextFormat;
using TextFormat.Decorator;
using TextFormat.Interfaces;

class Program
{
    static void Main(string[] args)
    {

        ITextComponent text = new Text("This is a text");

        text = new Bold(text);
        text = new Italic(text);
        text = new Underline(text);
        text = new Color(text,"red");


        string formattedText = text.ApplyFormatting();
        Console.WriteLine("Formatted Text: " + formattedText);

        if (text is Color)
            text = new Text(((Color)text).RemoveFormat());


        string plainText = text.ApplyFormatting();
        Console.WriteLine(" Text: " + plainText);
    }
}