using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReName.Models
{
    public class FileModel:ObservableObject
    {
        private string  OldFilePath { get; set; }
        private string  NewFilePath { get; set; }
    }
}
