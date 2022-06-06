using Swsk33.Mct2Dump.Model;

namespace Swsk33.Mct2Dump.Strategy
{
	/// <summary>
	/// 读取策略
	/// </summary>
	public interface ReadStrategy
	{
		/// <summary>
		/// 打开文件策略
		/// </summary>
		/// <returns>打开的文件路径</returns>
		string OpenFile();

		/// <summary>
		/// 读取IC卡文件策略
		/// </summary>
		/// <param name="filePath">原IC卡文件</param>
		/// <returns>解析后的IC卡文件数据</returns>
		ICCardData ReadData(string filePath);
	}
}