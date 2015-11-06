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
    var fileNames = System.IO.Directory.GetFiles(".");
    foreach (var fileName in fileNames)
    {
	var fileData = new System.IO.FileInfo(fileName);
	var display = String.Format("{0} {1} {2}",
	    fileData.LastWriteTime.ToString(),
	    String.Empty,
	    fileData.Name);
	Console.WriteLine(display); 
    }
}
