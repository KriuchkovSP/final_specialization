# Урок 1. Итоги блока. Выбор специализации
## Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Текстовое описание решения

1. Объявляем переменную - размер входного массива;
2. Осуществляем ввод этой переменной;
3. Объявляем массив A[N];
4. Вызываем метод input(Array), отвечающий за пользовательский ввод массива;
5. Осуществляем ввод данных для заполнения массива;
6. Объявляем массив ResultArr[N], объявляем переменные i и j, необходимые для перебора массива;
7. Начинаем поэлементный перебор введенного массива, сравниваем значение переменной i с размером введенного массива А, переменная N;
8. Элемент массива A[i] проверяем на количество символов, если меньше или равно 3, записываем данный элемент в массив ResultArr[j], увеличиваем переменную j на 1. Если нет, пропускаем этот шаг и идем на шаг 9;
9. Увеличиваем переменную i на 1. И возвращаемся к пункту 7;
10. Выводим результирующий массив ResultArr от 0 элемента, до значения перменной j (ее не включаем). Переменная j, после перебора массива A[N], будет показывать количество элементов в итоговом массиве ResultArr.
