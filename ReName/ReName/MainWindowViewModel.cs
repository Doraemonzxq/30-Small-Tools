using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Paket;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReName
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string ? _folderPath;
        [ObservableProperty]
        private string ? _renameRule;
        [ObservableProperty]
        private ObservableCollection<FileMode> _files;
        public MainWindowViewModel()
        {

        }
        [RelayCommand]
        public void SelectFolderCommand(string[] paths)
        {
            Files.Clear();
            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    Files.Add(new FileItem(path));
                }
            }
        }
        [RelayCommand]
        public void ApplyRenameCommand() { }
    }
}
