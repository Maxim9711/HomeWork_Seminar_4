int sumSymbol (int num){
    int sumSymbol = 0;

    while(Convert.ToBoolean(num)){
        sumSymbol += num % 10;
        num /= 10;
    }

    return sumSymbol;
}

Console.WriteLine(sumSymbol(77885555));