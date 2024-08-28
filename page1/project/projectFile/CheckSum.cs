class CheckSum
{   
    public string Check()
    {
        string roll = "";
        string result = "";
        int[] inventory = {200, 450, 700, 175, 250};
        int sum = 0;
        int bin = 0;
        
        foreach (int items in inventory)
        {
            sum += items;
            bin ++;
            roll += $"Bin {bin} = {items} вещей (Общее: {sum})\n";
            string text = $"Вы имеете {sum} вещей в инвенторе.";
            result = roll + text;
        }
        return result;
    }
}