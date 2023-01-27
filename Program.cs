// Программа выбора значений из массива значений менее или равна 3 символам
// основная программа
int m = ReadData("Введите количество значений массива --->  ");
int count = 0;
string[] arrData = new string[m];
string[] arrRes = new string[m];
arrData = Read_Arr(m);
Search3sim(arrData, arrRes);
Print1DArr("Сгенерированный массив:", arrData);
if (count != 0)
{
    m = count;
    Print1DArr("Итоговый массив:", arrRes);
}
else
{
    Console.Write("Все значения массива имеют длину больше 3");
}


//методы
//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод ввода данных в массив
string[] Read_Arr(int m)
{ 
    for (int i = 0; i < m; i++)
    {
        Console.Write(" введите {0} значение из {1}  ---> ", i + 1, m);
        arrData[i] = Console.ReadLine() ?? "0";
    }
    return arrData;
}

// метод поиска в веденных значениях строк, длина которых меньше или равна 3 символам
void Search3sim(string [] arrData, string [] arrRes)
{
    for (int i = 0; i < arrData.Length; i++)
    {
        if(arrData[i].Length <= 3)
        {
            arrRes[count] = arrData[i];
            count++;
        }
    }
}

// метод формирования вывода массива
void PrintArr(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < m - 1; i++)
    {
        Console.Write ("'" + arr[i] + "', ");
    }
    Console.WriteLine("'" + arr[m - 1] + "']");
}

// метод вывода одномерного массива на экран
void Print1DArr(string msg, string[] arr)
{
    Console.WriteLine (msg);
    PrintArr(arr);
}
