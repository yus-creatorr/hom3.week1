// string Hello()
// {
//     return "Hello World";
// }
// System.Console.WriteLine(Hello());

// task 2
// double Add(double a, double b)
// {
//     return a + b;
// }
// double a = Convert.ToInt32(Console.ReadLine());
// double b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Add(a,b));

// task 3
// double Minus(double a, double b)
// {
//     return a - b;
// }
// double a=Convert.ToInt32(Console.ReadLine());
// double b=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Minus(a,b));

// task 4
// double Kara(double a, double b)
// {
//     return a * b;
// }
// double a = Convert.ToInt32(Console.ReadLine());
// double b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Kara(a,b));

// task 5
// double Taksim(double a, double b)
// {
//     return a/b;
// }
// double a=Convert.ToInt32(Console.ReadLine());
// double b=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Taksim(a,b));


// task 6
// double Square(double a)
// {
//     return a*a;
// }
// double a =Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine(Square(a));


// task 7
// double Sqrt(double a)
// {
//     return Math.Sqrt(a);
// }
// double a=Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine(Sqrt(a));

// task 8
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Fact(a));
// int Fact(int a)
// {
//     int fact=1;
//     for(int i = 1; i <= a; i++)
//     {
//         fact*=i;
//     }
//     return fact;
// }


// task 1
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Prover(a));
// bool Prover(int a)
// {
//     if (a > 10)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// task 2
// int a = Convert.ToInt32(Console.ReadLine());
// int rev=0;
// Console.WriteLine(Palindrome(a));
// string Palindrome(int a)
// {

//     for(int i = a; i > 0; i /= 10)
//     {
//         rev=rev*10+i%10;
//     }
//     if (rev == a)
//     {
//         return "Palindrome";
//     }
//     else
//     {
//         return "NotPalindrom";
//     }
// }

// task 3
// int a =Convert.ToInt32(Console.ReadLine());
// int b =Convert.ToInt32(Console.ReadLine());
// int Summ(int a, int b)
// {
//     return a+ b;
// }
// System.Console.WriteLine("Sum: "+Summ(a,b));


// task 4
// int a = Convert.ToInt32(Console.ReadLine());
// int Plus(int a)
// {
//     return a+1;
// }
// System.Console.WriteLine("Result: "+Plus(a));


// task 5
// double height=Convert.ToDouble(Console.ReadLine());
// double basee=Convert.ToDouble(Console.ReadLine());
// double S(double height, double basee)
// {
//     return (height*basee)/2;
// }
// System.Console.WriteLine("Area: "+S(height,basee));


// task 6
// int age=Convert.ToInt32(Console.ReadLine());
// int Year(int age)
// {
//     return age*365;
// }
// System.Console.WriteLine("AgeInDay: "+Year(age));

// task 7
// int year = Convert.ToInt32(Console.ReadLine());

// int cnt = 0;

// string Work(int year)
// {
//     for (int i = year; i < 2026; i++)
//     {
//         cnt++;
//     }

//     if (cnt > 18 && cnt < 100)
//     {
//         return "Welcome, you are " + cnt + " years old and you can work.";
//     }
//     else
//     {
//         return "Hello, you are " + cnt + " years old, and you can't work.";
//     }
// }

// Console.WriteLine(Work(year));


// task 8