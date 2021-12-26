using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
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
        // Example10(); // BinarySearch(T) - Поиск индекса с данным значением.
        // Example11(); // BinarySearch(T, IComparer<T>) - Поиск индекса с данным значением с помощью компаратора.
        // Example12(); // BinarySearch(Int32, Int32, T, IComparer<T>) - Поиск индекса с данным значением с помощью компаратора в нужном диапозоне.
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
        list1.Add(458);
        list1.Add(3);
        int index = list1.BinarySearch(458);
        print(index);
    }
    public class Sorting : IComparer<int>
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
    void Example11()
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
        int index = list1.BinarySearch(458, sort);
        text1.text += index + "\n";
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
    
}