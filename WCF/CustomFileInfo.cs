using System.Runtime.Serialization;

namespace WCF
{
	[DataContract]
	public class CustomFileInfo
	{
		[DataMember]
		public string Filename { get; set; }

		[DataMember]
		public long Size { get; set; }
		
		public CustomFileInfo(string filename, long size)
		{
			this.Filename = filename;
			this.Size = size;
		}

		public CustomFileInfo(string filename)
		{
			this.Filename = filename;
		}
	}
}