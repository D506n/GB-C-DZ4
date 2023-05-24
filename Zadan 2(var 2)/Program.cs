Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
double temp = 0;
int step = Num;
int result = 0;
while (step > 0) {
    temp = step%10;
    result = (int)(result + temp);
    step = step/10;
}
Console.WriteLine($"Сумма цифр: {result}");