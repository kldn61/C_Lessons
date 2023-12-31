﻿// У нас есть массив {array}, в котором n элементов. 
// Найти элемент, совпадающий с некоторым значением, который определяет пользователь.
// 1. Сохраним его в переменную find. Затем установим счётчик в нулевую позицию.
// 2. Если на текущей позиции элемент совпал с find, операцию можно завершить, потому что мы нашли позицию.
// 3. Если элемент не совпал с find, увеличиваем значение счётчика index на 1 и переходим на предыдущий шаг.
// 4. Сравниваем снова. И если элемент совпал с find, значит, алгоритм закончил работу.
// 5. Если элемент совпал с find, снова увеличиваем индекс. Смотрим результат.
// 6. В результате если элемент находится, операция завершается успешно. 
//    А если этого элемента так и нет, надо сообщить об этом.

//   index  =  0   1   2   3   4   5   6   7   8
int[] array = {5, 97, 12, 25, 27, 5, 42, 45, 77, 32};
int n = array.Length;
int find = 5;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                // Этот оператор принудительно останавливает цикл
    }
    index++;
}

