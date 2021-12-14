# Exemplo de utilização de strings

###### Guid - (Global Unique Id)

Identificadores únicos (hash).

**Ex**

```cs
 var id = Guid.NewGuid();
 Console.WriteLine(id);
```

###### Interpolação de Strings.

Concatenação de strings com variáveis.

**Ex**

```cs
var price = 10.99;
Console.WriteLine($"O preço do produto é {price}\n");
Console.WriteLine(string.Format("3 + 5 = {0}", 3 + 5));
Console.WriteLine(" 0 - " + false + "\n 1 - " + true);
Console.WriteLine(@"
Exemplo
de string com
quebra de linha
");
```

###### Comparação de Strings.

**Ex**

```cs
 var test = "Testing...";
 Console.WriteLine(test.CompareTo("testing..."));
 Console.WriteLine(test.Contains("..."));
 Console.WriteLine(test.Contains("test", StringComparison.OrdinalIgnoreCase));  Ignora o case sensitive na comparação
 Console.WriteLine(test.StartsWith("v"));
 Console.WriteLine(test.EndsWith("."));
```
