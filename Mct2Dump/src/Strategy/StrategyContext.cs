using Swsk33.Mct2Dump.Model;
using Swsk33.Mct2Dump.Param;
using Swsk33.Mct2Dump.Strategy.Impl;
using System.Collections.Generic;

namespace Swsk33.Mct2Dump.Strategy
{
	/// <summary>
	/// 策略上下文
	/// </summary>
	public class StrategyContext
	{
		/// <summary>
		/// 读取策略上下文
		/// </summary>
		private static Dictionary<string, ReadStrategy> ReadStrategyContext = new Dictionary<string, ReadStrategy>();

		/// <summary>
		/// 写入策略上下文
		/// </summary>
		private static Dictionary<string, WriteStrategy> WriteStrategyContext = new Dictionary<string, WriteStrategy>();

		/// <summary>
		/// 静态构造函数初始化
		/// </summary>
		static StrategyContext()
		{
			// 初始化读策略容器
			ReadStrategyContext.Add(DataType.JSON, new JSONReadStrategy());
			ReadStrategyContext.Add(DataType.EML, new EmlReadStrategy());
			ReadStrategyContext.Add(DataType.MCT, new MctReadStrategy());
			ReadStrategyContext.Add(DataType.DUMP, new DumpReadStrategy());
			// 初始化写策略容器
			WriteStrategyContext.Add(DataType.JSON, new JSONWriteStrategy());
			WriteStrategyContext.Add(DataType.EML, new EmlWriteStrategy());
			WriteStrategyContext.Add(DataType.MCT, new MctWriteStrgtegy());
			WriteStrategyContext.Add(DataType.DUMP, new DumpWriteStrategy());
		}

		/// <summary>
		/// 打开文件时，指定打开文件的路径
		/// </summary>
		/// <param name="dataType">要打开的文件类型</param>
		/// <returns>指定文件路径</returns>
		public static string GetInputFilePath(string dataType)
		{
			return ReadStrategyContext[dataType].OpenFile();
		}

		/// <summary>
		/// 保存文件时，指定保存位置
		/// </summary>
		/// <param name="dataType">文件类型</param>
		/// <returns>指定保存文件路径</returns>
		public static string GetSaveFilePath(string dataType)
		{
			return WriteStrategyContext[dataType].SetSavePath();
		}

		/// <summary>
		/// 读取IC卡文件
		/// </summary>
		/// <param name="dataType">文件类型</param>
		/// <param name="filePath">读取文件路径</param>
		/// <returns>读取后的内容</returns>
		public static ICCardData ReadICDataFile(string dataType, string filePath)
		{
			return ReadStrategyContext[dataType].ReadData(filePath);
		}

		/// <summary>
		/// 写入IC卡数据到文件
		/// </summary>
		/// <param name="dataType">保存文件类型</param>
		/// <param name="data">IC卡解析后数据</param>
		/// <param name="filePath">保存位置</param>
		/// <returns>是否保存成功</returns>
		public static bool WriteICDataToFile(string dataType, ICCardData data, string filePath)
		{
			return WriteStrategyContext[dataType].SaveDataToFile(data, filePath);
		}
	}
}