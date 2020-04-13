/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 8:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Tranx.modules;
namespace Tranx
{
	/// <summary>
	/// Description of launcher.
	/// </summary>
	public partial class launcher : Form
	{
		ProgramData prog=new ProgramData();
		public launcher(ProgramData pr)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			prog=pr;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		#region winbe
		void TitleMouseDown(object sender, MouseEventArgs e)
		{
			WinBehavior.winmove(this.Handle);
		}
		void AboutbtnClick(object sender, EventArgs e)
		{
			MessageBox.Show("Everybody Fucking John");
		}
		void MinibtnClick(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
		}
		void ExitbtnClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void KillbtnClick(object sender, EventArgs e)
		{
			Killother.kill();
		}
		#endregion
		
		
		
		
		void IptexTextChanged(object sender, EventArgs e)
		{
		
			prog.ipstr=iptex.Text;
		}
		void PorttexTextChanged(object sender, EventArgs e)
		{
			prog.portstr=porttex.Text;
		}
		void UpdateTick(object sender, EventArgs e)
		{
			if(prog.ipstate==0&&iptex.Text!=String.Empty)
			{
				iptex.BackColor=Color.PeachPuff;
			}
			if(prog.portstate==0&&porttex.Text!=String.Empty)
			{
				porttex.BackColor=Color.PeachPuff;
			}
			if(prog.ipstate==1||iptex.Text==String.Empty)
			{
				iptex.BackColor=Color.White;
			}
			if(prog.portstate==1||porttex.Text==String.Empty)
			{
				porttex.BackColor=Color.White;
			}
			if(prog.StartChatwnd)
			{
				
				(new Chatwnd(prog)).Show();
				prog.StartChatwnd=false;
				this.WindowState=FormWindowState.Minimized;
			}
			
		}
		void ConbtnClick(object sender, EventArgs e)
		{
			
			prog.command=1;
			
		}
		
		
		
	}
}
