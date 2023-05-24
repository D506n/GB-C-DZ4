//Вариант третий, он будет выводить 8 случайных чисел
Random rand = new Random();
int step = 0;
int[] ArrayNums = new int[8];
while (step < ArrayNums.Length){
    ArrayNums[step] = rand.Next();
    step++;
}
Console.Write($"Числа в массиве:");
while (step > 0){
    Console.Write($" {ArrayNums[ArrayNums.Length - step]}");
    step--;
}