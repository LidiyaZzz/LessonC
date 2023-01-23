void Method1()
{
  Console.WriteLine("Autor: LidiyaZ");
}
Method1();

void Method2(string name)
{
  Console.WriteLine($"Autor: {name}");
}
Method2("Anton");

void Method21(string name, string family)
{
  Console.Write($"Autor: {name}");
  Console.WriteLine($" {family}");
}
Method21(family: "Petrov", name: "Anton"); // явно указываем какому аргументу какое значение, в этом случае порядок не важен

int Method3()
{
  return DateTime.Now.Year;
}
Console.WriteLine(Method3());

string Method4(int count, string text)
{
  int i = 0;
  string resalt = String.Empty;

  while (i < count)
  {
    resalt += text;
    i++;
  }
  return resalt;
}
Console.WriteLine(Method4(5, "Привет! "));



