//1
printHeader();
printHeader();
Console.WriteLine("основная часть программы");
printFooter();

void printHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("лабораторная работа №13");
    Console.WriteLine("0_0");
}

void printFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("конец программы");
    Console.WriteLine("X_X");
    Console.WriteLine("дата формирования отчета 01.11.2026 16:41");
}
//2
void printStudentCard(string name, int age, string group)
{
    Console.WriteLine($"Студент:{name}, возраст: {age}, группа:{group}");
}
printStudentCard("егор", 18, "isp-251");
printStudentCard("Валерия", 17, "isp-255");

//3 
double bonus = 4.2;
if (IsEligibleForBonus(bonus))
{
    double result =  calculateScholarship (2000, 15);
    Console.WriteLine($"с надбавкой {result} ");
}
else
{
    double result =  calculateScholarship (2000, 0);
    Console.WriteLine($"без  надбавки {result} ");
}

bool  IsEligibleForBonus(double bonus)
{
    if (bonus >= 4.5) return true;

    else
    {
        return false;
    }

}
double calculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}
