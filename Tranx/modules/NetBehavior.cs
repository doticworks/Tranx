/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 9:49
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Net;
using System.Net.Sockets;
using Tranx;
using System.Threading;
using System.Text;
using System.Diagnostics;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
namespace Tranx.modules
{
	/// <summary>
	/// Description of NetBehavior.
	/// </summary>
	public class NetBehavior
	{
		public static System.Net.Sockets.Socket ServerTest(IPEndPoint ipep)
		{
			try{
				Socket server= new System.Net.Sockets.Socket(AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, ProtocolType.Tcp);
				server.Bind(ipep);
				return server;
			}catch(Exception){
				return null;
			}
		}
		
		public static void ServerLauncher(ProgramData prog,System.Net.Sockets.Socket server)
		{
			//启动必要的线程，并留下while处理后续接入的客户端
			try{
			Thread ServerListenth=new Thread(()=>ServerListen(prog,server));
			Thread ServerChaterTranth=new Thread(()=>ServerChaterTran(prog,prog.chating));
			Thread ServerChaterOUTth=new Thread(()=>ServerChaterOUT(prog,server));
			Thread ServerHeartth=new Thread(()=>ServerHeart(prog));
			ServerListenth.IsBackground=true;
			ServerChaterTranth.IsBackground=true;
			ServerChaterOUTth.IsBackground=true;
			ServerChaterOUTth.IsBackground=true;
			ServerHeartth.SetApartmentState(ApartmentState.STA);
			ServerChaterTranth.SetApartmentState(ApartmentState.STA);
			ServerChaterOUTth.SetApartmentState(ApartmentState.STA);
			ServerHeartth.SetApartmentState(ApartmentState.STA);
			ServerListenth.Start();
			ServerChaterTranth.Start();
			ServerChaterOUTth.Start();
			ServerHeartth.Start();
			while(true)
			{
				System.Net.Sockets.Socket chatx=prog.watchating.Dequeue();
				prog.msgIN.Enqueue("[SERVER]:IP"+chatx.RemoteEndPoint.ToString()+" Connected");
				Sound.play();
				prog.chating.Add(chatx);
				Thread ChaterINth=new Thread(()=>ChaterIN(prog,chatx,true));
				ChaterINth.IsBackground=true;
				ChaterINth.SetApartmentState(ApartmentState.STA);
				ChaterINth.Start();
			}
			}catch(Exception e){ExceptionClass.ExceptReporter(e);}
		}
		public static void ClientLauncher(ProgramData prog,IPEndPoint ipep)
		{
			try{
			System.Net.Sockets.Socket client= new System.Net.Sockets.Socket(AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, ProtocolType.Tcp);
			client.Connect(ipep);
			//启动必要的线程
			Thread ChaterINth=new Thread(()=>ChaterIN(prog,client,false));
			Thread ClientChaterTranth=new Thread(()=>ClientChaterTran(prog));
			Thread ClientChaterOUTth=new Thread(()=>ClientChaterOUT(prog,client));
			ChaterINth.IsBackground=true;
			ClientChaterTranth.IsBackground=true;
			ClientChaterOUTth.IsBackground=true;
			ChaterINth.SetApartmentState(ApartmentState.STA);
			ClientChaterTranth.SetApartmentState(ApartmentState.STA);
			ClientChaterOUTth.SetApartmentState(ApartmentState.STA);
			ChaterINth.Start();
			ClientChaterTranth.Start();
			ClientChaterOUTth.Start();
			}catch(Exception e){ExceptionClass.ExceptReporter(e);}
		}
		
		#region NetBehavior Background
		/// <summary>
		/// 服务端发送心跳包
		/// </summary>
		static void ServerHeart(ProgramData prog)
		{try{
			while(true)
			{
				Thread.Sleep(500);
				prog.msgIN.Enqueue("heart");
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		/// <summary>
		/// 服务端等待客户端接入
		/// </summary>
		static void ServerListen(ProgramData prog,System.Net.Sockets.Socket server)
		{try{
			while(true)
			{
				server.Listen(10);
				prog.watchating.Enqueue(server.Accept());
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		/// <summary>
		/// 服务端或客户端接收到的消息，存入msgIN
		/// </summary>
		static void ChaterIN(ProgramData prog,System.Net.Sockets.Socket chat,bool isserver)
		{try{
			byte[] buffer=new byte[1024*1024];
			int n=1;
			while(true)
			{	
				try{
					n = chat.Receive(buffer);}catch(Exception){
					if(!isserver){
						prog.msgSHOW.Enqueue("[WARNING]:Server Disconnected");}
					return;
				}
				string str=Encoding.UTF8.GetString(buffer, 0, n);
				if(str!=String.Empty&&str!="heart")
				{
					prog.msgIN.Enqueue(str);	
				}
			
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		/// <summary>
		/// 服务端转发消息并转存入msgSHOW
		/// </summary>
		static void ServerChaterTran(ProgramData prog,List<System.Net.Sockets.Socket> chats)
		{try{
			byte[] buffer=new byte[1024*1024];
			int n=1;
			while(true)
			{	
				string str= prog.msgIN.Dequeue();
				prog.msgSHOW.Enqueue(str);
				try{buffer=Encoding.UTF8.GetBytes(str);}catch(Exception){continue;}
				
				foreach(System.Net.Sockets.Socket item in chats)
				{
					try{
						item.Send(buffer);}catch(Exception){
						
						chats.Remove(item);
						
						prog.msgIN.Enqueue("[SERVER]:IP"+item.RemoteEndPoint.ToString()+" DisConnected");
						Sound.play();
						break;
					}
					
					}
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		/// <summary>
		/// 客户端将接收到的消息转存入msgSHOW
		/// </summary>
		static void ClientChaterTran(ProgramData prog)
		{try{
			while(true)
			{	
				string str= prog.msgIN.Dequeue();
				prog.msgSHOW.Enqueue(str);
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		/// <summary>
		/// 客户端发送自己的消息
		/// </summary>
		static void ClientChaterOUT(ProgramData prog,System.Net.Sockets.Socket chat)
		{try{
			byte[] buffer=new byte[1024*1024];
			int n=1;
			while(true)
			{	
				string str="["+chat.LocalEndPoint+"]: "+ prog.msgOUT.Dequeue();
				buffer=Encoding.UTF8.GetBytes(str);
				chat.Send(buffer);
				
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		/// <summary>
		/// 服务端发送自己的消息
		/// </summary>
		static void ServerChaterOUT(ProgramData prog,System.Net.Sockets.Socket chat)
		{try{
			
			while(true)
			{	
				string str="["+chat.LocalEndPoint+"]: "+ prog.msgOUT.Dequeue();
				prog.msgIN.Enqueue(str);
				
			}
		}catch(Exception e){ExceptionClass.ExceptReporter(e);}}
		#endregion
	}
}
