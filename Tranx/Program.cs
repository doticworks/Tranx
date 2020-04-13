/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 8:26
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Windows.Forms;
using Tranx.modules;
namespace Tranx
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			
			
			ProgramData programdata=new ProgramData();
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ExceptionClass.UIException);
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ExceptionClass.BGException);
			
			
			ProgramData progdat=new ProgramData();
			new MAIN(progdat);
			try{
				Application.Run(new launcher(progdat));}catch(Exception e){ExceptionClass.ExceptReporter(e);}
			
			
		}
		
	}
}
