using TextFormat;

class Program
{
    static void Main(string[] args)
    {
        
        TextFormatter text = new TextFormatter("This is a text");

        
        text.AddFormattingOption("bold");
        text.AddFormattingOption("italic");
        text.AddFormattingOption("underline");
        text.AddFormattingOption("color");
       // text.AddFormattingOption("reset");

        text.ApplyFormatting();

        
        Console.ResetColor();
    }
}