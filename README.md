# 1. Условие задачи:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.<br>Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.<br> При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# 2. Описание алгоритма решения задачи:

**a.** Создаем void функцию с аргументом в виде строкового массива данных;

**b.** Внутри функции создаём новый пустой массив данных;

**c.** С помощью цикла проверяем длину (кол-во символов) каждого элемента исходного массива и, если кол-во символов не превышает 3, то добавляем этот элемент в новый пустой массив (array_new)

**d.** Вывод в консоль элементов массива array_new

**e.** Задаем исходный строковый массив

**f.** Исполняем созданную функцию
