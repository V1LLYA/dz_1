//*** Задание 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. ***//
// Console.WriteLine("Напишите число, чтобы сравнить его со следующим числом: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Напишите число, чтобы сравнить его с предыдущим числом: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2){
//     Console.WriteLine($"Число {num1} больше, чем {num2}");
// } else if(num1 < num2){
//     Console.WriteLine($"Число {num2} больше, чем {num1}");
// } else{
//     Console.WriteLine("Числа одинаковые");
// }




//*** Задание 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. ***//
// Console.WriteLine("Напишите одно из трёх чисел, чтобы узнать какое из них больше: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Напишите одно из трёх чисел, чтобы узнать какое из них больше: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Напишите одно из трёх чисел, чтобы узнать какое из них больше: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 & num1 > num3){
//     Console.WriteLine($"Число {num1} больше, чем {num2} и {num3}");
// } else if(num2 > num1 & num2 > num3){
//     Console.WriteLine($"Число {num2} больше, чем {num1} и {num3}");
// } else if(num3 > num1 & num3 > num2){
//     Console.WriteLine($"Число {num3} больше, чем {num1} и {num2}");
// } else{
//     Console.WriteLine("Числа равны между собой");
// }




//*** Задание 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). ***//
// Console.WriteLine("Напишите число для проверки на четность: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0){
//     Console.WriteLine($"Число {num} является четным");
// } else{
//     Console.WriteLine($"Число {num} является нечетным");
// }




//*** Задание 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. ***//
// Console.WriteLine("Напишите число N, чтобы отобразить все числа от 1 до N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int start = 1;

// while(start != num + 1){
//     Console.Write(start);
//     start++;
// }