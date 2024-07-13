class Program
{
    static void Main()
    {
        Console.WriteLine("OldPhonePad(\"33#\") => " + OldPhonePad.ConvertInput("33#"));
        Console.WriteLine("OldPhonePad(\"227*#\") => " + OldPhonePad.ConvertInput("227*#"));
        Console.WriteLine("OldPhonePad(\"4433555 555666#\") => " + OldPhonePad.ConvertInput("4433555 555666#"));
        Console.WriteLine("OldPhonePad(\"8 88777444666*664#\") => " + OldPhonePad.ConvertInput("8 88777444666*664#"));
        Console.WriteLine("OldPhonePad(\"669994440448 88 80999929#\") => " + OldPhonePad.ConvertInput("669994440448 88 80999929#"));

    }
}