using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        undoStack.Push("Type A");
        undoStack.Push("Type B");
        undoStack.Push("Delete B");
        undoStack.Push("Type C");
        undoStack.Push("Paste D");

        Console.WriteLine("All Actions:");
        foreach (var action in undoStack)
            Console.WriteLine(action);

        Console.WriteLine("\nUndo Last 3 Actions:");

        for (int i = 0; i < 3; i++)
        {
            if (undoStack.Count > 0)
            {
                string action = undoStack.Pop();
                redoStack.Push(action);
                Console.WriteLine("Undo: " + action);
            }
        }

        Console.WriteLine("\nCurrent Top Action:");
        if (undoStack.Count > 0)
            Console.WriteLine(undoStack.Peek());
        else
            Console.WriteLine("No actions left");

        Console.WriteLine("\nRedo Last 2 Actions:");
        for (int i = 0; i < 2; i++)
        {
            if (redoStack.Count > 0)
            {
                string action = redoStack.Pop();
                undoStack.Push(action);
                Console.WriteLine("Redo: " + action);
            }
        }

        Console.WriteLine("\nFinal Undo Stack:");
        foreach (var action in undoStack)
            Console.WriteLine(action);
    }
}