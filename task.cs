Console.Write("Введите размер массива(количество вводимых Вами слов/цифр и прочее: ");
int len = Convert.ToInt32(Console.ReadLine());

void FillArray(string[] array) {
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write("Введите строку #{0}: ", i + 1);
      array[i] = Console.ReadLine();
   }
}

void PrintArray(string[] array) {
   Console.Write("[ ");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"'{array[i]}' ");
   }
   Console.Write("] -> ");
}

void FindStringsWithThreeChars(string[] array) {
   string[] result = new string[len];
   Console.Write("[ ");
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= 3) {
         result[i] = array[i];
         Console.Write($"'{result[i]}' ");
      }
   }
   Console.Write("]");
}

string[] array = new string[len];
FillArray(array);
Console.WriteLine();
PrintArray(array);
FindStringsWithThreeChars(array);