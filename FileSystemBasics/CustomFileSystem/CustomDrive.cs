using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFileSystemBasics.FileSystem
{
    public class CustomDrive
    {
        #region Properties
        public String Name { get; set; }
        public Int64 Volume { get; set; }
        public Int64 AvailableSpace { get; set; }

        public List<CustomDirectory> Directories { get; set; } = new List<CustomDirectory>();
        #endregion Properties

        #region Constructors
        public CustomDrive(
            String name, Int64 volume,
            Int64 availableSpace)
        {
            Name = name;
            Volume = volume;
            AvailableSpace = availableSpace;
        }
        #endregion Constructors

        #region Methods
        public void AddDirectory(String directoryName) 
        { 
            Directories.Add(new CustomDirectory(directoryName));

            Console.WriteLine($"Directory {directoryName} created");
            Console.ReadLine();
        }
        #endregion Methods
    }
}
