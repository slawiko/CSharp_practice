using System.IO;
using System.Collections.Generic;

namespace WCF
{
	public class Service : IService
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new System.ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}

		public List<CustomFileInfo> GetFileList(string path, string searchPattern)
		{
			List<CustomFileInfo> fileinfo = new List<CustomFileInfo>();
			string[] filePaths = Directory.GetFiles(path, searchPattern);

			foreach (var filePath in filePaths)
			{
				FileInfo temp = new FileInfo(filePath);
				string filename = temp.Name;
				long size = temp.Length;
				fileinfo.Add(new CustomFileInfo(filename, size));
			}

			return fileinfo;
		}

		public Stream GetStream(string path)
		{
			return new FileStream(path, FileMode.Open);
		}
	}
}
