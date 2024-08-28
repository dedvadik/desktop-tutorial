internal class Program
{
    private static void Main(string[] args)
    {
        bool menu = true;
        while (menu)
        {
            System.Console.WriteLine(" \n Выберите программу для запуска: ");
            System.Console.WriteLine("1. Для запуска нажмите 1");
            System.Console.WriteLine("2. Для запуска проверки подписки нажмите 2");
            System.Console.WriteLine("3. Для запуска масива нажмите 3");
            System.Console.WriteLine("4. Для запуска подсчёта суммы нажмите 4");
            System.Console.WriteLine("5. для");
            System.Console.WriteLine("6. Для выхода из приложения нажмите q \n ");

            string m = Console.ReadLine();
            if (m == "1")
            {
                RollDice rd = new();
                Console.WriteLine(rd.roll());  
            }
            else if (m == "2")
            {
                Sub sub = new();
                Console.WriteLine(sub.CheckSub());
            }
            else if (m == "3")
            {
                Massi mass = new();
                Console.WriteLine(mass.CheckMass());
            }
            else if (m == "4")
            {
                CheckSum masum = new();
                Console.WriteLine(masum.Check());
            }
            else if (m == "5")
            {

            }
            else if (m == "q")
            {
                menu = false;
            }
            else if (m == "й")
            {
                menu = false;
            }
            else
            {
                System.Console.WriteLine("Нет такого пункта меню"); 
            }
        }
    
    }

}
