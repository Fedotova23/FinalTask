

string[] str = {"некоторый", "массив", "слов",  "где", "нужно", "выбрать", "слова", ",", "состоящие", "из",  "1-3",  "символов"};

System.Console.WriteLine($"кол-во слов, состоящих из 1-3 символов = {GetNumberOfShortElements(str)}");


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


