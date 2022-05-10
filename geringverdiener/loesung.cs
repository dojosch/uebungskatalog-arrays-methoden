double[] salaries = { 2559.00, 0.00, 485.00, 3820.00, 0.00, 1654.00 };

// Als Mindestlohn wird zuerst das erste Element angenommen
double minSalary = salaries[0];

// Der Durchschnitt steht aktuell auf 0
double avgSalary = 0;

// Weitere Hilfsvariablen

// Summe aller Elemente muss ebenfalls berechnet werden, um den Durchschnitt zu erhalten
double sum = 0;

// Außerdem muss ich für den richtigen Durchschnitt zählen, wie oft das Gehalt nicht 0 ist
int countNotZero = 0;

// Ich schaue mir jedes Element im Array an
for(int i = 0; i < salaries.Length; i++)
{
    // Ich arbeite nur mit Elementen, die nicht 0 sind
    if(salaries[i] != 0)
    {
        // Kurzform für: countNotZero = countNotZero + 1;
        countNotZero++;

        // Summe wird um das Gehalt an der Stelle i erhöht
        sum = sum + salaries[i];

        // Wenn das aktuelle Element kleiner als das Minimum ist, wird dieses Element zum neuen Minimum
        if(salaries[i] < minSalary)
        {
            minSalary = salaries[i];
        }
    }
}

// Ich dividiere die Summe durch die Anzahl der Elemente, die nicht 0 sind
avgSalary = sum / countNotZero;

Console.WriteLine($"Der geringste Lohn beträgt: {minSalary}");
Console.WriteLine($"Der durchschnittliche Lohn beträgt: {avgSalary}");