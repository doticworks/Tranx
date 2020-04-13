/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 9:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using Tranx.modules;
namespace Tranx
{
	public class ProgramData
	{
		#region network
		public string ipstr="c";
		public IPAddress ip=null;
		public int ipstate=0;//---0不可用---1可用
		public string portstr="58484";
		public IPEndPoint port=null;
		public int portstate=0;//---0不可用---1可用
		#endregion
		
		/// <summary>
		/// 0无命令---1exec---
		/// </summary>
		public int command=0;
		
		/// <summary>
		/// server端未接入的System.Net.Sockets.Socket
		/// </summary>
		public Bsocqueue watchating=new Bsocqueue();
		/// <summary>
		/// server端已接入的System.Net.Sockets.Socket
		/// </summary>
		public List<System.Net.Sockets.Socket> chating=new List<System.Net.Sockets.Socket>();
		/// <summary>
		/// 服务端或客户端接收到的消息
		/// </summary>
		public Bstrqueue msgIN=new Bstrqueue();
		/// <summary>
		/// 服务端或客户端将发送出去的消息
		/// </summary>
		public Bstrqueue msgOUT=new Bstrqueue();
		/// <summary>
		/// 服务端或客户端将要显示在聊天窗口的信息
		/// </summary>
		public Queue<string> msgSHOW=new Queue<string>();
		/// <summary>
		/// 是否打开聊天窗口
		/// </summary>
		public bool StartChatwnd=false;
		#region File
		/// <summary>
		/// 发送状态 0无 1发送前检验 2发送中 3发送后检验
		/// </summary>
		public int sendstate=0;
		/// <summary>
		/// 已发送、前检验、后检验的百分比
		/// </summary>
		public double sendpercent=0;
		#endregion
		
	}
	/// <summary>
	/// Description of MAIN.
	/// </summary>
	public class MAIN
	{
		ProgramData progd;
		
		/// <summary>
		/// INITINSTANCE
		/// </summary>
		/// <param name="progdat"></param>
		public MAIN(ProgramData progdat)
		{
			progd=progdat;
			Thread datadetectth=new Thread(()=>datadetect(progd));
			Thread launcherth=new Thread(()=>launcher(progd));
	//		Thread th=new Thread(()=>(progd));
			
			#region isbackground在程序退出时清理后台线程
			datadetectth.IsBackground=true;
			launcherth.IsBackground=true;
	//		th.IsBackground=true;
			
			#endregion
			
			#region STAmode用于在线程中调用dialog
			datadetectth.SetApartmentState(ApartmentState.STA);
			launcherth.SetApartmentState(ApartmentState.STA);
	//		th.SetApartmentState(ApartmentState.STA);
			
			#endregion
			datadetectth.Start();
			launcherth.Start();
	//		th.Start();
			
		}
		
		
		void datadetect(ProgramData prog)
		{
			
			while(true)
			{
				Thread.Sleep(200);
				try{
					if(prog.ipstr=="l")
					{prog.ipstr="127.0.0.1";}
					if(prog.ipstr=="p")
					{prog.ipstr=Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();}
					if(prog.ipstr=="c")
					{prog.ipstr="103.46.128.43";}
					prog.ip=IPAddress.Parse(prog.ipstr);
					prog.ipstate=1;}
				catch{prog.ipstate=0;}
				
				try{prog.port=new IPEndPoint(prog.ip,int.Parse(prog.portstr));
					prog.portstate=1;}
				catch{prog.portstate=0;}
				
				
			}
		}
		void launcher(ProgramData prog)
		{
			while(true)
			{
				Thread.Sleep(200);
				if(prog.command==1&&prog.portstate==1&&prog.ipstate==1)
				{
					System.Net.Sockets.Socket soc=NetBehavior.ServerTest(prog.port);
					if(soc==null)
					{
						Thread ClientLauncherth=new Thread(()=>NetBehavior.ClientLauncher(prog,prog.port));
						ClientLauncherth.IsBackground=true;
						ClientLauncherth.Start();
						prog.StartChatwnd=true;
						return;
					}
					Thread ServerLauncherth=new Thread(()=>NetBehavior.ServerLauncher(prog,soc));
					ServerLauncherth.IsBackground=true;
					ServerLauncherth.Start();
					prog.StartChatwnd=true;
					return;
				}
				prog.command=0;
				
			}
		}
		
		
		
	}
}
