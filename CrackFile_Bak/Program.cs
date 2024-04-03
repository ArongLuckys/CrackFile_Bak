using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackFile_Bak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.ARONGFILE", SearchOption.AllDirectories);
				Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
				Console.WriteLine("读取当前的文件数量为" + files.Length + "个，分别是");
				if (files.Length != 0)
				{
					for (int i = 0; i < files.Length; i++)
					{
						try
						{
							File.Copy(files[i], files[i].Replace(".ARONGFILE", ""), true);
							File.Delete(files[i]);
							Console.WriteLine(files.Length + "\\" + i  + "  还原完成  ->  " + files[i]);
						}
						catch
						{
							Console.WriteLine("程序还原遇到错误，错误文件为   ->  " + files[i]);
							Console.WriteLine("键入回车继续。。。");
							Console.ReadKey();
						}
					}
				}
			}
			catch
			{
				Console.WriteLine("程序还原遇到错误，已终止");
				Console.ReadKey();
			}
		}
	}
}
