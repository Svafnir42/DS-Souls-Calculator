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
            souls = souls + (int)CalculateIFlevelBelowTwelve(yoursLevel);
            yoursLevel++;
        }
    }
    else if (yoursLevel >= 12)
    {
        while (yoursLevel < neededLevel)
        {
            souls = souls + (int)CalculateIFlevelAboveTwelve(yoursLevel);
            yoursLevel++;
        }
    }
    Console.WriteLine(souls);


    return souls;
}

double CalculateIFlevelBelowTwelve(int level)
{
    int lev = level + 1;
    double calc = (0.0068 * Math.Pow(lev, 3) - 0.06 * Math.Pow(lev, 2) + 17.1 * lev + 639);

    return calc;
}


double CalculateIFlevelAboveTwelve(int level)
{
    int lev = level + 1;
    double calc = ((0.02 * Math.Pow(lev, 3)) + (3.06 * Math.Pow(lev, 2)) + (105.6 * lev) - 895);

    return calc;
}



