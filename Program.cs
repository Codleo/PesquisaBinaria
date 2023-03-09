using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        var myList = new List<int> { 1, 2, 3, 4, 5, 6, 12, 13, 15, 17, 22, 25, 27, 30, 32, 33, 34, 36, 39, 40, 41, 42, 43, 46, 47, 49, 50, 52, 57, 58, 61, 65, 66, 67, 68, 69, 70, 71, 72, 74, 76, 77, 81, 87, 88, 90, 94, 95, 96, 97, 99, 100 };
        Console.WriteLine("Digite o valor da lista que quer buscar");
        int valor = int.Parse(Console.ReadLine());

        if (!myList.Contains(valor))
            Console.WriteLine($"{valor} não existe na lista");

        else
            Console.WriteLine(PesquisaBinaria(myList, valor) + $" é a posição do seu número {valor}");
    }

    private static int? PesquisaBinaria(IList<int> list, int item)
    {
        var baixo = 0;
        var alto = list.Count() - 1;

        while (baixo <= alto)
        {
            var meio = (baixo + alto) / 2;
            var chute = list[meio];
            if (chute == item) return meio;
            if (chute > item)
                alto = meio - 1;

            else
                baixo = meio + 1;

        }
        return null;
    }
}
