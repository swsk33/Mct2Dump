using Swsk33.Mct2Dump.Model;

namespace Swsk33.Mct2Dump.Strategy
{
	/// <summary>
	/// 读取策略
	/// </summary>
	public interface ReadStrategy
	{
		/// <summary>
		/// 读取原数据
		/// </summary>
		/// <returns>读取后的IC卡数据类型</returns>
		ICCardData ReadData(object data);
	}
}