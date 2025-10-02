// See https://aka.ms/new-console-template for more information


double nota1, nota2, nota3, media;
Console.WriteLine("media aritmetica de 3 numeros");

Console.WriteLine("digite seu primeiro numero..:");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite seu segundo numero...:");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite seu terceiro numero..:");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"\nmedia: {media:n1}");
