	Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При выполнении задания пользоваться не коллекциями, а массивами.

Описание алгоритма программы:
1.	Запрашиваем у пользователя длину вводимого массива с применением метода ввода данных.
2.	Проверяем введенное значение на корректность ввода:
	- в случае если введенное значение больше нуля, то считается, что значение введено корректно и выполнение программы продолжается.
	- в других случаях на экран выводится строка «Неверно задана длина массива» и программа повторно переходит к запросу длины массива.
3.	Далее задаются исходные переменные, а именно:
	- массив arrData строчного типа (string) с заданной пользователем длиной (m);
	- массив arrRes строчного типа (string) аналогичной длины;
	- вводим переменную целочисленного типа count и присваиваем этой переменной значение 0.
4.	С помощью метода ввода данных в массив предлагаем пользователю ввести в каждую ячейку массива данные.
5.	С помощью метода вывода одномерного массива на экран и метода формирования вывода массива отображаем на экране Сгенерированный массив (arrData).
6.	В целях решения поставленной задачи применяем вновь разработанный метод поиска в веденных значениях строк, длина которых меньше или равна 3 символам Search3sim().
Суть метода состоит в следующем:
	- а) формируем цикл от 1 до M;
	- б) проверяем длину введенных данных в ячейку массива arrData[i]:
		- если длина больше 3, то продолжаем цикл;
		- если длина равна или меньше 3, то увеличиваем значение count на единицу и в ячейку массива arrRes[count] кладем значение arrData[i].
7.	После завершения работы метода Search3sim() проверяем значение count:
	- если значение count равно нулю, то выводим на экран строку следующего содержания - "Все значения массива имеют длину больше 3";
	- если значение count больше нуля, то с присваиваем переменной m значение переменной count и с применением метода вывода одномерного массива на экран и метода формирования вывода массива отображаем на экране Итоговый массив строк, длина которых меньше либо равна 3 символам (arrRes).
8.	Завершаем работу программы.

Общая блок-схема алгоритма представлена:
1.	В формате draw.io Diagrams - Itog_alg.drawio.
2.	В графическом формате - Itog_alg.jpg.
3.	Файл программы на языке C# - Program.cs.
