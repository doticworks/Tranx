/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/9
 * 时间: 20:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;


using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using MailReporter;

namespace Tranx.modules
{
	/// <summary>
	/// Description of Exception.
	/// </summary>
	public class ExceptionClass
	{
		public ProgramData programdata;
		public static void UIException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			System.Diagnostics.Process.Start(@"Exceptionwnd.exe","AudioBOX");
			string log = "";
  			string filename ="UI :"+DateTime.Now.ToString()+".txt";
			filename=filename.Replace(':','.');
			filename=filename.Replace('/','.');
			filename=filename.Replace(' ','.');
  			Exception error = e.Exception as Exception;
  			if (error != null)
  			{
  				log = string.Format("异常类型：{0}/r/n异常消息：{1}/r/n异常信息：{2}/r/n",
  				error.GetType().Name, error.Message, error.StackTrace);
			}
			else
 			{
 				log = string.Format("应用程序线程错误:{0}", e);
 			}
 		
  			if (!Directory.Exists("ErrLog"))
  			{
  				Directory.CreateDirectory("ErrLog");
  			}
  			File.WriteAllText("Errlog\\"+filename,log);
  			MailRep.Rep("Errlog\\"+filename);
  			
			Application.Exit();
		}
		public static void BGException(object sender, UnhandledExceptionEventArgs e)
		{
			System.Diagnostics.Process.Start(@"Exceptionwnd.exe","AudioBOX");
			
			string filename ="BG :"+DateTime.Now.ToString()+".txt";
			filename=filename.Replace(':','.');
			filename=filename.Replace('/','.');
			filename=filename.Replace(' ','.');
			if (!Directory.Exists("ErrLog"))
  			{
  				Directory.CreateDirectory("ErrLog");
  			}
			string log= "OBJ:    "+e.ExceptionObject+"\r\n";
			
				
			File.WriteAllText("Errlog\\"+filename,log);
			MailRep.Rep("Errlog\\"+filename);
  			
			Application.Exit();
		}
		public static void ExceptReporter(Exception exce)
		{
			string filename =DateTime.Now.ToString()+".txt";
			filename=filename.Replace(':','.');
			filename=filename.Replace('/','.');
			filename=filename.Replace(' ','.');
			if (!Directory.Exists("ErrLog"))
  			{
  				Directory.CreateDirectory("ErrLog");
  			}
			string log= "DATA:    "+exce.Data.ToString()+"\r\n"+
					//	"OBJDATA: "+exce.GetObjectData().ToString()+"\r\n"+
					//	"HELPLINK:"+exce.HelpLink.ToString()+"\r\n"+
					//	"HRESULT: "+exce.HResult.ToString()+"\r\n"+
					//	"INNER:   "+exce.InnerException.ToString()+"\r\n"+
						"MESSAGE: "+exce.Message+"\r\n"+
						"SOURCE:  "+exce.Source+"\r\n"+
						"STACK:"   +exce.StackTrace+"\r\n"+
						"TARSITE: "+exce.TargetSite.ToString()+"\r\n";
			File.WriteAllText("Errlog\\"+filename,log);
			MailRep.Rep("Errlog\\"+filename);
			
			
  			
			
		}
		public static void ExceptReporter(string logtext)
		{
			string filename =DateTime.Now.ToString()+".txt";
			filename=filename.Replace(':','.');
			filename=filename.Replace('/','.');
			filename=filename.Replace(' ','.');
			if (!Directory.Exists("ErrLog"))
  			{
  				Directory.CreateDirectory("ErrLog");
  			}
			
			File.WriteAllText("Errlog\\"+filename,logtext);
			MailRep.Rep("Errlog\\"+filename);
			
		}
		public static void ExceptReporter(Exception exce,string arg)
		{
			string filename =DateTime.Now.ToString()+".txt";
			filename=filename.Replace(':','.');
			filename=filename.Replace('/','.');
			filename=filename.Replace(' ','.');
			if (!Directory.Exists("ErrLog"))
  			{
  				Directory.CreateDirectory("ErrLog");
  			}
			string log= "DATA:    "+exce.Data.ToString()+"\r\n"+
					//	"OBJDATA: "+exce.GetObjectData().ToString()+"\r\n"+
					//	"HELPLINK:"+exce.HelpLink.ToString()+"\r\n"+
					//	"HRESULT: "+exce.HResult.ToString()+"\r\n"+
					//	"INNER:   "+exce.InnerException.ToString()+"\r\n"+
						"MESSAGE: "+exce.Message+"\r\n"+
						"SOURCE:  "+exce.Source+"\r\n"+
						"STACK:"   +exce.StackTrace+"\r\n"+
						"TARSITE: "+exce.TargetSite.ToString()+"\r\n";
			File.WriteAllText("Errlog\\"+filename,log);
			MailRep.Rep("Errlog\\"+filename);
			
		}
		public static void Restart()
		{
			
			System.Diagnostics.Process.Start(@"Exceptionwnd.exe","AudioBOX");
			Application.Exit();
		}
	}
}
