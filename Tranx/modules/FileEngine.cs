/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/31
 * 时间: 21:40
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
namespace Tranx.modules
{
	/// <summary>
	/// Description of FileEngine.
	/// </summary>
	public class FileEngine
	{
		public const int FE_SEND = 1;
		public const int FE_RECV = 0;
		int runstate = 0;
		System.Net.Sockets.Socket socketC = new Socket(AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, ProtocolType.Tcp);
		const int PAKSIZE = 4 * 1024;
		string path = String.Empty;
		FileEngineData fedC;
		int corenumC=0;
		ProgramData progdat;
		public FileEngine(System.Net.Sockets.Socket socketF,ProgramData progdatF, string FilePath,int corenumF, int runstateF)
		{
			progdat=progdatF;
			corenumC=corenumF;
			fedC=new FileEngineData(corenumF);
			socketC = socketF;
			path = FilePath;
			runstate = runstateF;
		}
		
		
		void sender(ProgramData progdatF,FileEngineData fedF,int corenumF)
		{
			FileStream fsinst=new FileStream(path,FileMode.Open);
			long length=fsinst.Length;
			fsinst.Close();
			FileBehavior.SplitFile((int)(length/corenumF),@"Cache",path,progdat.sendpercent);
			
			for(int i=1;i<=corenumF;i++)
			{
				
			}
		}
        #region Core
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ns"></param>
		/// <param name="fs"></param>
		/// /// <param name="coreindex">startpoint--0</param>
		/// <returns>1:success---0:error</returns>
		private int SendCore(NetworkStream ns,FileStream fs,int coreindex)
		{
			long cachelength=fs.Length;
			long sendedlength=0;
			const int BUFFERSIZE=4*1024;
			byte[] buffer=new byte[BUFFERSIZE];
			int readlen=0;
			while(sendedlength<=cachelength)
			{
				readlen=fs.Read(buffer,0,BUFFERSIZE);
				try{
					ns.Write(buffer,0,readlen);
				}
				catch(Exception){
					return 0;
				}
				sendedlength+=readlen;
			}
			return 1;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ns"></param>
		/// <param name="fs"></param>
		/// <param name="cachelength"></param>
		/// <param name="coreindex">startpoint--0</param>
		/// <returns>1:success---0:error</returns>
		private int RecvCore(NetworkStream ns,FileStream fs,long cachelength,int coreindex)
		{
			
			long recvedlength=0;
			const int BUFFERSIZE=4*1024;
			byte[] buffer=new byte[BUFFERSIZE];
			int readlen=0;
			while(recvedlength<=cachelength)
			{
				readlen=ns.Read(buffer,0,BUFFERSIZE);
				try{
					fs.Write(buffer,0,readlen);
				}
				catch(Exception){
					return 0;
				}
				recvedlength+=readlen;
			}
			return 1;
		}
		#endregion 
	}
	public class FileEngineData
	{
		public int[] doneseek;
		public FileEngineData(int corenum)
		{
//			doneseek=new int[corenum]();
		}
	}
}
