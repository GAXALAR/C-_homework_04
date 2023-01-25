int Exponentiation(int num_a, int num_b)
{
  int result = 1;
  for(int i=1; i <= num_b; i++){
    result = result * num_a;
  }
    return result;
}
  Console.Write("Введите число A: ");
  int num_a = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int num_b = Convert.ToInt32(Console.ReadLine());
  int exponentiation = Exponentiation(num_a, num_b);
  Console.WriteLine("Ответ: " + exponentiation);
