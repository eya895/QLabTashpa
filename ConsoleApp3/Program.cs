﻿namespace QLab;
public class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Queue<int> q = new Queue<int>();
        q.Insert(7);
        q.Insert(10);
        q.Insert(3);
        Console.WriteLine(q);
        Queue<int> qCopy = SetQCopy(q);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);
        q.Insert(17);
        qCopy.Insert(13);
        Console.WriteLine(q);
        Console.WriteLine(qCopy);
    }

    public static Queue<int> SetQCopy(Queue<int> q)
    {
        Queue<int> qCopy = new();
        Queue<int> qTemp = new();
        int currItem;
        //פריקת התור המקורי ויצירת תור העתק ותור זמני
        while (!q.IsEmpty())
        {
            currItem = q.Remove();
            qTemp.Insert(currItem);
            qCopy.Insert(currItem);
        }
        //שחזור התור המקורי
        while (!qTemp.IsEmpty())
        {
            q.Insert(qTemp.Remove());
        }
        return qCopy;
    }
public static bool CheckQNum(Queue<int> q, int num)
{
    Queue<int> qCopy = SetQCopy(q);
    bool inQ = false;
    while(!qCopy.IsEmpty())
    {
        if (qCopy.Remove() == num)
            inQ = true;
    }
    return inQ;
}

public static bool ChekPlaceQSum(Queue<int> q, int place)
{
    Queue<int> qCopy = SetQCopy(q);
    bool QSum;
    if (place == 1)
    QSum = false;
    while(!qCopy.IsEmpty())
    {
        if(

    }
}
}
