/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/24
 * 时间: 7:58
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
namespace MailReporter
{
	/// <summary>
	/// EHPEKOGCZTBRSAQU 
	/// </summary>
	public class ReporterCore
	{
		const string strFromMailbox = "E23AC31BB6C484B917DB1CD20551C25F470C5B774DF20971";
        const string strToMailbox = "F7F02385ACA922AD0FD693F41B3F88FB";
        const string strMyMailbox = "E23AC31BB6C484B917DB1CD20551C25F470C5B774DF20971";
        
        const string strPassword = "09C4ED38A4E16AD4C2F09C3A56B7F92E566B399ECA26677F";
        const string strHost = "39F5437C0EAED7223E31947968FC9374";
    //    const int i32Post = 465;
        static Encoding myEncoding=System.Text.Encoding.UTF8;
        
       
        /// <summary>
        /// 发送完整的邮件
        /// </summary>
        /// <param name="subject">标题</param>
        /// <param name="body">内容</param>
        /// <param name="files">附件名，用'#'分割</param>
        /// <returns>true代表发送成功</returns>
        public static bool Send(string subject,string body,string files)
        {
        	try    
            { 
        		
              	MailMessage mm = new MailMessage();
              	MailAddress Fromma = new MailAddress(gs(strFromMailbox));
              	MailAddress Toma = new MailAddress(gs(strToMailbox), null);
   				mm.From = Fromma;
   				mm.To.Add(gs(strToMailbox));
   				//邮箱标题
   				mm.Subject = subject;
  	 			mm.IsBodyHtml = true;
  	 			//邮件内容
 	  			mm.Body = body;
   				//内容的编码格式
  	 			mm.BodyEncoding = System.Text.Encoding.UTF8;
   				//mm.ReplyTo = Toma;
   				//mm.Sender =Fromma;
  	 			//mm.IsBodyHtml = false;
   				mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
   				mm.CC.Add(Toma);
   				if (files.Length != 0)//发送附件（多个附件的文件名称我用 | 隔开的，所以此处这样写）
     	       	{
              		string [] arrfile = files.Split('#');
                	for (int i = 0; i < arrfile.Length; i++)
                	{
                	
                    	if (arrfile[i].Length > 0)
                    	{
                        	mm.Attachments.Add(new Attachment(arrfile[i]));
                    	}
                	}
           		}
  		 		SmtpClient sc = new SmtpClient();
  		 		NetworkCredential nc = new NetworkCredential();
  		 		nc.UserName = gs(strMyMailbox);//你的邮箱地址
  	 			nc.Password = gs(strPassword);//邮箱密码,这里的密码是xxxxx@qq.com邮箱的密码~
 	 	 		sc.UseDefaultCredentials = true;
  		 		sc.DeliveryMethod = SmtpDeliveryMethod.Network;
 		  		sc.Credentials = nc;
 		  		//如果这里报mail from address must be same as authorization user这个错误，是你的QQ邮箱没有开启SMTP，
 		  		//到你自己的邮箱设置一下就可以啦！在帐户下面,如果是163邮箱的话，下面该成smtp.163.com
	  	 		sc.Host = gs(strHost);	
	   			sc.Send(mm);
          		return true;
            }    
            catch (Exception ex)    
            {    
            	return false;
            } 
        }
        /// <summary>
        /// 发送不带附件的邮件
        /// </summary>
        /// <param name="subject">标题</param>
        /// <param name="body">内</param>
        /// <returns>true代表发送成功</returns>
        public static bool Send(string subject,string body)
        {
        	try    
            { 
           		MailMessage mm = new MailMessage();
           		MailAddress Fromma = new MailAddress(gs(strFromMailbox));
   				MailAddress Toma = new MailAddress(gs(strToMailbox), null);
   				mm.From = Fromma;
   				mm.To.Add(gs(strToMailbox));
   				//邮箱标题
   				mm.Subject = subject;
  	 			mm.IsBodyHtml = true;
  	 			//邮件内容
 	  			mm.Body = body;
   				//内容的编码格式
  	 			mm.BodyEncoding = System.Text.Encoding.UTF8;
   				//mm.ReplyTo = Toma;
   				//mm.Sender =Fromma;
  	 			//mm.IsBodyHtml = false;
   				mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
   				mm.CC.Add(Toma);
  		 		SmtpClient sc = new SmtpClient();
  		 		NetworkCredential nc = new NetworkCredential();
  		 		nc.UserName = gs(strMyMailbox);//你的邮箱地址
  	 			nc.Password = gs(strPassword);//邮箱密码,这里的密码是xxxxx@qq.com邮箱的密码~
 	 	 		sc.UseDefaultCredentials = true;
  		 		sc.DeliveryMethod = SmtpDeliveryMethod.Network;
 		  		sc.Credentials = nc;
 		  		//如果这里报mail from address must be same as authorization user这个错误，是你的QQ邮箱没有开启SMTP，
 		  		//到你自己的邮箱设置一下就可以啦！在帐户下面,如果是163邮箱的话，下面该成smtp.163.com
	  	 		sc.Host = gs(strHost);	
	   			sc.Send(mm);
          		return true;
            }    
            catch (Exception ex)    
            {    
            	return false;
            } 
        }
        /*
        /// <summary>
        /// 发送内容邮件
        /// </summary>
        /// <param name="body">邮件内容</param>
        /// <returns>true代表发送成功</returns>
        public static bool Send(string body)
        {
        	try    
            {
            	MailMessage mm = new MailMessage();
            	MailAddress Fromma = new MailAddress(gs(strFromMailbox));
   				MailAddress Toma = new MailAddress(gs(strToMailbox), null);
   				mm.From = Fromma;
   				mm.To.Add(gs(strToMailbox));
   				//邮箱标题
   				mm.Subject =gs("165127633AE4C39D60D443711E677EEFBF631AD6E793E409");
  	 			mm.IsBodyHtml = true;
  	 			//邮件内容
 	  			mm.Body = body;
   				//内容的编码格式
  	 			mm.BodyEncoding = System.Text.Encoding.UTF8;
   				//mm.ReplyTo = Toma;
   				//mm.Sender =Fromma;
  	 			//mm.IsBodyHtml = false;
   				mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
   				mm.CC.Add(Toma);
   				
  		 		SmtpClient sc = new SmtpClient();
  		 		NetworkCredential nc = new NetworkCredential();
  		 		nc.UserName = gs(strMyMailbox);//你的邮箱地址
  	 			nc.Password = gs(strPassword);//邮箱密码,这里的密码是xxxxx@qq.com邮箱的密码~
 	 	 		sc.UseDefaultCredentials = true;
  		 		sc.DeliveryMethod = SmtpDeliveryMethod.Network;
 		  		sc.Credentials = nc;
 		  		//如果这里报mail from address must be same as authorization user这个错误，是你的QQ邮箱没有开启SMTP，
 		  		//到你自己的邮箱设置一下就可以啦！在帐户下面,如果是163邮箱的话，下面该成smtp.163.com
	  	 		sc.Host = gs(strHost);	
	   			sc.Send(mm);
          		return true;
            }    
            catch (Exception ex)    
            {    
            	return false;
            } 
        }
        /// <summary>
        /// 发送测试邮件
        /// </summary>
        /// <returns>true代表发送成功</returns>
		public static bool Send()
        {
        	try    
            {
          		MailMessage mm = new MailMessage();
 				MailAddress Fromma = new MailAddress(gs(strFromMailbox));
   				MailAddress Toma = new MailAddress(gs(strToMailbox), null);
   				mm.From = Fromma;
   				mm.To.Add(gs(strToMailbox));
   				//邮箱标题
   				mm.Subject =gs("165127633AE4C39D60D443711E677EEFBF631AD6E793E409");
  	 			mm.IsBodyHtml = true;
  	 			//邮件内容
  	 			mm.Body = gs("28A011E849C0FAC41EF520233F4E3A2A");
   				//内容的编码格式
  	 			mm.BodyEncoding = System.Text.Encoding.UTF8;
   				//mm.ReplyTo = Toma;
   				//mm.Sender =Fromma;
  	 			//mm.IsBodyHtml = false;
   				mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
   				mm.CC.Add(Toma);
   				
  		 		SmtpClient sc = new SmtpClient();
  		 		NetworkCredential nc = new NetworkCredential();
  		 		nc.UserName = gs(strMyMailbox);//你的邮箱地址
  	 			nc.Password = gs(strPassword);//邮箱密码,这里的密码是xxxxx@qq.com邮箱的密码~
 	 	 		sc.UseDefaultCredentials = true;
  		 		sc.DeliveryMethod = SmtpDeliveryMethod.Network;
 		  		sc.Credentials = nc;
 		  		//如果这里报mail from address must be same as authorization user这个错误，是你的QQ邮箱没有开启SMTP，
 		  		//到你自己的邮箱设置一下就可以啦！在帐户下面,如果是163邮箱的话，下面该成smtp.163.com
	  	 		sc.Host = gs(strHost);	
	   			sc.Send(mm);
          		return true;
            }    
            catch (Exception ex)    
            {    
            	return false;
            } 
        }
		*/
		static string gs(string pToDecrypt)
  		{
			string sKey="F5DF8G6E";
        	DESCryptoServiceProvider des = new DESCryptoServiceProvider();
 
    	    byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
    	    for (int x = 0; x < pToDecrypt.Length / 2; x++)
    	    {
    	        int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
    	        inputByteArray[x] = (byte)i;
    	    }
 			
    	    des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
    	    des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
    	    MemoryStream ms = new MemoryStream();
    	    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
    	    cs.Write(inputByteArray, 0, inputByteArray.Length);
    	    cs.FlushFinalBlock();
 	
    	    StringBuilder ret = new StringBuilder();
 	
    	    return System.Text.Encoding.Default.GetString(ms.ToArray());
    	}

	}
}