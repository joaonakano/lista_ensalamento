
Dictionary<String, string[]> diasDaSemana = new()
{
    ["segunda"] = ["Sala 1, Bloco 1", "Sala 2, CT"],
    ["terca"] = ["Sala 2, CT", "Sala 2, CT"],
    ["quarta"] = ["Sala 1, Bloco 1", "Sala 2 CT"],
    ["quinta"] = ["", ""],
    ["sexta"] = ["Sala 3, Bloco 4", "Sala 4, CT"],
};

Dictionary<int, string> inputBindings = new()
{
    [1] = "segunda",
    [2] = "terca",
    [3] = "quarta",
    [4] = "quinta",
    [5] = "sexta"
};

int userInput;

while(true) {
    try {
        Console.WriteLine("Boas-vindas! Digite um dia da semana para começar.\n");

        for (int binding = 1; binding <= inputBindings.Count; binding++)
        {
            Console.WriteLine($"[{binding}] = \"{inputBindings[binding]}\"");
        }

        Console.WriteLine("\nPressione CTRL + C para sair...");
        userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput != null)
        {
            int userInputFiltered = (int)userInput;
            if (inputBindings.ContainsKey(userInputFiltered))
            {
                Console.WriteLine("\n============= Encontrou! =============");
                Console.WriteLine(string.Join(" | ", diasDaSemana[inputBindings[userInputFiltered]]));
                Console.WriteLine("======================================\n");
            }
            else
            {
                Console.WriteLine("\n============= Nao Encontrou! ============= ");
                Console.WriteLine($"\"{userInputFiltered.GetType().FullName}\"");
                Console.WriteLine("==========================================\n");
            }
        }
    } catch (Exception e) {
        Console.WriteLine(e.ToString());
        //break;
    }
}

/*
while(true) {
    try {
        var input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Input: \"{input}\"\nType: \"{input.GetType().Name}\"");
    }
    catch (Exception e) {
        Console.WriteLine(e.ToString());
    }
}
*/