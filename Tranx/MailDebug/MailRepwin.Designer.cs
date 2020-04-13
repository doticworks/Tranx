/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/4/3
 * 时间: 7:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Tranx.MailDebug
{
	partial class MailRepwin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel mainpanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox mail;
		private System.Windows.Forms.Label laben;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label mailtip;
		private System.Windows.Forms.Label labzh;
		
		
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
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailRepwin));
			this.mainpanel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.mail = new System.Windows.Forms.TextBox();
			this.laben = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labzh = new System.Windows.Forms.Label();
			this.mailtip = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.mainpanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainpanel
			// 
			this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.mainpanel.Controls.Add(this.pictureBox1);
			this.mainpanel.Controls.Add(this.panel2);
			this.mainpanel.Controls.Add(this.button2);
			this.mainpanel.Controls.Add(this.mailtip);
			this.mainpanel.Controls.Add(this.button1);
			this.mainpanel.Controls.Add(this.mail);
			this.mainpanel.Controls.Add(this.laben);
			this.mainpanel.Controls.Add(this.panel1);
			this.mainpanel.Controls.Add(this.labzh);
			this.mainpanel.Location = new System.Drawing.Point(1, 1);
			this.mainpanel.Name = "mainpanel";
			this.mainpanel.Size = new System.Drawing.Size(800, 350);
			this.mainpanel.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.Location = new System.Drawing.Point(0, 320);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(400, 30);
			this.button1.TabIndex = 4;
			this.button1.Text = "向开发者发送邮件  |  Email developer";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// mail
			// 
			this.mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mail.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mail.Location = new System.Drawing.Point(0, 270);
			this.mail.Name = "mail";
			this.mail.Size = new System.Drawing.Size(800, 26);
			this.mail.TabIndex = 3;
			// 
			// laben
			// 
			this.laben.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.laben.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.laben.Location = new System.Drawing.Point(423, 81);
			this.laben.Name = "laben";
			this.laben.Size = new System.Drawing.Size(366, 141);
			this.laben.TabIndex = 2;
			this.laben.Text = resources.GetString("laben.Text");
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.panel1.Location = new System.Drawing.Point(400, 83);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1, 150);
			this.panel1.TabIndex = 1;
			// 
			// labzh
			// 
			this.labzh.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labzh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.labzh.Location = new System.Drawing.Point(11, 77);
			this.labzh.Name = "labzh";
			this.labzh.Size = new System.Drawing.Size(366, 141);
			this.labzh.TabIndex = 0;
			this.labzh.Text = "Emm......\r\n程序在运行时出现了一些问题\r\n我们希望你能向开发者报告此错误来改进软件。\r\n假如需要回信的话，请在下框填写你的邮件地址。\r\n\r\n如果你是开发" +
	"者，希望你也能填写你的邮件地址\r\n我们可以一起纠正此错误甚至一起开发软件";
			// 
			// mailtip
			// 
			this.mailtip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mailtip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.mailtip.Location = new System.Drawing.Point(84, 240);
			this.mailtip.Name = "mailtip";
			this.mailtip.Size = new System.Drawing.Size(630, 23);
			this.mailtip.TabIndex = 5;
			this.mailtip.Text = "你的邮件地址，此框选填                                   |         Your email address, this " +
	"box is optional";
			this.mailtip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.Location = new System.Drawing.Point(401, 320);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(400, 30);
			this.button2.TabIndex = 6;
			this.button2.Text = "我不想向开发者发送邮件  |  I don\'t want to send emails";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.panel2.Location = new System.Drawing.Point(400, 320);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1, 30);
			this.panel2.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(349, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// MailRepwin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(802, 352);
			this.Controls.Add(this.mainpanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MailRepwin";
			this.Text = "MailRepwin";
			this.mainpanel.ResumeLayout(false);
			this.mainpanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		
		
	}
}
