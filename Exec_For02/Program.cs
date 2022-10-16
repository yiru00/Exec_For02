internal class Program
{
    private static void Main(string[] args)
    {
        //等腰星形三角形
        for (int i = 1; i <= 7; i += 2)
        {
            int countOfStar = i;
            int countOfEmpty = (7 - i) / 2;
            string row = new string(' ', countOfEmpty) + new string('*', countOfStar) + new string(' ', countOfEmpty);
            Console.WriteLine(row);
        }
    }
}