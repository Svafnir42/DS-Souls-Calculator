int SoulCalculater()
{
    int yoursLevel = Convert.ToInt32(Console.ReadLine());
    int neededLevel = Convert.ToInt32(Console.ReadLine());
    int souls = 0;
    if (yoursLevel < 12)
        while (yoursLevel < 12)
          souls =+ CalculateIFlevelBelowTwelve(yoursLevel);

    return souls;
}

int CalculateIFlevelBelowTwelve(int level)
{
    int calc = (int)(0.0068* Math.Pow(level, 3) - 0.06 * Math.Pow(level, 2) + 17.1 + level + 639);

    return calc;
}
int CalculateIFlevelAboveTwelve(int level)
{
    int calc = (int)(0.02 * Math.Pow(level, 3) + 3.06 * Math.Pow(level, 2) + 105.6 + level - 895);

    return calc;
}



