using Assessment;
using System.Collections;

//Question-1
Console.WriteLine("Quesion 1 -");
List<int> intList = new List<int>();
Console.Write("How many numbers u want to put into the list - ");
int count = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    intList.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.WriteLine("1. Show even numbers count\n2. Show odd numbers count");
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine(intList.Where(x => x % 2 == 0).Count());
        break;
    case "2":
        Console.WriteLine(intList.Where(x => x % 2 != 0).Count());
        break;
}

//Question-2
Console.WriteLine("\nQuestion 2 -\nEnter a number - ");
int num = Convert.ToInt32(Console.ReadLine());
object obj = num;    //Boxing
Console.WriteLine($"Printing same number after bosing - {obj}");
int num2 = (int)obj;    //UnBoxing
Console.WriteLine($"Printing same number after unboxing - {num2}");

//Question-3
Console.WriteLine("\nQuestion 3 -\nEnter any 3 numbers - ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Max of these 3 numbers is - {Math.Max(number1, Math.Max(number2, number3))}");

//Question-4
Console.WriteLine("\nQuestion 4-\nAll odd numbers between 1 to 10 are -");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 != 0) Console.Write($"{i}, ");
}

//Question-5
Console.WriteLine("\n\nQuestion 5 -");
MethodOverloading overloadingObj = new MethodOverloading();
overloadingObj.Sum(10, 20);
overloadingObj.Sum(10, 20, 30);

//Question-6
Console.WriteLine("\nQuestion 6 -\nEnter any 5 cities name - ");
ArrayList arrayList = new ArrayList();
for(int i = 0; i < 5; i++)
{
    arrayList.Add(Console.ReadLine());
}
arrayList.Sort();
foreach(string city in arrayList)
{
    Console.Write($"{city}, ");
}

//Question-7
Console.WriteLine("\n\nQuestion 7 -");
OverloadedConstructor overloadedConstructor = new OverloadedConstructor(10, 20);
OverloadedConstructor overloadedConstructor1 = new OverloadedConstructor(10, 20, 30);

//Question-8
Console.WriteLine("\nQuestion 8 -\nEnter any 2 numbers -");
number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
Perform perform = new Perform();
perform.Addition(number1, number2);
perform.Multiplication(number1, number2);

//Question-9
Console.WriteLine("\nQuestion 9 -");
Dictionary<int, string> cricketers = new Dictionary<int, string>
{
    { 1,"Sunny Gavaskar"},{ 2,"Virender Sehwag"},{ 3,"Rahul Dravid"},{ 4,"Sachin Dravid"},{ 5,"Kapil Dev"},{ 6,"MS Dhoni"},{ 7,"Anil Kumble"},
    { 8,"Saurabh Ganguly"},{ 9,"Virat Kohli"},{ 10,"Harbhajan Singh"},{ 11,"Yuvraj Singh"},
};
foreach(var name in cricketers)
{
    Console.Write($"{name.Value}, ");
}

//Question-10
Console.WriteLine("\n\nQuestion 10 -");
List<Student> studentList = new List<Student>
{
    new Student{Id=1,Name="Abhay Singh",Age=21},
    new Student{Id=2,Name="Shobhit Yadav",Age=22},
    new Student{Id=3,Name="Himanshu Mishra",Age=23},
    new Student{Id=4,Name="Akash Verma",Age=18},
    new Student{Id=5,Name="SriAnanda Panda",Age=11},
};
var student = studentList.Where(s => s.Age <= 18).ToList();
if(student == null)
{
    Console.WriteLine("Student with this Id doesn't exists");
}
else
{
    foreach(var item in student)
    {
        Console.WriteLine($"Name - {item.Name}");
    }
}