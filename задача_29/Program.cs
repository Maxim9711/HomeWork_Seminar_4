int[] randomArray (int length){

    int [] array = new int [length];

    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

void showArray (int[] array){
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int [] array = randomArray(5);
showArray(array);
