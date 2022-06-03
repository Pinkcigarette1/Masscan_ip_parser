using System;
using System.IO;

namespace ConsoleApp1
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static void Main(string[] args)
		{
			if (File.Exists("Parsed-IP.txt"))
			{
				File.Delete("Parsed-IP.txt");
			}
			StreamWriter streamWriter = new StreamWriter("Parsed-IP.txt");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Coded by pinkcigarette");

            Console.WriteLine("Enter IPs Path");
			string[] array = File.ReadAllLines(Console.ReadLine());
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new char[0]);
				try
				{
					streamWriter.WriteLine(array2[3] + ":" + array2[2]);
				}
				catch
				{
				}
			}
		}
	}
}
