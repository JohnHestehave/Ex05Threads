using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex05Threads
{
	class Program
	{
		static void Main(string[] args)
		{
			Ex6();
			Console.ReadKey();
		}

		public static void Ex2_3()
		{
			Thread thread = new Thread(new ThreadStart(Threading.WriteToConsole));
			Thread thread2 = new Thread(new ThreadStart(Threading.WriteToConsole2));
			thread.Start();
			thread2.Start();
		}
		public static void Ex4()
		{
			Thread thread3 = new Thread(new ThreadStart(Threading.Temperature));
			thread3.Start();
			int timer = 0;
			while (thread3.IsAlive)
			{
				Thread.Sleep(100);
				timer += 100;
				if (timer >= 10000)
				{
					thread3.Abort();
					Console.WriteLine("Temperature thread aborted after 10 seconds.");
				}
			}
		}
		public static void Ex5()
		{
			Thread thread1 = new Thread(new ThreadStart(Threading.CountUpTwo));
			Thread thread2 = new Thread(new ThreadStart(Threading.CountDownOne));
			thread1.Start();
			thread2.Start();
		}
		public static void Ex6()
		{
			Thread thread1 = new Thread(new ThreadStart(Threading.Asterisks));
			Thread thread2 = new Thread(new ThreadStart(Threading.Gates));
			thread1.Start();
			thread2.Start();
		}
	}
}
