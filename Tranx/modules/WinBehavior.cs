/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/3/8
 * 时间: 7:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
namespace Tranx
{
	/// <summary>
	/// Description of WinBehavior.
	/// </summary>
	public class WinBehavior
	{
		#region winmove
		
        /// <summary>
        /// 在mousedown事件中调用winmove(hwnd)
        /// </summary>
        /// <param name="hwnd"></param>
        public static void winmove(IntPtr hwnd)
        {
            ReleaseCapture();
            SendMessage(hwnd,msgenum. WM_SYSCOMMAND, msgenum.SC_MOVE + msgenum.HTCAPTION, 0);
        }
        #endregion
        #region clipboard
        public static void setclipboard(string arg)
        {
        	Clipboard.SetDataObject(arg,true);
        }
        public static Object getclipboard(Type type)
        {
        	IDataObject obj= Clipboard.GetDataObject();
        	return obj.GetData(type);
        }
        #endregion
        #region gethandle
        [DllImport("user32.dll",EntryPoint="WindowFromPoint")]
        static extern int WindowFromPoint(int xPoint,int yPoint);
        /// <summary>
        /// 返回当前鼠标所在窗口的handle
        /// </summary>
        /// <returns></returns>
        public static IntPtr GetWnd()
        {
        	return (IntPtr)WindowFromPoint(Cursor.Position.X,Cursor.Position.Y);
        	
        }
        	
        
        #endregion
        #region topmost
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);
		
        //如果函数执行成功，返回值不为0。
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
                        IntPtr hWnd,                //要定义热键的窗口的句柄
            int id,                     //定义热键ID（不能与其它ID重复）
            KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
            Keys vk                     //定义热键的内容
            );
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,                //要取消热键的窗口的句柄
            int id                      //要取消热键的ID
            );
        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
        #endregion
        #region size
         [DllImport("user32.dll")]//命名空间System.Runtime.InteropServices;
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public struct msgenum{
        	public const int WM_SYSCOMMAND = 0x0112;
        	public const int SC_MOVE = 0xF010;
        	public const int HTCAPTION = 0x0002;
        	public const int SC_MINIMIZE = 0xF020;
        	public const int SC_MAXIMIZE = 0xF030;
        	public const int SC_RESTORE = 0xF120;
        	public const int SC_SIZE = 0xF000;
        	//改变窗体大小，SC_SIZE+下面的值
        	public const int LEFT = 0x0001;//光标在窗体左边缘
        	public const int RIGHT = 0x0002;//右边缘
        	public const int UP = 0x0003;//上边缘
        	public const int LEFTUP = 0x0004;//左上角
        	public const int RIGHTUP = 0x0005;//右上角
        	public const int BOTTOM = 0x0006;//下边缘
        	public const int LEFTBOTTOM = 0x0007;//左下角
        	public const int RIGHTBOTTOM = 0x0008;//右下角

        }
        #endregion
        #region stopproc
        public static void KillProcess(string name)
		{
 			foreach (Process p in System.Diagnostics.Process.GetProcessesByName(name))
 			{
  				try
  				{
   					p.Kill();
   					p.WaitForExit(); 
  				}
  				catch (Exception)
  				{
   				}
 			}
		}
        #endregion
	}
}
