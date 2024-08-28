class Sub
{
    public string CheckSub()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration <= 0)
        {
            return "Срок действия вашей подписки истек.";
        }
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            return "Срок действия вашей подписки истекает через один день!";
            
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            return $"Срок действия вашей подписки истекает через {daysUntilExpiration} дней.";
            
        }
        else if (daysUntilExpiration <= 10)
        {
            return "Срок действия вашей подписки скоро истечет. Продлевайте прямо сейчас!";
        }
        if (discountPercentage > 0)
        {
            return $"Обновите сейчас и сэкономьте {discountPercentage}%.";
        }
        return " ";
    }
}
