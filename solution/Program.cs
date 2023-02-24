

string[] str = {"некоторый", "массив", "слов",  "где", "нужно", "выбрать", "слова", ",", "состоящие", "из",  "1-3",  "символов"};
int numOfShortWord = GetNumberOfShortElements(str);
System.Console.WriteLine($"кол-во слов, состоящих из 1-3 символов = {numOfShortWord}");
PrintStr(GetNewStringWithShortWords(str, numOfShortWord));


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

void PrintStr (string[] str)
{
    for (int i = 0; i < numOfShortWord; i++)
    {
    System.Console.Write($"{str[i]} ");  
    }
}




