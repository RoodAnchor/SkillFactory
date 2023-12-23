using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFileSystemBasics.FileSystem
{
    public class CustomDirectory
    {
        #region Properties
        public String Name { get; set; }
        public List<CustomFile> Files { get; set; } = new List<CustomFile>();
        #endregion Properties

        #region Constructors
        public CustomDirectory(String name)
        {
            Name = name;
        }
        #endregion Constructors
    }
}
