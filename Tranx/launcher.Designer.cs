/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/26
 * 时间: 8:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Tranx
{
	partial class launcher
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel mainpanel;
		private System.Windows.Forms.Label ipportx;
		private System.Windows.Forms.TextBox porttex;
		private System.Windows.Forms.TextBox iptex;
		private System.Windows.Forms.Button minibtn;
		private System.Windows.Forms.Button aboutbtn;
		private System.Windows.Forms.Button exitbtn;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Button conbtn;
		private System.Windows.Forms.Timer update;
		
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
			this.conbtn = new System.Windows.Forms.Button();
			this.ipportx = new System.Windows.Forms.Label();
			this.porttex = new System.Windows.Forms.TextBox();
			this.iptex = new System.Windows.Forms.TextBox();
			this.minibtn = new System.Windows.Forms.Button();
			this.aboutbtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.title = new System.Windows.Forms.Label();
			this.update = new System.Windows.Forms.Timer(this.components);
			this.mainpanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainpanel
			// 
			this.mainpanel.BackColor = System.Drawing.Color.White;
			this.mainpanel.Controls.Add(this.conbtn);
			this.mainpanel.Controls.Add(this.ipportx);
			this.mainpanel.Controls.Add(this.porttex);
			this.mainpanel.Controls.Add(this.iptex);
			this.mainpanel.Controls.Add(this.minibtn);
			this.mainpanel.Controls.Add(this.aboutbtn);
			this.mainpanel.Controls.Add(this.exitbtn);
			this.mainpanel.Controls.Add(this.title);
			this.mainpanel.Location = new System.Drawing.Point(1, 1);
			this.mainpanel.Name = "mainpanel";
			this.mainpanel.Size = new System.Drawing.Size(500, 150);
			this.mainpanel.TabIndex = 0;
			// 
			// conbtn
			// 
			this.conbtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.conbtn.FlatAppearance.BorderSize = 0;
			this.conbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.conbtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.conbtn.ForeColor = System.Drawing.Color.Silver;
			this.conbtn.Location = new System.Drawing.Point(0, 100);
			this.conbtn.Name = "conbtn";
			this.conbtn.Size = new System.Drawing.Size(500, 51);
			this.conbtn.TabIndex = 9;
			this.conbtn.Text = "Connect";
			this.conbtn.UseVisualStyleBackColor = true;
			this.conbtn.Click += new System.EventHandler(this.ConbtnClick);
			// 
			// ipportx
			// 
			this.ipportx.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ipportx.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.ipportx.Location = new System.Drawing.Point(376, 50);
			this.ipportx.Name = "ipportx";
			this.ipportx.Size = new System.Drawing.Size(18, 43);
			this.ipportx.TabIndex = 6;
			this.ipportx.Text = "-";
			this.ipportx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// porttex
			// 
			this.porttex.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.porttex.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.porttex.Location = new System.Drawing.Point(400, 50);
			this.porttex.Name = "porttex";
			this.porttex.Size = new System.Drawing.Size(100, 43);
			this.porttex.TabIndex = 5;
			this.porttex.TextChanged += new System.EventHandler(this.PorttexTextChanged);
			// 
			// iptex
			// 
			this.iptex.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.iptex.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iptex.Location = new System.Drawing.Point(0, 50);
			this.iptex.Name = "iptex";
			this.iptex.Size = new System.Drawing.Size(380, 43);
			this.iptex.TabIndex = 4;
			this.iptex.TextChanged += new System.EventHandler(this.IptexTextChanged);
			// 
			// minibtn
			// 
			this.minibtn.FlatAppearance.BorderSize = 0;
			this.minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minibtn.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minibtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.minibtn.Location = new System.Drawing.Point(450, 0);
			this.minibtn.Name = "minibtn";
			this.minibtn.Size = new System.Drawing.Size(25, 25);
			this.minibtn.TabIndex = 3;
			this.minibtn.Text = "=";
			this.minibtn.UseVisualStyleBackColor = true;
			this.minibtn.Click += new System.EventHandler(this.MinibtnClick);
			// 
			// aboutbtn
			// 
			this.aboutbtn.FlatAppearance.BorderSize = 0;
			this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aboutbtn.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutbtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.aboutbtn.Location = new System.Drawing.Point(425, 0);
			this.aboutbtn.Name = "aboutbtn";
			this.aboutbtn.Size = new System.Drawing.Size(25, 25);
			this.aboutbtn.TabIndex = 2;
			this.aboutbtn.Text = "?";
			this.aboutbtn.UseVisualStyleBackColor = true;
			this.aboutbtn.Click += new System.EventHandler(this.AboutbtnClick);
			// 
			// exitbtn
			// 
			this.exitbtn.FlatAppearance.BorderSize = 0;
			this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitbtn.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitbtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.exitbtn.Location = new System.Drawing.Point(475, 0);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(25, 25);
			this.exitbtn.TabIndex = 1;
			this.exitbtn.Text = "X";
			this.exitbtn.UseVisualStyleBackColor = true;
			this.exitbtn.Click += new System.EventHandler(this.ExitbtnClick);
			// 
			// title
			// 
			this.title.BackColor = System.Drawing.Color.White;
			this.title.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.Silver;
			this.title.Location = new System.Drawing.Point(0, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(500, 50);
			this.title.TabIndex = 0;
			this.title.Text = "Connect a Socket";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleMouseDown);
			// 
			// update
			// 
			this.update.Enabled = true;
			this.update.Tick += new System.EventHandler(this.UpdateTick);
			// 
			// launcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(502, 152);
			this.Controls.Add(this.mainpanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "launcher";
			this.Text = "launcher";
			this.mainpanel.ResumeLayout(false);
			this.mainpanel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
