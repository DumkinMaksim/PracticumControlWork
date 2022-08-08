// Задача: Написать программу, которая из  имеющегося массива строк 
//формирует массив строк, длина которых меньше либо равна 3 символа.
//Первоночальный массив можно ввести  с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не  рекомендуетсяпользоваться 
//коллекциями. Лучше обойтись исключительно массивами.

// Примеры   :
//["Hello","2",":)",] ->["2",":)"]
//["1234","1567","-2","computer sience"]->["-2"]
//["Russia","Denmark","Kazan"]->[]

string FindElementsLessCharacters(string []word)
{
    string []findword=new string [word.Length];
    for (int i=0;i<word.Length;i++)
    {
        for (int j=0;j<word.Length;j++)
        {
            if (word[i].Length<=3)
               findword[j]=word[i];
        }
        

    }

    return findword;
}

void Show2dArray(string []words)
{
     for(int i=0;i<words.GetLength(0);i++)
        {
            Console.Write(" "+words[i]+" ");
            Console.WriteLine();
        }
}