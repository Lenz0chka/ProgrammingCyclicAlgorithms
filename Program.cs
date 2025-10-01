namespace ProgrammingCyclicAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Введите строку: ");
            char[] Chars = Console.ReadLine().ToCharArray();
            for (int i = 0; i<Chars.Length; i+=2)  
                Chars[i] = Char.ToUpper(Chars[i]);
            Console.WriteLine(Chars);

            // Задание 2
            Console.WriteLine("Введите число до 1000");
            int number = int.Parse(Console.ReadLine());
            if (number <= 1000)
                for (int i = 0; i < number; i++)
                    Console.WriteLine(i);
            else
                Console.WriteLine("Число больше 1000.");

            // Задание 3
            Console.WriteLine("Введите 5 элементов, которые будут добавлены в массив и выведены в обратном порядке");
            string[] stringArray = Console.ReadLine().Split(' ');
            if (stringArray.Length != 5)
                Console.WriteLine("Вы ввели больше/меньше 5 элементов");
            else
            {
                string result = "";
                for (int i = 4; i >= 0; i--)
                    result += $"{stringArray[i]} ";
                Console.WriteLine(result.Trim());
            }
        }
    }
}
