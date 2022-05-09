// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(){
        string[] names = { "Matheus", "Breno"};
    
        if (string.Equals(names[0], "Matheus", StringComparison.OrdinalIgnoreCase)){
            Console.WriteLine("Troll");
        }

        foreach(string name in names) {
            Console.WriteLine(name);
        }
    }
}

/*
string name;
int year, age;

Console.WriteLine("Ola seja bem-vindo!");

Console.WriteLine("Para começar, digite seu nome:");

name = Console.ReadLine();

Console.WriteLine($"Ola, {name}! \nAgora digite o seu ano de nascimento:");

year = int.Parse(Console.ReadLine());

age = 2022 - year;

Console.WriteLine($"Você tem {age} anos.");
*/