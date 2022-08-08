// Задача: Написать программу, которая из  имеющегося массива строк 
//формирует массив строк, длина которых меньше либо равна 3 символа.
//Первоночальный массив можно ввести  с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не  рекомендуетсяпользоваться 
//коллекциями. Лучше обойтись исключительно массивами.

// Примеры   :
//["Hello","2",":)",] ->["2",":)"]
//["1234","1567","-2","computer sience"]->["-2"]
//["Russia","Denmark","Kazan"]->[]

string[] FindElementsLessCharacters(string []word)
{
    for (int i=0;i<word.Length;i++)
    {
        int k=0;
        if (word[i].Length>3)
            k++;
            word[i]="0";
    }

    return word;
}

void Show2dArray(string []words)
{
     for(int i=0;i<words.Length;i++)
        {
            Console.Write(" "+words[i]+" ");
            Console.WriteLine();
        }
}