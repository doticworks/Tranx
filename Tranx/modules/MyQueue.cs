/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 15:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Tranx.modules
{
	/// <summary>
	/// Description of Bqueue.
	/// </summary>
	public class Bstrqueue
	{
		Queue<string> queue=new Queue<string>();
		public string Dequeue()
		{
			while(true)
			{
				
				try {return queue.Dequeue();} catch (Exception) {}
				Thread.Sleep(200);
			}
		}
		public string DequeueX()
		{
			while(true)
			{
				Thread.Sleep(50);
				try {return queue.Dequeue();} catch (Exception) {return null;}
				Thread.Sleep(200);
			}
		}
		public void Enqueue(string arg)
		{
			queue.Enqueue(arg);
		}
	}
	public class Bsocqueue
	{
		Queue<System.Net.Sockets.Socket> queue=new Queue<System.Net.Sockets.Socket>();
		public System.Net.Sockets.Socket Dequeue()
		{
			while(true)
			{
				
				try {return queue.Dequeue();} catch (Exception) {}
				Thread.Sleep(200);
			}
		}
		public System.Net.Sockets.Socket DequeueX()
		{
			while(true)
			{
				Thread.Sleep(50);
				try {return queue.Dequeue();} catch (Exception) {return null;}
				Thread.Sleep(200);
			}
		}
		public void Enqueue(System.Net.Sockets.Socket arg)
		{
			queue.Enqueue(arg);
		}
	}
	public class Bufqueue
	{
		
		
	}
}
