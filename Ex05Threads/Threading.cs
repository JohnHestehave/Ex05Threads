
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex05Threads
{
	public static class Threading
	{
		public static void WriteToConsole()
		{
			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine("C# threads are easy!");
				Thread.Sleep(100);
			}
		}
		public static void WriteToConsole2()
		{
			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine("Also, with mmultiple threads...");
				Thread.Sleep(100);
			}
		}
		public static void Temperature()
		{
			int alarms = 0;
			while(alarms < 3)
			{
				Thread.Sleep(1000);
				Random rand = new Random();
				int num = rand.Next(-20, 120);
				Console.WriteLine("Temperature: "+ num);
				if(num < 0 || num > 100)
				{
					Console.WriteLine("ALARM");
					alarms++;
				}
			}
			Console.WriteLine("3 alarms reached. Aborting thread.");	
		}

		private static int counter;
		public static void CountUpTwo()
		{
			while (counter < 10000)
			{
				counter += 2;
				Console.WriteLine(counter);
				Thread.Sleep(1000);
			}
		}
		public static void CountDownOne()
		{
			while (counter < 10000 && counter > -10)
			{
				counter--;
				Console.WriteLine(counter);
				Thread.Sleep(1000);
			}
		}
		private static List<Char> summarizer = new List<char>();
		public static void Asterisks()
		{
			int count = 0;
			while(count < 6000)
			{
				count++;
				summarizer.Add('*');
				Redraw();
				Thread.Sleep(100);
			}
		}
		public static void Gates()
		{
			int count = 0;
			while (count < 6000)
			{
				count++;
				summarizer.Add('#');
				Redraw();
				Thread.Sleep(100);
			}
		}
		public static void Redraw()
		{
			lock (summarizer)
			{
				Console.Clear();//
				Console.WriteLine("Total: " + summarizer.Count + "\n");
				
				for(int i = 0; i < summarizer.Count; i++)
				{
					Console.Write(summarizer[i]);
				}
				
			}
		}
	}
}
