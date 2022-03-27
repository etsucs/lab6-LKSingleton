Console.WriteLine(ShowCharacter("New York", 5));

Console.WriteLine(CalculateRetail());

for(var counter = 80; counter <= 100; counter ++)
{
    Console.WriteLine(Celsius(counter));
}

Console.WriteLine(IsPrime(997));


//Show Character
static char ShowCharacter(string inputWord, int position)
{
    char outputChar;
    return outputChar = inputWord[position-1];
}


//Retail Price
static double CalculateRetail()
{
    Console.WriteLine("Input wholesale cost.");
    double wholesaleCost = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Input markup percentage.");
    double markupPercentage = Convert.ToDouble(Console.ReadLine());

    double retailPrice = wholesaleCost*(1+(markupPercentage/100));
    return retailPrice;
}

//Temperature Table
static double Celsius(double tempF)
{
    double tempC = (5*(tempF-32))/9;
    return tempC;
}


//Prime Numbers
static bool IsPrime(int inputNumber)
{
    int count = 2;
    double halvedInput = inputNumber/2;
    bool isPrime = true;

    while(count<= (halvedInput))
    {
        var remainder = inputNumber%count;
        if(remainder == 0)
        {
            isPrime = false;
            count = inputNumber;
        }
        count++;
    }
    return isPrime;
}