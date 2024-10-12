internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập kích thước của ma trận vuông: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Nhập phần tử ở vị trí [" + i + "," + j + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nMa trận vừa nhập là:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine("\nTổng các phần tử trên đường chéo chính là: " + sum);
    }
}