int pow(int num, int degree){
    int numRaised = num;
    for (int i=1; i < degree; i++)
        numRaised *= num;
    return numRaised;
}

Console.WriteLine(pow(5,4));