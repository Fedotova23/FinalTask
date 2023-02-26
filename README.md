# Работа с массивом строк.
## Поиск слов, состоящих из 1-3 символов в массиве строк.

Ниже приведен код программы для решения поставленной задачи на языке c#. 

## Основная часть программы:

```c#
string[] str = {"некоторый", "массив", "слов",  "где", "нужно", "выбрать", "слова", ",", "состоящие", "из",  "1-3",  "символов"};
int numOfShortWord = GetNumberOfShortElements(str);
System.Console.WriteLine($"кол-во слов, состоящих из 1-3 символов = {numOfShortWord}");
PrintStr(GetNewStringWithShortWords(str, numOfShortWord));
```

## Описание используемых методов:

### Метод, который возвращает количество слов, состоящих из 1-3 символов.

```

int GetNumberOfShortElements(string[] str)
{
    int number = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i].Length <= 3)
        {
            number++;
        }
    }
    return number;
}
```
### Метод, который возвращает новый массив строк.
```

string[] GetNewStringWithShortWords ( string[] str, int size)
{
    string[] shortStr = new string[size];

    int j = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            shortStr[j++] = str [i];
        }
    }
    return shortStr;
}
```
### Метод для вывода массива в консоль

```

void PrintStr (string[] str)
{
    for (int i = 0; i < numOfShortWord; i++)
    {
    System.Console.Write($"{str[i]} ");  
    }
}
```

