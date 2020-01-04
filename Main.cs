using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sample
{
	static void Main(string[] args)
	{
		IniFile ini_file;
		string  buffer;

		// Instance a new class
		ini_file = new IniFile();

		// Load existing file from disk (in file not exist no data will load)
		ini_file.Load("example.ini");

		// Try to load Value of GenericKey
		// [GenericSessio]
		// GenericKey="GenericValueWithQuote"
		buffer = ini_file.GetKeyValue("GeneralSession", "GenericKey");
		if (string.IsNullOrEmpty(buffer) || string.IsNullOrWhiteSpace(buffer))
		{
			// If session or key not exist set a defauklt value
			buffer = "GenericValueWithQuote";
			ini_file.SetKeyValue("GeneralSession", "GenericKey", buffer);
		}

		// Print data
		Console.Out.WriteLine("[GenericSessio]");
		Console.Out.WriteLine("\tGenericKey=" + buffer);

		// Save file to disk
		ini_file.Save("example.ini");
	}
}
