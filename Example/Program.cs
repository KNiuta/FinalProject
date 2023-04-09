
/// <summary>
/// Метод формерует строку из случайных букв заданной длинны 
/// </summary>
/// <param name="length"> длинна строки </param>
/// <returns>вывод рандомной стороки </returns>
string StringRand(int length)
{
              int randValue;
              string str = "";
              char letter;
              for (int i = 0; i < length; i++)
              {
                            randValue = new Random().Next(0, 26);
                            letter = Convert.ToChar(randValue + 65);
                            str = str + letter;
              }
              return str;
}

/// <summary>
/// Метод формирует элементы массива из  строк
/// </summary>
/// <param name="stringArray"> массив для котрого необходимо выполнить формирование элементов </param>
void ArrayStr(string[] stringArray)
{

              for (int i = 0; i < stringArray.Length; i++)
              {
                            stringArray[i] = StringRand(new Random().Next(1, 7));
              }
}

/// <summary>
/// Метод для вывода на печать массива строк 
/// </summary>
/// <param name="stringArray">массив для вывода</param>
void PrintArray(string[] stringArray)
{
              Console.Write("[");
              for (int i = 0; i < stringArray.Length-1; i++)
              {
                            Console.Write($"{stringArray[i]}, ");
              }
              Console.Write($"{stringArray[stringArray.Length-1]} ");
              Console.WriteLine("]");
}