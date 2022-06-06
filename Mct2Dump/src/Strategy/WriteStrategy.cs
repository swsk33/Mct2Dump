using Swsk33.Mct2Dump.Model;

namespace Swsk33.Mct2Dump.Strategy
{
	/// <summary>
	/// IC卡文件写入策略
	/// </summary>
	public interface WriteStrategy
	{
		/// <summary>
		/// 设定保存位置
		/// </summary>
		/// <returns>保存的路径</returns>
		string SetSavePath();

		/// <summary>
		/// 把IC卡数据类型转换为对应的类型并保存
		/// </summary>
		/// <param name="data">解析后的IC卡数据</param>
		/// <param name="filePath">指定保存的文件路径</param>
		/// <returns>是否保存成功</returns>
		bool SaveDataToFile(ICCardData data, string filePath);
	}
}