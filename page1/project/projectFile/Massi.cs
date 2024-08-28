class Massi
/*
{ 
    public string CheckMass()
    
    {
        string result = "";
        string[] names = {"Roman", "Robin", "Bao"};
        foreach (string name in names)
        {
            result += name + "\n";
        }
        return result;
    }
}
*/
{
    public string CheckMass()
    {
        string result = "";
        string[] strings = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

        foreach (string bWord in strings)
        {
            if (bWord.StartsWith("B"))
            {
                result += $"{bWord}\n";
            }
        }
        return result;
    }
}