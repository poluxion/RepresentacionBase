using System;

class Program
{
    static void Main(string[] args)
    {
        //Ejemplo de uso del metodo ConvertBase
        int NumX = 287;
        int baseK = 4;

        string RepBase = ConvertBase(NumX, baseK);
        Console.WriteLine($"El numero {NumX} en base {baseK} es: {RepBase}");
    }

    static string ConvertBase(int NumX, int baseK)
    {
        string Resultado = "";

        //Conidicional para evitar cantidad 0.
        if(NumX == 0)
        {
            return "0";
        }
        //Bucle para dividir la base por la cantidad.
        while(NumX > 0)
        {
            int Residuo = NumX % baseK;
            Resultado = Residuo + Resultado;
            NumX = NumX / baseK;
        }

        return Resultado;
    }
}
