//Вариант второй, он будет выводить заранее заданные числа
int step = 0;
int[] ArrayNums = {1, 2, 5, 7, 19, 6, 1, 33};
Console.Write($"Числа в массиве:");
while (step < ArrayNums.Length){
    Console.Write($" {ArrayNums[step]}");
    step++;
}