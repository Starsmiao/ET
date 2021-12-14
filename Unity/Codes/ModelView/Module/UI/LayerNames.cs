using UnityEngine;

namespace ET
{
	public static class LayerNames
	{
		/// <summary>
		/// UI层
		/// </summary>
		public const string UI = "UI";
		public const string UIHidden = "UIHidden";
		public const string UIBottom = "UIBottom";
		public const string UIMiddle = "UIMiddle";
		public const string UITop = "UITop";

		/// <summary>
		/// 游戏单位层
		/// </summary>
		public const string Unit = "Unit";
		public const string Bullet = "Bullet";
		public const string Collider = "Collider";
		public const string Blue = "Blue";
		public const string Red = "Red";
		public const string Black = "Black";

		/// <summary>
		/// 默认层
		/// </summary>
		public const string Default = "Default";

		public const string Hidden = "Hidden";

		/// <summary>
		/// 通过Layers名字得到对应层
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static int GetLayerInt(string name)
		{
			return LayerMask.NameToLayer(name);
		}

		public static string GetLayerStr(int name)
		{
			return LayerMask.LayerToName(name);
		}
	}
}