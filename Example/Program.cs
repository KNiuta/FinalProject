
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