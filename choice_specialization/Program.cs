// Создаем необходимые массивы

string[] startArray = { "main", "you", "'ll", "world", " IT", "!" };
string[] endArray = new string[startArray.Length];

// Создаем вспомогательные переменные

int count = startArray.Length;
int index = 0;
int lenEndArray = 0;

// Основной цикл перебора исходного массива

while (index < count)
{
    if (startArray[index].Length <= 3)
    {
        endArray[lenEndArray] = startArray[index];
        lenEndArray++;
        //Console.WriteLine(endArray[0]);
    }
    index++;
}

// Выводим в консоль результирующий массив

PrintArray(endArray);


////////////////////////////////////////////////////////
void PrintArray(string[] col) // метод печати массива в строчку все элементы
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(col[pos]);
        pos++;
    }
}
