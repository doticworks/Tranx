/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2020/4/2
 * 时间: 9:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Threading;
using System.Collections;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
namespace Tranx.modules
{
	/// <summary>
	/// Description of FileBehavior.
	/// </summary>
	public class FileBehavior
	{
		#region 分割文件
        /// <summary>
        /// 分割文件
        /// </summary>
        /// <param name="strFlag">分割单位</param>
        /// <param name="intFlag">分割大小</param>
        /// <param name="strPath">分割后的文件存放路径</param>
        /// <param name="strFile">要分割的文件</param>
        /// <param name="PBar">进度条显示</param>
        public static void SplitFile(int iFileSize,string strPath, string strFile,double proc)
        {
            
            //以文件的全路径对应的字符串和文件打开模式来初始化FileStream文件流实例
            FileStream SplitFileStream = new FileStream(strFile, FileMode.Open);
            //以FileStream文件流来初始化BinaryReader文件阅读器
            BinaryReader SplitFileReader = new BinaryReader(SplitFileStream);
            //每次分割读取的最大数据
            byte[] TempBytes;
            //小文件总数
            int iFileCount = (int)(SplitFileStream.Length / iFileSize);
            
            if (SplitFileStream.Length % iFileSize != 0)// iFileCount  ;
      //      string[] TempExtra = strFile.Split('.');
            //循环将大文件分割成多个小文件
            for (int i = 0; i < iFileCount; i++)
            {
                //确定小文件的文件名称
                string sTempFileName = strPath+@"\"+i.ToString()+".tranxc"; //小文件名
                //根据文件名称和文件打开模式来初始化FileStream文件流实例
                FileStream TempStream = new FileStream(sTempFileName, FileMode.OpenOrCreate);
                //以FileStream实例来创建、初始化BinaryWriter书写器实例
                BinaryWriter TempWriter = new BinaryWriter(TempStream);
                //从大文件中读取指定大小数据
                TempBytes = SplitFileReader.ReadBytes(iFileSize);
                //把此数据写入小文件
                TempWriter.Write(TempBytes);
                //关闭书写器，形成小文件
                TempWriter.Close();
                //关闭文件流
                TempStream.Close();
                proc = (i - 1)/iFileCount;
            }
            //关闭大文件阅读器
            SplitFileReader.Close();
            SplitFileStream.Close();
            
        }
        #endregion
 
        #region 合并文件
        /// <summary>
        /// 合并文件
        /// </summary>
        /// <param name="list">要合并的文件集合</param>
        /// <param name="strPath">合并后的文件名称</param>
        /// <param name="PBar">进度条显示</param>
        public static void CombinFile(string[] strFile, string strPath,double proc)
        {
           
            FileStream AddStream = null;
            //以合并后的文件名称和打开方式来创建、初始化FileStream文件流
            AddStream = new FileStream(strPath, FileMode.Append);
            //以FileStream文件流来初始化BinaryWriter书写器，此用以合并分割的文件
            BinaryWriter AddWriter = new BinaryWriter(AddStream);
            FileStream TempStream = null;
            BinaryReader TempReader = null;
            //循环合并小文件，并生成合并文件
            for (int i = 0; i < strFile.Length; i++)
            {
                //以小文件所对应的文件名称和打开模式来初始化FileStream文件流，起读取分割作用
                TempStream = new FileStream(strFile[i].ToString(), FileMode.Open);
                TempReader = new BinaryReader(TempStream);
                //读取分割文件中的数据，并生成合并后文件
                AddWriter.Write(TempReader.ReadBytes((int)TempStream.Length));
                //关闭BinaryReader文件阅读器
                TempReader.Close();
                //关闭FileStream文件流
                TempStream.Close();
                proc=(i-1)/strFile.Length;
            }
            //关闭BinaryWriter文件书写器
            AddWriter.Close();
            //关闭FileStream文件流
            AddStream.Close();
            
        }
        #endregion
	}
}
