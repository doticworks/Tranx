/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 11:34
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
using System.Windows.Forms;

namespace Tranx
{
	/// <summary>
	/// Description of Chatwnd.
	/// </summary>
	public partial class Chatwnd : Form
	{
		ProgramData progd=null;
		
		public Chatwnd(ProgramData prog)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.TopMost=Config.ismyservermode;
			
			progd=prog;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		#region winbe
		
		void TitleMouseDown(object sender, MouseEventArgs e)
		{
			WinBehavior.winmove(this.Handle);
		}
		void MinibtnClick(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
		}
		void ExitbtnClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void SizeMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Clicks <= 1)
            {
                
                WinBehavior.ReleaseCapture();
                WinBehavior.SendMessage(this.Handle,WinBehavior.msgenum.WM_SYSCOMMAND, WinBehavior.msgenum.SC_SIZE + WinBehavior.msgenum.RIGHTBOTTOM, 0);//拖动右下角改变窗体大小
            }

		}
		void SizeMouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.SizeNWSE;
		}
		void SizeMouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}
		
		#endregion
		
		
		#region update
		void UpdateTick(object sender, EventArgs e)
		{
			WinBehavior.SetWindowPos(this.Handle, -1, 0, 0, 0, 0, 1 | 2);
			try{string a=progd.msgSHOW.Dequeue();
				if(a!="heart")
				{
					msglist.Items.Add(a);
				}
				
			}catch(Exception){}
			
			if(msglist.Items.Count>0){
				msglist.TopIndex = msglist.Items.Count - 1;
				return;
			}
			
		}
		void showmsg()
		{
			msglist.Items.Add(progd.msgSHOW.Dequeue());
		}
		void SendbtnClick(object sender, EventArgs e)
		{
			progd.msgOUT.Enqueue(inbox.Text);
			inbox.Text=String.Empty;
		}
		
		void InboxKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				progd.msgOUT.Enqueue(inbox.Text);
				inbox.Text=String.Empty;
			}
		}
		void ChatwndShown(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Normal;
		}
		
		
		#endregion
		
	}
}
