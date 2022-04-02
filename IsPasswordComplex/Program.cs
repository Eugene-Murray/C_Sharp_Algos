Console.WriteLine("Algos IsPassword Complex");

static Boolean IsPasswordComplex(string s)
{
    return s.Any(char.IsUpper) && s.Any(char.IsLower)
        && s.Any(char.IsDigit);
}

Console.WriteLine(IsPasswordComplex("Hell0"));
Console.WriteLine(IsPasswordComplex("Hello"));
Console.WriteLine(IsPasswordComplex("HellO"));
Console.WriteLine(IsPasswordComplex("HeLlo"));
Console.WriteLine(IsPasswordComplex("hello"));
Console.WriteLine(IsPasswordComplex(" "));