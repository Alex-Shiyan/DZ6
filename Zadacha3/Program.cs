//
// Домашнее задание к занятию 6. Строки
//
// Задача 3. Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
// В строке может быть несколько фрагментов, заключённых в фигурные скобки.
// Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
//
Console.WriteLine();
//Вводим фразу с клавиатуры
//string stringS = Console.ReadLine();
// Задаем тестовую фразу
Console.WriteLine("Исходная фраза:");
Console.WriteLine();
string stringS = "Дана строка S. Из строки требуется удалить текст, {заключенный в фигурные скобки. {В строке может быть несколько фрагментов, заключённых в фигурные скобки.} Возможно {использование вложенных фигурных скобок}, необходимо,} чтобы программа это учитывала.";
Console.WriteLine(stringS);
// Определим длину фразы
int n = Convert.ToInt32(stringS.Length);
// Ищем номер самой левой скобки
int numberL = 0;
for (int i = 0; i < n; i++)
{
    if (stringS[i] == '{')
    {
        numberL = i;
        break;
    }
}
//Console.WriteLine("Номер самой левой скобки = {0}", numberL);
// Ищем номер самой правой скобки
int numberR = 0;
for (int i = 0; i < n; i++)
{
    if (stringS[i] == '}')
    {
        numberR = i;
    }
}
//Console.WriteLine("Номер самой правой скобки = {0}", numberR);
int deltaD = numberR - numberL;
//Console.WriteLine("Расстояние между символами рано {0}", deltaD);
stringS = stringS.Remove(numberL-1, deltaD+2);
Console.WriteLine();
Console.WriteLine("Итоговая фраза:  ");
Console.WriteLine();
Console.WriteLine(stringS);
Console.WriteLine();
Console.WriteLine();
// Завершение программы
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();