//3.Написати програму, яка обчислює кількість знаків пунктуації у файлі.
//Вміст текстового файлу заноситься до масиву символів.
//Кількість знаків пунктуації визначається проходом по масиву.
//Передбачити метод, вхідний параметр якого є масив символів.
//Метод обчислює кількість знаків пунктуації. Завдання також виконати за допомогою колекції List<T>.

//How can I check if dark mode is enabled in Android Q with Flutter?
//I know how to set the dark mode, but I didn't find a way to check the background theme.
//Here is the code to set the dark theme.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Lab4
{
  public   void execute()
    {
        // Введіть шлях до файлу
        string filePath = "/Users/edwardian/Downloads/oop_main/oops/text.txt";

        // Зчитуємо вміст файлу до масиву символів
        char[] content = File.ReadAllText(filePath).ToCharArray();


        // Обчислюємо кількість знаків пунктуації
        int punctuationCount = CountPunctuation(content);

        Console.WriteLine($"Кількість знаків пунктуації у файлі: {punctuationCount}");
    }

    static int CountPunctuation(IEnumerable<char> characters)
    {
        // Створюємо список, щоб зберігати знаки пунктуації
        List<char> punctuation = new List<char>() { '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}' };

        // Обчислюємо кількість знаків пунктуації в масиві символів
        int count = 0;
        foreach (char c in characters)
        {
            if (punctuation.Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}
