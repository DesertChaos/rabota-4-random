namespace very_important_code_goes_here
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Попробуйте угадать число от 1 до 100.");
            
            Random rnd = new Random();
            int goal = rnd.Next(1, 101);
            Console.WriteLine($"По секрету, это число - {goal}.");
            int counter = 0; //счетчик попыток пользователя
            int answer;
            
            start:  //оказывается можно ставить метки просто так. приколь конечно
                Console.WriteLine($"Введите число. Номер попытки {counter + 1}." );
                if (!int.TryParse(Console.ReadLine(), out answer)) { goto start; } //есть проверка на дурачка
                counter++;

            switch (answer)
            {
                case int n when n == goal && counter < 5:
                    Console.WriteLine("Верно.");
                    break;

                case int x when x != goal && counter > 4:
                    Console.WriteLine("Неверно. Попытки закончились");
                    break;

                default:
                    Console.WriteLine("Неверно.");                   
                    goto start;
            }

        }
    }
}
