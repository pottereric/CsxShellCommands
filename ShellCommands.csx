#r System.Linq;
using System.Linq;

public void mkdir(string newDirectoryName)
{
	System.IO.Directory.CreateDirectory(newDirectoryName);
}

public void md(string newDirectoryName)
{
	mkdir(newDirectoryName);
}

public void rmdir(string directoryName)
{
	System.IO.Directory.Delete(directoryName);
}

public void dir()
{
    var displayList = new List<Tuple<string, string>>();
	var formatString = "{0,22} {1,10} {2}";
	
    var fileNames = System.IO.Directory.GetFiles(".");
    foreach (var fileName in fileNames)
    {
		var fileData = new System.IO.FileInfo(fileName);
		var display = String.Format(formatString,
	    	fileData.LastWriteTime.ToString(),
	    	String.Empty,
	    	fileData.Name);
		//Console.WriteLine(display); 
		displayList.Add(new Tuple<string, string>(fileData.Name, display));
    }
    var directories = System.IO.Directory.GetDirectories(".");
    foreach (var dir in directories)
    {
		var dirInfo = new System.IO.DirectoryInfo(dir);
		var dirDisplay = String.Format(formatString,
	    	dirInfo.LastAccessTime.ToString(),
	    	"<DIR>",
	    	dirInfo.Name);
		displayList.Add(new Tuple<string, string>(dirInfo.Name, dirDisplay));
    }

    displayList.OrderBy(i => i.Item1);

    foreach(var item in displayList)
    {
		Console.WriteLine(item.Item2);
	}

}

Console.WriteLine("Compiled ShellCommands.csx");
