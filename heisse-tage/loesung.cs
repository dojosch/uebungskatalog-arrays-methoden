double[] temperaturesJuly = { 23.9, 22.34, 32.46, 20.81, 15.72, 36.5, 32.71, 25.95, 37.6, 20.15, 33.91, 28.59, 23.84, 20.67, 17.24, 19.71, 28.5, 22.69, 28.07, 21.83, 34.37, 20.06, 36.55, 30.29, 16.36, 21.81, 23.23, 37.79, 22.6, 17.23, 33.44, 21.55 };

int hotDays = 0;

// YOUR CODE HERE
for(int i = 0; i < temperaturesJuly.Length; i++)
{
    // Es werden nur Tage mit Temperaturen über oder gleich 30 Grad berücksichtigt
    if(temperaturesJuly[i] >= 30.0)
    {
        // Die heißen Tage werden um 1 erhöht
        hotDays++;+

        // Der Tag wird ausgegeben
        Console.WriteLine($"Der {i + 1}. Juli war ein heißer Tag mit {temperaturesJuly[i]}°C");
    }
}

Console.WriteLine($"Es gab insgesamt {hotDays} Tage über 30°C");