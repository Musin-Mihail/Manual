using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualList : MonoBehaviour
{
    public Text text1;
    void Start()
    {
        // Example1(); // List<T>() - Создание пустого списка. 
        // Example2(); // List<T>(IEnumerable<T>) - Создание списка на основе перечислителя.
        // Example3(); // List<T>(Int32) - Создание списка с выделенной ёмкостью.
        // Example4(); // List<T>.Capacity - Показывает текущую ёмкость списка.
        // Example5(); // List<T>.Count - Показывает количество элементов в списке.
        // Example6(); // List<T>.Item[Int32] - считывает и записывает элемент под индексом.
        // Example7(); // List<T>.Add(T) - Добавляет элемент в конец списка.
        // Example8(); // List<T>.AddRange(IEnumerable<T>) - Добавить с список перечислитель.
        // Example9(); // List<T>.AsReadOnly - Добавляет облочку только для чтения.
        // Example10(); // List<T>.BinarySearch(T) - Поиск индекса с данным значением.
        // Example11(); // List<T>.BinarySearch(T, IComparer<T>) - Поиск индекса с данным значением с помощью компаратора.
        // Example12(); // List<T>.BinarySearch(Int32, Int32, T, IComparer<T>) - Поиск индекса с данным значением с помощью компаратора в нужном диапозоне.
        // Example13(); // List<T>.Clear - Удаление всех элементов из списка.
        // Example14(); // List<T>.Contains(T) - Определяет, есть ли элемент в списке.
        // Example15(); // List<T>.ConvertAll<TOutput>(Converter<T,TOutput>) - Преобразование элементов в списке из ордного типа в другой.
        // Example16(); // List<T>.CopyTo(T[]) - Копирование списка в массив.
        // Example17(); // List<T>.CopyTo(T[], Int32) - Копирование списка в массив. На какой индекс в массиве.
        // Example18(); // List<T>.CopyTo(Int32, T[], Int32, Int32) - Копирование списка в массив.С какого индекса списка, на какой индекс в массиве и сколько элементов.
        // Example19(); // List<T>.Object.Equals(Object). Equals(Object, Object)- Сравнение списков.
        // Example20(); // List<T>.Exists(Predicate<T>) - Соотвествует ли один из элементов условию.
        // Example21(); // List<T>.Find(Predicate<T>) - Находит первый элемент который соответвует условию.
        // Example22(); // List<T>.FindAll(Predicate<T>) - Находит все элементы которые соответвуют условию и создаёт новый список.
        // Example23(); // List<T>.FindIndex(Predicate<T>) - Поиск поиск первого индекса где элемент соответствует условию.
        // Example24(); // List<T>.FindIndex(Int32, Predicate<T>) - Поиск поиск первого индекса где элемент соответствует условию, начиная поиск с определённог индекса.
        // Example25(); // List<T>.FindIndex(Int32, Int32, Predicate<T>) - Поиск поиск первого индекса где элемент соответствует условию, начиная поиск с определённог индека и заканчивая поиск через определённое количество жэлементов.
        // Example26(); // List<T>.FindLast(Predicate<T>) - Поиск индекса с данным значением.
        // Example27(); // List<T>.FindLastIndex(Predicate<T>) - Поиск последнего индекса где элемент соответствует условию.
        // Example28(); // List<T>.FindLastIndex(Int32, Predicate<T>) - Поиск последнего индекса где элемент соответствует условию, заканчивая данным индексом.
        // Example29(); // List<T>.FindLastIndex(Int32, Int32, Predicate<T>) - Поиск последнего индекса где элемент соответствует условию, указывая последний индекс и сколько последних элементов проверить.
        // Example30(); // List<T>.ForEach(Action<T>) - Перебор всех значений используя сторонний метод.
        // Example31(); // List<T>.GetEnumerator - Получение перечислителя.
        // Example32(); // List<T>.GetHashCode - Получение HashCode.
        // Example33(); // List<T>.Contains(T) - Скопирование части списка. От какого индекса и сколько элементов.
        // Example34(); // List<T>.GetType - Получить тип.
        // Example35(); // List<T>.IndexOf(T) - Вывод первого индекса с данным значением.
        // Example36(); // List<T>.IndexOf(T, Int32) - Вывод первого индекса с данным значением начиная с указанного индекса.
        // Example37(); // List<T>.IndexOf(T, Int32, Int32) - Вывод первого индекса с данным значением начиная с указанного индекса.и сколько элементов проверить.
        // Example38(); // List<T>.Insert(Int32, T) - Вставляет элемент на указанный индекс.
        // Example39(); // List<T>.InsertRange(Int32, IEnumerable<T>) - Вставляет список на указанный индекс.
        // Example40(); // List<T>.LastIndexOf(T) - Вывод последнего индекса с указанным элементом.
        // Example41(); // List<T>.LastIndexOf(T, Int32) - Вывод последнего индекса с указанным элементом. Начиная с первого индекса до указанного.
        // Example42(); // List<T>.LastIndexOf(T, Int32, Int32) - Вывод последнего индекса с указанным элементом. Заканчивая указанным индексом и сколько элементов.
        //////////////// Example43(); // List<T>.MemberwiseClone - Создаёт какую-то копию.
        // Example44(); // List<T>.Remove(T) - Удаляет элемент соответствующий объекту.
        // Example45(); // List<T>.RemoveAll(Predicate<T>) - Удаляет все элементы соответствующие условию.
        // Example46(); // List<T>.RemoveAt(Int32) - Удаляет элемент под нужным индексом.
        // Example47(); // List<T>.RemoveRange(Int32, Int32) - С какого индекса и сколько элементов удалить.
        // Example48(); // List<T>.Reverse() - Переворачивает списко.
        // Example49(); // List<T>.Reverse(Int32, Int32) - Переворачивает списко в диапозоне. От какого индекса и сколько элементов.
        // Example50(); // Sort() - Сортировка по умолчанию.
        // Example51(); // Sort(Comparison<T>) - Сортирует список используя Comparison.
        // Example52(); // Sort(IComparer<T>) - Сортирует список используя IComparer.
        // Example53(); // Sort(Int32, Int32, IComparer<T>) - Сортирует список используя IComparer. От какого индекса и сколько элементов.
        // Example54(); // List<T>.ToArray - Копирует список в массив.
    }
    void Example1()
    {
        List<int> list1;
        list1 = new List<int>();
    }
    void Example2()
    {
        List<int> list1;
        list1 = new List<int>();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        foreach (var item in list1)
        {
            text1.text += item + " ";
        }
        text1.text += " - ";

        List<int> list2;
        list2 = new List<int>(list1);
        list2.Add(4);
        list2.Add(5);
        list2.Add(6);
        foreach (var item in list2)
        {
            text1.text += item + " ";
        }
        text1.text += "\n";

        // Создание списка с массивом
        int[] array = { 11, 22, 33 };
        foreach (var item in array)
        {
            text1.text += item + " ";
        }
        text1.text += " - ";

        List<int> list3;
        list3 = new List<int>(array);
        list3.Add(44);
        list3.Add(55);
        list3.Add(66);
        foreach (var item in list3)
        {
            text1.text += item + " ";
        }
    }
    void Example3()
    {
        // Если значений становиться больше текущей ёмкости, то ёмкость увеличивается в два раза.
        List<int> list1;
        list1 = new List<int>(6);
        text1.text += list1.Capacity + "\n";
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);
        list1.Add(6);
        list1.Add(7);
        list1.Add(8);
        list1.Add(9);
        text1.text += list1.Capacity + "\n";
    }
    void Example4()
    {
        //После очистки списка ёмкость не уменьшается.
        List<int> list1;
        list1 = new List<int>(9);
        text1.text += list1.Capacity + "\n";
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);
        list1.Add(6);
        list1.Add(7);
        list1.Add(8);
        list1.Add(9);
        text1.text += list1.Capacity + "\n";
        list1.Clear();
        text1.text += list1.Capacity + "\n";
    }
    void Example5()
    {
        List<int> list1;
        list1 = new List<int>(3);
        text1.text += list1.Count + "\n";
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.Count + "\n";
    }
    void Example6()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1[0] + "\n";
        list1[0] = 5;
        text1.text += list1[0] + "\n";
    }
    void Example7()
    {
        List<int> list1;
        list1 = new List<int>(4);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(46975);
        text1.text += list1[list1.Count - 1] + "\n";
    }
    void Example8()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        int[] array = { 4, 5, 6 };

        List<int> list2;
        list2 = new List<int>(9);
        list2.AddRange(list1);
        list2.AddRange(array);
        list2.Add(7);
        list2.Add(8);
        list2.Add(9);
        foreach (var item in list2)
        {
            text1.text += item + "\n";
        }
    }
    void Example9()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        IList<int> listReadOnly = list1.AsReadOnly();
        foreach (var item in listReadOnly)
        {
            text1.text += item + "\n";
        }

        try
        {
            listReadOnly[0] = 5;
        }
        catch (System.Exception)
        {
            text1.text += "Не удалось изменить элемент\n";
        }

        try
        {
            listReadOnly.Add(5);
        }
        catch (System.Exception)
        {
            text1.text += "Не удалось добавить элемент\n";
        }

        list1.Add(4);
        text1.text += listReadOnly[listReadOnly.Count - 1] + "\n";
    }
    void Example10()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Add(9);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += "------\n";
        int index = list1.BinarySearch(5);
        text1.text += index + "\n";
    }
    void Example11()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(5);
        list1.Add(9);
        list1.Add(3);
        Sorting sort = new Sorting();
        list1.Sort(sort);
        for (int i = 0; i < list1.Count - 1; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += "------\n";
        int index = list1.BinarySearch(5, sort);
        text1.text += index + "\n";
    }
    class Sorting : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x < y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
    void Example12()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(458);
        list1.Add(678);
        list1.Add(3);
        Sorting sort = new Sorting();
        list1.Sort(sort);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
        text1.text += "------\n";
        int index = list1.BinarySearch(0, 4, 2, sort);
        text1.text += index + "\n";
    }
    void Example13()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.Count + "\n";
        list1.Clear();
        text1.text += list1.Count + "\n";
    }
    void Example14()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.Contains(1) + "\n";
        text1.text += list1.Contains(5) + "\n";
    }
    void Example15()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        foreach (var item in list1)
        {
            text1.text += item + " - " + item.GetType() + "\n";
        }
        text1.text += "------\n";
        List<string> list2;
        list2 = new List<string>(3);
        list2 = list1.ConvertAll(new Converter<int, string>(IntToString));
        foreach (var item in list2)
        {
            text1.text += item + " - " + item.GetType() + "\n";
        }
    }
    string IntToString(int value)
    {
        return value.ToString();
    }
    void Example16()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        int[] array = new int[3];
        list1.CopyTo(array);
        foreach (var item in array)
        {
            text1.text += item + "\n";
        }
    }
    void Example17()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        int[] array = new int[15];
        list1.CopyTo(array, 5);
        foreach (var item in array)
        {
            text1.text += item + "\n";
        }
    }
    void Example18()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);
        int[] array = new int[15];
        list1.CopyTo(0, array, 5, 3);
        foreach (var item in array)
        {
            text1.text += item + "\n";
        }
    }
    void Example19()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        List<int> list2;
        list2 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.Equals(list2) + "\n";
        text1.text += Equals(list1, list2) + "\n";
        text1.text += Equals(list1, list1) + "\n";
    }
    void Example20()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.Exists(x => x == 2) + "\n";
        text1.text += "------\n";
        text1.text += list1.Exists(x => x > 3) + "\n";
    }
    void Example21()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.Find(x => x >= 2) + "\n";
    }
    void Example22()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        List<int> list2 = list1.FindAll(x => x >= 2);
        foreach (var item in list2)
        {
            text1.text += item + "\n";
        }
    }
    void Example23()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += list1.FindIndex(x => x >= 2) + "\n";
    }
    void Example24()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += list1.FindIndex(3, x => x >= 2) + "\n";
    }
    void Example25()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += list1.FindIndex(0, 4, x => x == 5) + "\n";
    }
    void Example26()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        text1.text += list1.FindLast(x => x >= 2) + "\n";
    }
    void Example27()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += list1.FindLastIndex(x => x >= 2) + "\n";
    }
    void Example28()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += list1.FindLastIndex(3, x => x >= 2) + "\n";
    }
    void Example29()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        for (int i = 0; i < list1.Count; i++)
        {
            text1.text += i + " - " + list1[i] + "\n";
        }
        text1.text += list1.FindLastIndex(1, 2, x => x > 0) + "\n";
    }
    void Example30()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        list1.ForEach(Print);
        list1.ForEach(delegate (int value) { text1.text += value + "\n"; });
    }
    void Print(int value)
    {
        text1.text += value + "\n";
    }
    void Example31()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        List<int>.Enumerator em = list1.GetEnumerator();
        while (em.MoveNext())
        {
            int value = em.Current;
            text1.text += value + "\n";
        }
    }
    void Example32()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        text1.text += list1.GetHashCode() + "\n";
    }
    void Example33()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        List<int> list2;
        list2 = new List<int>(3);
        list2 = list1.GetRange(1, 3);
        foreach (var item in list2)
        {
            text1.text += item + "\n";
        }
    }
    void Example34()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        text1.text += list1.GetType() + "\n";
    }
    void Example35()
    {
        List<int> list1;
        list1 = new List<int>(3);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        var index = list1.IndexOf(4);
        text1.text += index + "\n";
    }
    void Example36()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        var index = list1.IndexOf(3, 2);
        text1.text += index + "\n";
    }
    void Example37()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        var index = list1.IndexOf(5, 2, 2);
        text1.text += index + "\n";
    }
    void Example38()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Insert(1, 6);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example39()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        List<int> list2;
        list2 = new List<int>(3);
        list2.Add(6);
        list2.Add(7);
        list2.Add(8);
        list1.InsertRange(1, list2);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example40()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        text1.text += list1.LastIndexOf(4) + "\n";
    }
    void Example41()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        text1.text += list1.LastIndexOf(5, 3) + "\n";
    }
    void Example42()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        text1.text += list1.LastIndexOf(2, 4, 3) + "\n";
    }
    void Example43()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        // print(list1.MemberwiseClone());

        print(this.MemberwiseClone());
    }
    void Example44()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        bool bool1 = list1.Remove(4);
        text1.text += bool1 + "\n";
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
        bool1 = list1.Remove(6);
        text1.text += bool1 + "\n";
    }
    void Example45()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        // list1.RemoveAll(x => x > 3);
        list1.RemoveAll(Delete);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    bool Delete(int value)
    {
        return value > 3;
    }
    void Example46()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.RemoveAt(1);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example47()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.RemoveRange(1, 3);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example48()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Reverse();
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example49()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Reverse(1, 3);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example50()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Sort();
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example51()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Sort(delegate (int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x > y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        });
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example52()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        Sorting sort = new Sorting();
        list1.Sort(sort);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example53()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        Sorting sort = new Sorting();
        list1.Sort(1, 3, sort);
        foreach (var item in list1)
        {
            text1.text += item + "\n";
        }
    }
    void Example54()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        int[] array1;
        array1 = list1.ToArray();
        foreach (var item in array1)
        {
            text1.text += item + "\n";
        }
    }


    // text1.text += "------\n";
    // text1.text += item + "\n";
    // for (int i = 0; i < list1.Count; i++)
    // {
    //     text1.text += i + " - " + list1[i] + "\n";
    // }
}