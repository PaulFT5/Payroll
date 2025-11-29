namespace Payroll.Logic;

public class EmployeeBehaviour : IEmployeeBehaviour
{

    public static bool MissedADay() //reset every year
    {
        var random = new Random();
        const int chance = 2;
        return random.Next(0, 100) <= chance;
    }

    public static int WorkedExtraChance()
    {
        var random = new Random();
        var Chance1Hour = 16;
        var Chance2Hour = 8;
        var Chance4Hour = 4;
        //return random.Next(0, 100) <= chance;
        if (random.Next(0, 100) <= Chance4Hour) return 4;
        if (random.Next(0, 100) <= Chance2Hour) return 2;
        if (random.Next(0, 100) <= Chance2Hour) return 1;

        return 0;
    }
}