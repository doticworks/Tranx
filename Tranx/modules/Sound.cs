/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 20:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Diagnostics;
using Tranx;
using System.Threading;
namespace Tranx.modules
{
	/// <summary>
	/// Description of Sound.
	/// </summary>
	public static class Sound
	{
		public static void play()
		{
			Thread soundth=new Thread(()=>{if(Config.ismyservermode){
												Process.Start(@"alert.exe");
											}});
			
			soundth.IsBackground=true;
			soundth.SetApartmentState(ApartmentState.STA);
			soundth.Start();
		}
	}
}
