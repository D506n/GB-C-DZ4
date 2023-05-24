Console.WriteLine("Введите число:");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень его нужно возвести?");
int NumB = Convert.ToInt32(Console.ReadLine());
int Temp = 1;
int Result = NumA;
while (Temp < NumB){
    Result = Result * NumA;
    Temp++;
}
Console.WriteLine($"Результат: {Result}");