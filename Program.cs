using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       
        CultureInfo culture = CultureInfo.InvariantCulture;

        Console.WriteLine("--- Churrasco ---\n");

        Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
        int adultosBebem = int.Parse(Console.ReadLine());

        Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
        int adultosNaoBebem = int.Parse(Console.ReadLine());

        Console.Write("Crianças........................................: ");
        int criancas = int.Parse(Console.ReadLine());

    
        int totalAdultos = adultosBebem + adultosNaoBebem;

        double carneGramas = totalAdultos * 400 + criancas * 200;
        double acompanhamentoGramas = (totalAdultos + criancas) * 200;
        double cervejaMl = adultosBebem * 2000;
        double refrigeranteMl = adultosNaoBebem * 500 + criancas * 500;
        double aguaMl = (totalAdultos + criancas) * 400;

        
        double carneKg = carneGramas / 1000.0;
        double acompanhamentoKg = acompanhamentoGramas / 1000.0;
        double cervejaL = cervejaMl / 1000.0;
        double refrigeranteL = refrigeranteMl / 1000.0;
        double aguaL = aguaMl / 1000.0;

      
        Console.WriteLine("\n--- Resultado ---\n");
        Console.WriteLine($"Carne.............: {carneKg.ToString("0.0", culture)}kg");
        Console.WriteLine($"Acompanhamentos...: {acompanhamentoKg.ToString("0.0", culture)}kg");
        Console.WriteLine($"Cerveja...........: {cervejaL.ToString("0.0", culture)}l");
        Console.WriteLine($"Refrigerante......: {refrigeranteL.ToString("0.0", culture)}l");
        Console.WriteLine($"Água..............: {aguaL.ToString("0.0", culture)}l");
    }
}

