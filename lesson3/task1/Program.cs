double CalculateFormula(int a, int b, int c, int d)
{
    double numinator = a * b;
    double denominator = c + d;
    double result = numinator / denominator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);