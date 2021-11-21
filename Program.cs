//
// Домашнее задание к занятию 6. Строки
//
// Задача 1. Ввести с клавиатуры предложение.
// Предложение представляет собой слова, разделенные пробелом.
// Знаки препинания не используются.
// Найти самое длинное слово в строке
//
Console.WriteLine();
// Вводим фразу с клавиатуры
string stringStart = Console.ReadLine();
Console.WriteLine();
// Разбиваем фразу на слова
string[] stingArray = stringStart.Split();
// Считаем количество слов в предложении
int sumWord = 0;
foreach (string s in stingArray)
{
        sumWord++;
}
Console.WriteLine("Количество слов в предложении равно {0}",sumWord);
// Создаем массив из длин слов и находим самое длинное слово
int[] arrayLength = new int [sumWord];
int max = 0;
foreach (string s in stingArray)
{
    int n = Convert.ToInt32(s.Length);
    if (n > max)
        max = n;
}
Console.WriteLine("Количество знаков в самом длинном слове равно {0}",max);
Console.WriteLine();
// Выводим саме длинные слова
Console.Write("Самое длинное слово: ");
int kolWord = 0;
foreach (string s in stingArray)
{
    int n = Convert.ToInt32(s.Length);
        if (n == max)
        {
          kolWord++;
          Console.Write("{0} ",s);
        }
}
Console.WriteLine();
// Завершение программы
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();