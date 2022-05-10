void Countdown (int from, string endingWord)
{
    for(int i = 1; i <= from; i++)
    {
        Console.WriteLine($"{i} ...");
    }

    Console.WriteLine(endingWord);
}

Console.WriteLine("Von welcher Zahl sollen wir hinunter zählen?");
int countdownFrom = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Was ist dein Schlusswort?");
string endingWord = Console.ReadLine();

Countdown(countdownFrom, endingWord);