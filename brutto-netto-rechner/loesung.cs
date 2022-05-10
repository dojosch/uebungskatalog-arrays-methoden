double GetGrossPrice (double netPrice, int vat)
{
    double grossPrice = netPrice * (100 + vat) / 100;
    return grossPrice;
}

double nettoPreis1 = 100.00;
double nettoPreis2 = 200.00;
double nettoPreis3 = 300.00;

// Methode mit 2 Parametern und double als Return-Wert
double bruttoPreis1 = GetGrossPrice(nettoPreis1, 10);
double bruttoPreis2 = GetGrossPrice(nettoPreis2, 20);
double bruttoPreis3 = GetGrossPrice(nettoPreis3, 0);

Console.WriteLine($"Der Bruttopreis des ersten Produkts beträgt: {bruttoPreis1}");
Console.WriteLine($"Der Bruttopreis des zweiten Produkts beträgt: {bruttoPreis2}");
Console.WriteLine($"Der Bruttopreis des dritten Produkts beträgt: {bruttoPreis3}");