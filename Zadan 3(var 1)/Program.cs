//Вариант первый, он будет просить ввести 8 чисел
string[] nums = {"первое", "второе", "третье", "четвёртое", "пятое", "шестое", "седьмое", "восьмое"};
int step = 0;
int[] ArrayNums = new int[8];
while (step < ArrayNums.Length){
    Console.WriteLine($"Введите {nums[step]} число: ");
    ArrayNums[step] = Convert.ToInt32(Console.ReadLine());
    step++;
}
Console.Write($"Числа в массиве:");
while (step > 0){
    Console.Write($" {ArrayNums[ArrayNums.Length-step]}");
    step--;
}