// Задача: Написать программу, которая из  имеющегося массива строк 
//формирует массив строк, длина которых меньше либо равна 3 символа.
//Первоночальный массив можно ввести  с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не  рекомендуетсяпользоваться 
//коллекциями. Лучше обойтись исключительно массивами.

// Примеры   :
//["Hello","2",":)"] ->["2",":)"]
//["1234","1567","-2","computer sience"]->["-2"]
//["Russia","Denmark","Kazan"]->[]

string[] FindElementsLessCharacters(string []word)
{
     string [] find=new string [word.Length];
    for (int i=0;i<word.Length;i++)
    {
       
        if (word[i].Length<=3)
           
            find[i]=word[i];
    }

    return find;
}

void ShowArray(string []words)
{
     for(int i=0;i<words.Length;i++)
        {
            Console.Write(" "+words[i]+" ");
            
        }
        Console.WriteLine();
}
string [] elemets={"Welcome","Bay","I",";)","-2","In","Hello","Russia"};
Console.WriteLine("Массив состоит из элементов");
ShowArray(elemets);
Console.WriteLine();
Console.WriteLine("Элементы которые меньше  либо равны трем символам исходного массива ");
ShowArray(FindElementsLessCharacters(elemets));
