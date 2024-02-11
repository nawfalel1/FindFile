public class FindFile {


    public static List<String> findFile(String directoryPath)
    {
        List<String> list = new List<string>();
        if (Directory.Exists(directoryPath))
        {

            String[] files = Directory.GetFiles(directoryPath);

            foreach (String file in files)
            {
                if (Path.GetFileName(file).StartsWith("Fab") && Path.GetFileName(file).EndsWith(".txt"))
                {
                    list.Add(file);
                }
            }

        }
        else
        {
            throw new Exception("Directory does not exist.");
        }
        return list;
    }
    static void Main() {
        Console.WriteLine("Donnez le nom du dossier");
        String directory = Console.ReadLine();
        Console.WriteLine("\n");
        List<String> list = findFile(directory);
        
        foreach(String file in list)
        {
            Console.WriteLine(file);
        }
    }
    

}

