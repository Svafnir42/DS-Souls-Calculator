SoulCalculater();
 int SoulCalculater()
{
    Console.WriteLine("Please enter your level");
    int yoursLevel = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter the level you need");
    int neededLevel = Convert.ToInt32(Console.ReadLine());
    int souls = 0;
    if (yoursLevel < 12)
    {
        while (yoursLevel < 12 & yoursLevel < neededLevel)
        {
            souls = souls + CalculateIFlevelBelowTwelve(yoursLevel);
            yoursLevel++;
        }
    }
    else if (yoursLevel >= 12)
    {
        while (yoursLevel < neededLevel)
        {
            souls = souls + CalculateIFlevelAboveTwelve(yoursLevel);
            yoursLevel++;
        }
    }
    Console.WriteLine(souls);


    return souls;
}

int CalculateIFlevelBelowTwelve(int level)
{
    int calc = (int)((0.0068* Math.Pow(level, 3)) - (0.06 * Math.Pow(level, 2)) + (17.1 * level) + 639);

    return calc;
}
int CalculateIFlevelAboveTwelve(int level)
{
    int calc = (int)((0.02 * Math.Pow(level, 3)) + (3.06 * Math.Pow(level, 2)) + (105.6 * level) - 895);

    return calc;
}



