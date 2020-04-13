/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 22:18
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.IO;
using System.Windows.Forms;
namespace Tranx.modules
{
	/// <summary>
	/// Description of Killother.
	/// </summary>
	public class Killother
	{
		public static void kill()
		{
			WinBehavior.KillProcess(Path.GetFileName(Application.ExecutablePath));
		}
	}
}
