namespace Swsk33.Mct2Dump.Model
{
	/// <summary>
	/// 扇区数据类
	/// </summary>
	public class SectorData
	{
		private byte[] contents;

		private string keyA;

		private string keyB;

		private string control;

		/// <summary>
		/// 扇区内容，为扇区的前三行
		/// </summary>
		public byte[] Contents { get => contents; set => contents = value; }

		/// <summary>
		/// 扇区密钥A
		/// </summary>
		public string KeyA { get => keyA; set => keyA = value; }

		/// <summary>
		/// 扇区密钥B
		/// </summary>
		public string KeyB { get => keyB; set => keyB = value; }

		/// <summary>
		/// 扇区访问控制符
		/// </summary>
		public string Control { get => control; set => control = value; }	
	}
}