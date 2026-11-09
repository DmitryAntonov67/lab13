//1
using System.Globalization;

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
    double result =  calculateScholarship (2000,0) ;
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
//4
double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;

    }
    return (double)sum / grades.Length;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
Console.WriteLine(average);
int countFives(int[] grades)
{
    int count = 0;
    foreach(int grade in grades)
    if(grade == 5){count ++; }
    return count;
}
Console.WriteLine($"количество пятерок: {countFives(grades)}");

//самостоятельное задание  в и г
//в
 bool IsEven(int number)
{
    if(number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int testNumber = 5;
if (IsEven(testNumber))
{
    Console.WriteLine($"четное число:{testNumber}");
}
else
{
    Console.WriteLine($"не четное:{testNumber}");
}
//Г
int FindMax(int[] numbers)
{
    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }
    return max;
}
int[] myArray = { 4, 5, 2, 7, 54, 3, 1 };
Console.WriteLine($"максимальное число массива {FindMax(myArray)}");

//индивидуальное задание 4 9
// 4
int SumArray(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
int[] numberSS = { 1, 4, 6, 7, 32, 47, 67, 23 };
Console.WriteLine($"сумма элементов: {SumArray(numberSS)}");

//9
 bool ContainsValue(int[] numbers, int target)
{
    foreach (int number in numbers)
    {
        if (number == target)
        {
            return true;
        }
    }
    return false;
}
int[] testArray = { 34, 32, 12, 67 };
int searchFor = 4545;
if (ContainsValue(testArray, searchFor))
{
    Console.WriteLine($" найдено в массиве {searchFor}");
}
else
{
    Console.WriteLine($"не найдено{searchFor}");
}