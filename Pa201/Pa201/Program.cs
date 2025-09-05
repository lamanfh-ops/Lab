// See https://aka.ms/new-console-template for more information

//string name = "Leman";

//Console.WriteLine("Hello " + name);

//int num = 12;

//if (num >= 90 && num < 100)
//{
//    Console.WriteLine("A");
//}
//else if (num >= 70 && num <= 89)
//{
//    Console.WriteLine("B");
//}
//else if (num >= 50 && num <= 69)
//{
//    Console.WriteLine("C");
//}
//else if (num <= 50)
//{
//    Console.WriteLine("F");
//}
//else
//{
//    Console.WriteLine("Baliniz bu cedvele uygun deyil");
//}

//string input = Console.ReadLine();
//Console.WriteLine("salam " + input);

string input = Console.ReadLine();
int num = Convert.ToInt32(input);


if (num >= 90 && num < 100)
{
    Console.WriteLine("A");
}
else if (num >= 70 && num <= 89)
{
    Console.WriteLine("B");
}
else if (num >= 50 && num <= 69)
{
    Console.WriteLine("C");
}
else if (num <= 50)
{
    Console.WriteLine("F");
}
else
{
    Console.WriteLine("Baliniz bu cedvele uygun deyil");
}
