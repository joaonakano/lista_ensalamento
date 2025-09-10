Dictionary<String, string[]> diasDaSemana = new()
{
    ["segunda"] = ["Sala 1, Bloco 1", "Sala 2, CT"],
    ["terca"]   = ["Sala 2, CT", "Sala 2, CT"],
    ["quarta"]  = ["Sala 1, Bloco 1", "Sala 2 CT"],
    ["quinta"]  = ["", ""],
    ["sexta"]   = ["Sala 3, Bloco 4", "Sala 4, CT"],
};

string? userInput;

do
{
    Console.WriteLine("Bem-vindo(a) ao meu programa de listagem de ensalamento!\nDigite um dia da semana para obter o ensamento:");
    userInput = Console.ReadLine();

    if (userInput != null)
    {
        string userInputFiltered = userInput.Trim();
        if (diasDaSemana.ContainsKey(userInputFiltered))
        {
            Console.WriteLine("\n============= Encontrou! =============");
            Console.WriteLine(string.Join(" | ", diasDaSemana[userInputFiltered]));
            Console.WriteLine("======================================\n");
        }
        else
        {
            Console.WriteLine("\n============= Nao Encontrou! ============= ");
            Console.WriteLine($"\"{userInputFiltered.GetType().FullName}\"");
            Console.WriteLine("==========================================\n");
        }
    }
} while (userInput != null);