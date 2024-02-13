namespace MgRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renameAll_btn_Click(object sender, EventArgs e)
        {
            var rootPath = dirPath_txt.Text;
            var currentName = currentName_txt.Text;
            var newName = newName_txt.Text;

            var filesSearchPattern = $"*{currentName}*";
            var foldersSearchPattern = $"*{currentName}*";

            var files = Directory.GetFiles(rootPath, filesSearchPattern, SearchOption.AllDirectories).ToList();
            var folders = Directory.GetDirectories(rootPath, foldersSearchPattern, SearchOption.AllDirectories).ToList();

            var renamedFilesCount = RenameFiles(files, currentName, newName);
            var renamedFoldersCount = RenameFolders(folders, currentName, newName);

            MessageBox.Show($"{renamedFoldersCount} folders has renamed.{Environment.NewLine}{renamedFilesCount} files has renamed.");
        }

        private int RenameFiles(List<string> filePaths, string currentName, string newName)
        {
            int counter = 0;

            foreach (var filePath in filePaths)
            {
                var splited = filePath.Split("\\", StringSplitOptions.RemoveEmptyEntries);

                if (splited.Length > 0)
                {
                    var fileName = splited[^1];

                    if (fileName.Contains(currentName))
                    {
                        var newFileName = fileName.Replace(currentName, newName);
                        var newFilePath = filePath.Replace(fileName, newFileName);

                        if (!File.Exists(newFilePath))
                        {
                            File.Move(filePath, newFilePath);
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }

        private int RenameFolders(List<string> folderPaths, string currentName, string newName)
        {
            int counter = 0;

            foreach (var folderPath in folderPaths)
            {
                var splited = folderPath.Split("\\", StringSplitOptions.RemoveEmptyEntries);

                if (splited.Length > 0)
                {
                    var folderName = splited[^1];

                    if (folderName.Contains(currentName))
                    {
                        var newFolderName = folderName.Replace(currentName, newName);
                        var newFolderPath = folderPath.Replace(folderName, newFolderName);

                        if (!Directory.Exists(newFolderPath))
                        {
                            Directory.Move(folderPath, newFolderPath);
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }
}