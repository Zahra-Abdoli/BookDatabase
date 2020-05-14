using System;
using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;

namespace Book_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            books[] book = new books[100];
            while (true)
            {
                Console.WriteLine("welcome to the library \n what do you want to do(add,delete,display books,search,exit)");
                switch (Console.ReadLine().ToLower())
                {
                    case "add":
                       bool valid= Add(index, book);
                        if (valid) index++;
                        break;
                    case "delete":
                       bool delete= Delete(book,index);
                        if (delete) index--;
                        break;
                    case "display":
                        display(book,index);
                        break;
                    case "search":
                        search(book,index);
                        break;
                    case "exit":
                        break;
                }


            }
        }
        static bool Add(int Index, books[] book)
        {
            if (Index > 99)
            {
                Console.WriteLine("we do not have enought space");
                return false;
            }
            while (true)
            {
                Console.WriteLine("title :");
                string title = Console.ReadLine();
                if (title == null) { Console.WriteLine("please inter valid title"); continue; }
                Console.WriteLine("Author :");
                string author = Console.ReadLine();
                if (author == null) { Console.WriteLine("please inter valid author"); continue; }
                books Newbook = new books(title, author);
                book[Index] = Newbook;
                Console.WriteLine($"{Newbook.title}is added");
                return true;
            }
        }


        static bool Delete(books[] book,int index)
        {
            while (true)
            {
                Console.WriteLine("title  you want to be delete:");
                string item1 = Console.ReadLine();
                if (item1 is null)
                {
                    Console.WriteLine("please add valid name");
                    continue;

                }

                int Index1= 0;
                foreach (books item in book)
                {
                    string item2 = item.title;
                    if (item2 == item1)
                    {
                        if (Index1 == book.Length)
                        {
                            book[Index1] = null;
                        }
                        for (int i = Index1; i < index; i++)
                        {
                            book[i] = book[i + 1];
                        }
                        Console.WriteLine($"{item1} is deleted ");
                        return true;
                    }
                    else { }
                    Index1++;

                }
                Console.WriteLine("there is no book with this title");
                return false;

            }

        }
        static void display(books[] book,int index)
        {
            foreach (books item in book)
            {
                if (item != null)
                    Console.WriteLine(item.title, item.author);
            }
        }
        static void exit()
        {
            //CloseMainWindows

        }
        static void search(books[] book,int index)

        {
            while (true)
            {
                Console.WriteLine("title :");
                string item1 = Console.ReadLine();

                if (item1 == null)
                { Console.WriteLine("add valid title"); continue; }
                for (int i = 0; i <index;i++) {

                    string item2 = book[i].title;
                    if (item2 == item1)
                        Console.WriteLine(book[i].title, book[i].author);
                
                }
                
            }


        }
    }
}

