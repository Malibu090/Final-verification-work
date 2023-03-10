# **Итоговая проверочная работа**
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

### Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
4. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

***Примеры:***
>["hello", "2", "world", ":-)"] -> ["2", ":-)"]

>["1234", "1567", "-2", "computer science"] -> ["-2"]

>["Russia", "Denmark", "Kazan"] -> []

## **Описание решения**
1. Зададим вручную массив строк ***arr***  
2. Зададим переменную ***sizeArrayOutput***, которая будет размером нового массива
3. С помощью цикла и условия вычислим переменную ***sizeArrayOutput***
### **Метод void ***FillAndOutputArrayString*****
1. Принимает на вход массив ***arr***
1. Задаем новый массив ***arrayOutput*** размером [***sizeArrayOutput***]
1. Зададим пременную ***count***, которая будет индексом для нового массива
1. С помощью цикла и условия заполним массив ***arrayOutput*** строками, которые меньше или равны трём из массива ***arr*** 
1. Выведем начальный массив ***arr*** и сформированный из него ***arrayOutput***