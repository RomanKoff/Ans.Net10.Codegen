using System.Xml.Serialization;

namespace Ans.Net10.Codegen.Schema
{

	public class ItemXmlElement
	{
		[XmlAttribute("key")]
		public string Key { get; set; }

		[XmlAttribute("value")]
		public string Value { get; set; }
	}

}