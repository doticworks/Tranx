/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/24
 * 时间: 19:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using MailReporter;
using System.Windows.Forms;
namespace AudioBOX.modules
{
	/// <summary>
	/// Description of mailrep.
	/// </summary>
	public static class MailRep
	{
		public static void Rep(string files)
		{
			DialogResult dr= MessageBox.Show("程序希望发送邮件向开发者报告错误，是否允许\r\n将发送以下文件\r\n"+files.Replace(@"#","\r\n")
			                                 ,"确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dr == DialogResult.OK)
			{
				Reporter.Send("DEBUG-AudioBOX","audiobox",files);
			}
			else
			{
			}
				
		}
	}
}
