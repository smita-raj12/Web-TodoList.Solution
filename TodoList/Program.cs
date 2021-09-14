using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
   public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}






/*using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList
{
  public class Program
  {
    public static List<string> items = new List<string> {};

    public static void Main()
    {
      Console.WriteLine ("Welcome to the To Do List");
      Console.WriteLine("----------------------------");
      Console.WriteLine ("Would you like to add an item to your list or view your list?(Add/View)");
      string UsrerOutput = Console.ReadLine();
      if(UsrerOutput == "Add")
      {
        Console.WriteLine("Please enter the description for the new item");
        string userItem = Console.ReadLine();
        items.Add(userItem);
        Main();
      }
      else if(UsrerOutput == "View")
      {
        foreach(string i in items)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}      
*/