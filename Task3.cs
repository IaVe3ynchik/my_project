using System;

class Task3{
    Random random = new Random();
    int num = random.Next(101);
    public static int Calc(int a, int b){
        return a + b;
    }

    public static void Guess(int a){
        if(a == num){
            Console.WriteLine("Вы угадали!");
        }
        if(a > num){
            Console.WriteLine("Меньше!");
        }
        if(a < num){
            Console.WriteLine("Больше!");
        }
    }
}