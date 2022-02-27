using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManualList : MonoBehaviour
{
    public Text text1;
    List<int> list1;
    List<int> list2;
    List<int> list3;
    int[] array = { 11, 22, 33 };
    void Start()
    {
        list3 = new List<int>(3);
        list3.Add(123);
        list3.Add(456);
        list3.Add(789);
        Sorting sort = new Sorting();

        // List<T>() - Создание пустого списка.
        list1 = new List<int>();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(5);
        list1.Add(4);


        // List<T>(IEnumerable<T>) - Создание списка на основе перечислителя.
        // list2 = new List<int>(array);

        // List<T>(Int32) - Создание списка с выделенной ёмкостью.
        // list1 = new List<int>(5);

        // List<T>.Capacity - Показывает текущую ёмкость списка.
        // text1.text += list1.Capacity + "\n";
        // list1.Capacity = 7;
        // text1.text += list1.Capacity + "\n";
        // list1.Clear();
        // text1.text += list1.Capacity + "\n";
        // list1.Add(1);
        // list1.Add(2);
        // list1.Add(3);
        // text1.text += list1.Capacity + "\n";
        // list1.TrimExcess();
        // text1.text += list1.Capacity + "\n";

        // List<T>.Count - Показывает количество элементов в списке.
        // text1.text += list1.Count + "\n";

        // List<T>.Item[Int32] - считывает и записывает элемент под индексом.
        // text1.text += list1[1] + "\n";
        // list1[1] = 6;
        // text1.text += list1[1] + "\n";

        // List<T>.Add(T) - Добавляет элемент в конец списка.
        // list1.Add(99);

        // List<T>.AddRange(IEnumerable<T>) - Добавить с список перечислитель.
        // list1.AddRange(list3);
        // list1.AddRange(array);
        // OutputValues(list1);

        // List<T>.AsReadOnly - Добавляет оболочку только для чтения.
        // IList<int> listReadOnly = list1.AsReadOnly();
        // list1.Add(45663463);
        // foreach (var item in listReadOnly)
        // {
        //     text1.text += item + "\n";
        // }
        // try
        // {
        //     listReadOnly[0] = 5;
        // }
        // catch
        // {
        //     text1.text += "Не удалось изменить элемент\n";
        // }

        // try
        // {
        //     listReadOnly.Add(5);
        // }
        // catch
        // {
        //     text1.text += "Не удалось добавить элемент\n";
        // }

        // List<T>.BinarySearch(T) - Поиск индекса с данным значением.
        // list1.Sort();
        // int index = list1.BinarySearch(5);
        // text1.text += index + "\n";

        // List<T>.BinarySearch(T, IComparer<T>) - Поиск индекса с данным значением с помощью компаратора.
        // int index = list1.BinarySearch(5, sort);
        // text1.text += index + "\n";
        // list1.Sort(sort);
        // OutputValues(list1);

        // List<T>.BinarySearch(Int32, Int32, T, IComparer<T>) - Поиск индекса с данным значением с помощью компаратора в нужном диапозоне.
        // list1.Sort(sort);
        // int index = list1.BinarySearch(0, 5, 1, sort);
        // text1.text += index + "\n";
        // OutputValues(list1);

        // List<T>.Clear - Удаление всех элементов из списка.
        // list1.Clear();

        // List<T>.Contains(T) - Определяет, есть ли элемент в списке.
        // bool match = list1.Contains(5);
        // text1.text += match + "\n";
        // match = list1.Contains(6);
        // text1.text += match + "\n";

        // List<T>.ConvertAll<TOutput>(Converter<T,TOutput>) - Преобразование элементов в списке из ордного типа в другой.
        // List<string> list4 = new List<string>();
        // list4 = list1.ConvertAll(new Converter<int, string>(IntToString));
        // foreach (var item in list4)
        // {
        //     text1.text += item.GetType() + "\n";
        // }

        // List<T>.CopyTo(T[]) - Копирование списка в массив.
        // int[] array2 = new int[5];
        // list1.CopyTo(array2);
        // foreach (var item in array2)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.CopyTo(T[], Int32) - Копирование списка в массив. На какой индекс в массиве.
        // Array.Resize(ref array, 10);
        // list1.CopyTo(array, 2);
        // foreach (var item in array)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.CopyTo(Int32, T[], Int32, Int32) - Копирование списка в массив. С какого индекса списка, на какой индекс в массиве и сколько элементов.
        // Array.Resize(ref array, 10);
        // list1.CopyTo(1, array, 5, 4);
        // foreach (var item in array)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.Object.Equals(Object). Equals(Object, Object)- Сравнение списков.
        // text1.text += list1.Equals(list3) + "\n";
        // text1.text += Equals(list1, list3) + "\n";
        // text1.text += Equals(list1, list1) + "\n";

        // List<T>.Exists(Predicate<T>) - Соотвествует ли один из элементов условию.
        // text1.text += list1.Exists(x => x == 2) + "\n";
        // text1.text += list1.Exists(x => x < 3) + "\n";
        // text1.text += list1.Exists(x => x == 6) + "\n";
        // text1.text += list1.Exists(x => x > 5) + "\n";

        // Example21(); // List<T>.Find(Predicate<T>) - Находит первый элемент который соответвует условию.
        // text1.text += list1.Find(x => x > 3) + "\n";

        // Example22(); // List<T>.FindAll(Predicate<T>) - Находит все элементы которые соответвуют условию и создаёт новый список.
        // List<int> list4 = list1.FindAll(x => x > 3);
        // foreach (var item in list4)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.FindIndex(Predicate<T>) - Поиск поиск первого индекса где элемент соответствует условию.
        // text1.text += list1.FindIndex(x => x > 2) + "\n";

        // List<T>.FindIndex(Int32, Predicate<T>) - Поиск поиск первого индекса где элемент соответствует условию, начиная поиск с определённог индекса.
        // text1.text += list1.FindIndex(3, x => x < 5) + "\n";

        // List<T>.FindIndex(Int32, Int32, Predicate<T>) - Поиск  первого индекса где элемент соответствует условию, начиная поиск с определённог индека и заканчивая поиск через определённое количество жэлементов.
        // text1.text += list1.FindIndex(0, 2, x => x > 3) + "\n";

        // List<T>.FindLast(Predicate<T>) - Поиск последнего элемента с данным значением.
        // text1.text += list1.FindLast(x => x > 2) + "\n";

        // List<T>.FindLastIndex(Predicate<T>) - Поиск последнего индекса где элемент соответствует условию.
        // text1.text += list1.FindLastIndex(x => x > 2) + "\n";

        // List<T>.FindLastIndex(Int32, Predicate<T>) - Поиск последнего индекса где элемент соответствует условию, заканчивая данным индексом.
        // text1.text += list1.FindLastIndex(3, x => x > 2) + "\n";

        // List<T>.FindLastIndex(Int32, Int32, Predicate<T>) - Поиск последнего индекса где элемент соответствует условию, указывая последний индекс и сколько последних элементов проверить.
        // text1.text += list1.FindLastIndex(1, 2, x => x > 0) + "\n";

        // List<T>.ForEach(Action<T>) - Перебор всех значений используя сторонний метод.
        // list1.ForEach(Print);
        // list1.ForEach(delegate (int value) { text1.text += value + "\n"; });

        // List<T>.GetEnumerator - Получение перечислителя.
        // List<int>.Enumerator em = list1.GetEnumerator();
        // while (em.MoveNext())
        // {
        //     int value = em.Current;
        //     text1.text += value + "\n";
        // }

        // List<T>.GetHashCode - Получение HashCode.
        // text1.text += list1.GetHashCode() + "\n";

        // List<T>.GetRange(Int32, Int32) - Скопирование части списка. От какого индекса и сколько элементов.
        // list3 = list1.GetRange(1, 3);
        // foreach (var item in list3)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.GetType - Получить тип.
        // text1.text += list1.GetType() + "\n";

        // List<T>.IndexOf(T) - Вывод первого индекса с данным значением.
        // var index = list1.IndexOf(4);
        // text1.text += index + "\n";
        // index = list1.IndexOf(6);
        // text1.text += index + "\n";

        // List<T>.IndexOf(T, Int32) - Вывод первого индекса с данным значением начиная с указанного индекса.
        // var index = list1.IndexOf(2, 0);
        // text1.text += index + "\n";
        // index = list1.IndexOf(2, 2);
        // text1.text += index + "\n";

        // List<T>.IndexOf(T, Int32, Int32) - Вывод первого индекса с данным значением начиная с указанного индекса.и сколько элементов проверить.
        // var index = list1.IndexOf(3, 0, 2);
        // text1.text += index + "\n";
        // index = list1.IndexOf(3, 0, 3);
        // text1.text += index + "\n";

        // List<T>.Insert(Int32, T) - Вставляет элемент на указанный индекс.
        // list1.Insert(1, 88);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.InsertRange(Int32, IEnumerable<T>) - Вставляет список на указанный индекс.
        // list1.InsertRange(1, list3);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // Example40(); // List<T>.LastIndexOf(T) - Вывод последнего индекса с указанным элементом.
        // text1.text += list1.LastIndexOf(4) + "\n";

        // Example41(); // List<T>.LastIndexOf(T, Int32) - Вывод последнего индекса с указанным элементом. Начиная с первого индекса до указанного.
        // text1.text += list1.LastIndexOf(5, 3) + "\n";

        // Example42(); // List<T>.LastIndexOf(T, Int32, Int32) - Вывод последнего индекса с указанным элементом. Заканчивая указанным индексом и сколько элементов.
        // text1.text += list1.LastIndexOf(2, 4, 3) + "\n";

        // List<T>.MemberwiseClone - Создаёт какую-то копию.
        // print(list1.MemberwiseClone());

        // List<T>.Remove(T) - Удаляет элемент соответствующий объекту.
        // bool bool1 = list1.Remove(4);
        // text1.text += bool1 + "\n";
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }
        // bool1 = list1.Remove(6);
        // text1.text += bool1 + "\n";

        // List<T>.RemoveAll(Predicate<T>) - Удаляет все элементы соответствующие условию.
        // list1.RemoveAll(Delete);
        // list1.RemoveAll(x => x > 3);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.RemoveAt(Int32) - Удаляет элемент под нужным индексом.
        // list1.RemoveAt(4);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.RemoveRange(Int32, Int32) - С какого индекса и сколько элементов удалить.
        // list1.RemoveRange(1, 3);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.Reverse() - Переворачивает списко.
        // list1.Reverse();
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.Reverse(Int32, Int32) - Переворачивает списко в диапозоне. От какого индекса и сколько элементов.
        // list1.Reverse(1, 3);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // Sort() - Сортировка по умолчанию.
        // list1.Sort();
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // Sort(Comparison<T>) - Сортирует список используя Comparison.
        // list1.Sort(delegate (int x, int y)
        // {
        //     if (x == y)
        //     {
        //         return 0;
        //     }
        //     else if (x < y)
        //     {
        //         return 1;
        //     }
        //     else
        //     {
        //         return -1;
        //     }
        // });
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // Sort(IComparer<T>) - Сортирует список используя IComparer.
        // list1.Sort(sort);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // Sort(Int32, Int32, IComparer<T>) - Сортирует список используя IComparer. От какого индекса и сколько элементов.
        // list1.Sort(1, 3, sort);
        // foreach (var item in list1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.ToArray() - Копирует список в массив.
        // int[] array1;
        // array1 = list1.ToArray();
        // foreach (var item in array1)
        // {
        //     text1.text += item + "\n";
        // }

        // List<T>.ToString() - Переводит название типа в строку.
        // text1.text += list1.ToString();

        // List<T>.TrimExcess() - Устанавливает ёмкость равный количеству эллементов.
        // text1.text += list1.Capacity + "\n";
        // list1.TrimExcess();
        // text1.text += list1.Capacity + "\n";

        // List<T>.TrueForAll(Predicate<T>) - Соотвествуют все компоненты условию?
        // text1.text += list1.TrueForAll(Delete) + "\n";
        // text1.text += list1.TrueForAll(x => x < 6) + "\n";
        
        // Example58(); // List<T>.ICollection.CopyTo(Array, Int32) - Копирование элементов в массив. Начиная с какого индекса в массиве.
        // Example59(); // List<T>.ICollection.IsSynchronized - Показывает, является ли доступ к коллекции ICollection синхронизированным (потокобезопасным).
        // Example60(); // List<T>.ICollection.SyncRoot - Получает объект, который можно использовать для синхронизации доступа к коллекции ICollection.
        // Example61(); // List<T>.ICollection<T>.IsReadOnly - Получает значение, показывающее, доступен ли ICollection <T> только для чтения.
        // Example62(); // List<T>.IEnumerable.GetEnumerator - Возвращает перечислитель, который выполняет итерацию по коллекции.
        // Example63(); // List<T>.IEnumerable<T>.GetEnumerator - Возвращает перечислитель, который перебирает коллекцию.
        // Example64(); // List<T>.IList.Add(Object) - Добавляет элемент в список IList.
        // Example65(); // List<T>.IList.Contains(Object) - Определяет, содержит ли IList определенное значение.
        // Example66(); // List<T>.IList.IndexOf(Object) - Определяет индекс определенного элемента в списке IList.
        // Example67(); // List<T>.IList.Insert(Int32, Object) - Вставляет элемент в список IList по указанному индексу.
        // Example68(); // List<T>.IList.IsFixedSize - Получает значение, показывающее, имеет ли IList фиксированный размер.
        // Example69(); // List<T>.IList.IsReadOnly - Получает значение, указывающее, доступен ли список IList только для чтения.
        // Example70(); // List<T>.IList.Item[Int32] - Получает или задает элемент по указанному индексу.
        // Example71(); // List<T>.IList.Remove(Object) - Удаляет первое вхождение определенного объекта из списка IList ..
    }
    void OutputValues(List<int> list)
    {
        text1.text += "Count - " + list.Count + "\n";
        for (int i = 0; i < list.Count; i++)
        {
            text1.text += i + " - " + list[i] + "\n";
        }
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
    string IntToString(int value)
    {
        return value.ToString();
    }
    void Print(int value)
    {
        text1.text += value + "\n";
    }
    bool Delete(int value)
    {
        return value > 3;
    }

    void Example58()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        ICollection iCollection = new List<int>(list1);
        int[] array1 = new int[10];
        iCollection.CopyTo(array1, 1);
        foreach (var item in array1)
        {
            text1.text += item + "\n";
        }
    }
    void Example59()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        ICollection iCollection = new List<int>(list1);
        text1.text += iCollection.IsSynchronized + "\n";
    }
    void Example60()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        ICollection iCollection = new List<int>(list1);
        var test = iCollection.SyncRoot;
        text1.text += iCollection.SyncRoot + "\n";
        text1.text += test + "\n";
    }
    void Example61()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        ICollection<int> iCollection = new List<int>(list1);
        text1.text += iCollection.IsReadOnly + "\n";
    }
    void Example62()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IEnumerable IEnumerable = new List<int>(list1);
        var test1 = IEnumerable.GetEnumerator();
        text1.text += test1 + "\n";
    }
    void Example63()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IEnumerable<int> IEnumerable = new List<int>(list1);
        var test1 = IEnumerable.GetEnumerator();
        text1.text += test1 + "\n";
    }
    void Example64()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        ilist.Add(77);
        foreach (var item in ilist)
        {
            text1.text += item + "\n";
        }
    }
    void Example65()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        ilist.Add(77);
        text1.text += ilist.Contains(77) + "\n";
    }
    void Example66()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        ilist.Add(77);
        text1.text += ilist.IndexOf(77) + "\n";
    }
    void Example67()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        ilist.Insert(2, 77);
        foreach (var item in ilist)
        {
            text1.text += item + "\n";
        }
    }
    void Example68()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        text1.text += ilist.IsFixedSize + "\n";
    }
    void Example69()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        text1.text += ilist.IsReadOnly + "\n";
    }
    void Example70()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        IList ilist = new List<int>(list1);
        text1.text += ilist[1] + "\n";
        ilist[1] = 77;
        text1.text += ilist[1] + "\n";
    }
    void Example71()
    {
        List<int> list1;
        list1 = new List<int>(6);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
        list1.Add(4);
        IList ilist = new List<int>(list1);
        ilist.Remove(4);
        foreach (var item in ilist)
        {
            text1.text += item + "\n";
        }
    }
    void Example72()
    {
        List<int> list1;
        list1 = new List<int>(5);
        list1.Add(1);
        list1.Add(4);
        list1.Add(2);
        list1.Add(5);
        list1.Add(3);
    }

}