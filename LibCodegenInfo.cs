using Ans.Net10.Common;

namespace Ans.Net10.Codegen
{

	public static class LibCodegenInfo
	{
		public static string GetName() => SuppApp.GetName();
		public static string GetVersion() => SuppApp.GetVersion();
		public static string GetDescription() => SuppApp.GetDescription();
	}

}
