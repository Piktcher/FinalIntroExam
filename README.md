1. Условие задачи:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

2. Описание алгоритма решения задачи:

    а. В начале решения задаем исходный массив данных (array), заполенный строковыми значениями разной длины

    б. Задаем новый пустой массив (array_new), в который будут помещаться значения, удовлетворяющие условию

    в. С помощью цикла проверяем длину (кол-во символов) каждого элемента исходного массива и, если кол-во символов не превышает 3, то добавляем этот элемент в новый пустой массив (array_new)

    г. Вывод в консоль массива array_new
