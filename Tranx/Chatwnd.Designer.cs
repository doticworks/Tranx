/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 11:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Tranx
{
	partial class Chatwnd
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel mainpanel;
		private System.Windows.Forms.Panel wintitle;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Button minibtn;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.ListBox msglist;
		private System.Windows.Forms.Panel size;
		private System.Windows.Forms.Timer update;
		private System.Windows.Forms.Button sendbtn;
		private System.Windows.Forms.TextBox inbox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.mainpanel = new System.Windows.Forms.Panel();
			this.sendbtn = new System.Windows.Forms.Button();
			this.inbox = new System.Windows.Forms.TextBox();
			this.msglist = new System.Windows.Forms.ListBox();
			this.wintitle = new System.Windows.Forms.Panel();
			this.title = new System.Windows.Forms.Label();
			this.minibtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.size = new System.Windows.Forms.Panel();
			this.update = new System.Windows.Forms.Timer(this.components);
			this.mainpanel.SuspendLayout();
			this.wintitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainpanel
			// 
			this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.mainpanel.BackColor = System.Drawing.Color.White;
			this.mainpanel.Controls.Add(this.sendbtn);
			this.mainpanel.Controls.Add(this.inbox);
			this.mainpanel.Controls.Add(this.msglist);
			this.mainpanel.Controls.Add(this.wintitle);
			this.mainpanel.Location = new System.Drawing.Point(1, 1);
			this.mainpanel.Name = "mainpanel";
			this.mainpanel.Size = new System.Drawing.Size(650, 300);
			this.mainpanel.TabIndex = 2;
			// 
			// sendbtn
			// 
			this.sendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sendbtn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.sendbtn.FlatAppearance.BorderSize = 0;
			this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sendbtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sendbtn.Location = new System.Drawing.Point(600, 280);
			this.sendbtn.Name = "sendbtn";
			this.sendbtn.Size = new System.Drawing.Size(20, 20);
			this.sendbtn.TabIndex = 5;
			this.sendbtn.Text = "Send";
			this.sendbtn.UseVisualStyleBackColor = false;
			this.sendbtn.Click += new System.EventHandler(this.SendbtnClick);
			// 
			// inbox
			// 
			this.inbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.inbox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.inbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inbox.ForeColor = System.Drawing.Color.DimGray;
			this.inbox.Location = new System.Drawing.Point(0, 280);
			this.inbox.Name = "inbox";
			this.inbox.Size = new System.Drawing.Size(600, 20);
			this.inbox.TabIndex = 4;
			this.inbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InboxKeyDown);
			// 
			// msglist
			// 
			this.msglist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.msglist.BackColor = System.Drawing.Color.White;
			this.msglist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.msglist.Cursor = System.Windows.Forms.Cursors.Default;
			this.msglist.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msglist.ForeColor = System.Drawing.Color.DimGray;
			this.msglist.FormattingEnabled = true;
			this.msglist.HorizontalScrollbar = true;
			this.msglist.ItemHeight = 14;
			this.msglist.Location = new System.Drawing.Point(0, 23);
			this.msglist.Name = "msglist";
			this.msglist.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.msglist.Size = new System.Drawing.Size(650, 252);
			this.msglist.TabIndex = 3;
			// 
			// wintitle
			// 
			this.wintitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.wintitle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.wintitle.Controls.Add(this.title);
			this.wintitle.Controls.Add(this.minibtn);
			this.wintitle.Controls.Add(this.exitbtn);
			this.wintitle.Location = new System.Drawing.Point(0, 0);
			this.wintitle.Name = "wintitle";
			this.wintitle.Size = new System.Drawing.Size(650, 20);
			this.wintitle.TabIndex = 2;
			// 
			// title
			// 
			this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.title.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.title.Location = new System.Drawing.Point(0, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(608, 20);
			this.title.TabIndex = 0;
			this.title.Text = " Chat";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleMouseDown);
			// 
			// minibtn
			// 
			this.minibtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minibtn.FlatAppearance.BorderSize = 0;
			this.minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minibtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minibtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.minibtn.Location = new System.Drawing.Point(608, 0);
			this.minibtn.Name = "minibtn";
			this.minibtn.Size = new System.Drawing.Size(20, 20);
			this.minibtn.TabIndex = 4;
			this.minibtn.Text = "=";
			this.minibtn.UseVisualStyleBackColor = true;
			this.minibtn.Click += new System.EventHandler(this.MinibtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitbtn.FlatAppearance.BorderSize = 0;
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitbtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.exitbtn.Location = new System.Drawing.Point(630, 0);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(20, 20);
			this.exitbtn.TabIndex = 3;
			this.exitbtn.Text = "X";
			this.exitbtn.UseVisualStyleBackColor = true;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// size
			// 
			this.size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.size.Location = new System.Drawing.Point(642, 292);
			this.size.Name = "size";
			this.size.Size = new System.Drawing.Size(10, 10);
			this.size.TabIndex = 3;
			this.size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizeMouseDown);
			this.size.MouseEnter += new System.EventHandler(this.SizeMouseEnter);
			this.size.MouseLeave += new System.EventHandler(this.SizeMouseLeave);
			// 
			// update
			// 
			this.update.Enabled = true;
			this.update.Tick += new System.EventHandler(this.UpdateTick);
			// 
			// Chatwnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(652, 302);
			this.Controls.Add(this.size);
			this.Controls.Add(this.mainpanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(10, 10);
			this.Name = "Chatwnd";
			this.Text = "Chatwnd";
			this.Shown += new System.EventHandler(this.ChatwndShown);
			this.mainpanel.ResumeLayout(false);
			this.mainpanel.PerformLayout();
			this.wintitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
