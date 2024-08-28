class RollDice
{
    int roll1, roll2, roll3;
    public int total;
    public string roll()
    {
        Random dice = new Random();
        roll1 = dice.Next(1, 7);
        roll2 = dice.Next(1, 7);
        roll3 = dice.Next(1, 7);

         //Суммируем всё
        total =  roll1 + roll2 + roll3;

        //Выводим сообщение
        string text =  $"Dice roll: {roll1} + {roll2} + {roll3} = {total}";

        //Балуемся с логикой, первое if о том что если любые 2 числа ровны то +2, второе if о том что если все числа равны то +6
        if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            if (roll1 == roll2 && roll2 == roll3)
            {
                total += 6;
                text += $"\nВы выпали в тройном разряде! Всего +6 бонусов!\nОбщий крен: {total}";
            }
            else
            {
                total += 2;
                text += $"\nТы сделал двойной бросок! +2 бонуса к общему количеству бросков! \nОбщий бросок: {total}";
            }
        }

        //Сообщение вывода резузлььтата на основе суммы всех числе(включая бонусы)
        if (total >= 17)
        {
            text += "\nТы выигрываешь новую машину!";
        }
        else if (total >= 14)
        {
            text +="\nТы выигрываешь новый ноутбук!";
        }
        else if (total == 5)
        {
            text += "\nВы выигрываете поездку на двоих!";
        }
        else
        {
            text += "\nТы проиграл.";
        }
        return text;
    }

    
}