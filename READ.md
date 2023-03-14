# Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## Description of the solution algorithm:
First, two arrays are declared: the initial one and the second one of the same length. Then a method in which the loop is one length of the array, inside the loop checking the condition ( <=3 ), if yes, the element of the first array is entered in the count element of the second array. The count variable to alternately throw from the first array to the second. After the assignment, the count variable is increased by 1 and returns to the for loop in which i is increased by 1. And so it is checked to the end.