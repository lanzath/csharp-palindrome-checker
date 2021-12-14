// See https://aka.ms/new-console-template for more information
TestPalindrome();

void TestPalindrome()
{
    Console.WriteLine("Escreva um número ou uma palavra");
    string? input = Console.ReadLine();

    if (input == null) TestPalindrome();

    var result = CheckCharacters(input);

    Console.WriteLine(result ? "É palíndromo" : "Não é palíndromo :(");
    Console.ReadLine();

}

bool CheckCharacters(string input)
{
    input = input.ToLower();
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != input[input.Length - i - 1])
            return false;
    }

    return true;
}
