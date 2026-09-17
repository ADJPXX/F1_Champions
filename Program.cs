namespace F1_Champions;

public static class Program
{
    public static void Main(string[] args)
    {
        var champions = new ChampionsList();

        Dictionary<string, string> unanswered = new();
        
        foreach (var (key, value) in champions.Champions)
        {
            while (true)
            {
                Console.WriteLine("Se quiser passar para o próximo ano, digite \"p\"");
                var champion = ReadString($"Digite o campeão de {key}: ");
                
                Console.WriteLine();

                var isCorrect = value.Equals(champion, StringComparison.OrdinalIgnoreCase) || value
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Any(name => name.Equals(champion, StringComparison.OrdinalIgnoreCase));

                if (champion!.ToLower().Equals("p"))
                {
                    unanswered.Add(key, value);

                    break;
                }
                
                if (isCorrect)
                {
                    break;
                }
                
                Console.WriteLine($"Não foi o \"{champion}\" que ganhou o título de {key}. Tente novamente.\n");
            }
        }

        if (unanswered.Count <= 0)
        {
            return;
        }
        
        Console.WriteLine("Anos não respondidos:");
        foreach (var unansweredKey in unanswered)
        {
            Console.WriteLine(unansweredKey.Key);
        }

        foreach (var (key, value) in unanswered)
        {
            while (true)
            {
                var champion = ReadString($"Digite o campeão de {key}: ");
                
                var isCorrect = value.Equals(champion, StringComparison.OrdinalIgnoreCase) || value
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Any(name => name.Equals(champion, StringComparison.OrdinalIgnoreCase));

                if (isCorrect)
                {
                    break;
                }
                
                Console.WriteLine($"Não foi o \"{champion}\" que ganhou o título de {key}. Tente novamente.\n");
            }
        }
    }


    private static string? ReadString(string msg)
    {
        try
        {
            while (true)
            {
                Console.Write(msg);

                var str = Console.ReadLine()?.Trim();
                if (!string.IsNullOrWhiteSpace(str))
                {
                    return str;
                }
            }
        }
        catch
        {
            return null;
        }
    }
}