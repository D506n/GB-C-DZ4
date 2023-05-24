Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
double temp = Num;
int step = 0;
while(temp > 1){
    step = step + 1;
    temp = temp / 10;
}
int[] array = new int[step];
int StepArray = 0;
int digit = 0;
while (StepArray < step)
{
    digit = (step - 1) - StepArray;
    array[digit] = Num % 10;
    Num = Num / 10;
    StepArray++;
}
int Result = array[0];
temp = 1;
while (temp < step){
    Result = Result + array[(int)temp];
    temp++;
}
Console.WriteLine($"Сумма цифр в числе: {Result}");