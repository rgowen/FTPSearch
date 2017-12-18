using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPSearch
{
    class DirectoryItem
    {
        public string BasePath;
        public string Permissions;
        public string Inodes;
        public string Owner;
        public string Group;
        public string Size;
        public string Month;
        public string Day;
        public string Year;
        public string Filename;
        public bool IsDirectory;
        public string FullPath;
        public DirectoryItem()
        {

        }
        public DirectoryItem(string basePath, string permissions, string inodes, string owner, string group, string size, string month, string day, string year, string filename, bool isDirectory)
        {
            this.BasePath = basePath;
            this.Permissions = permissions;
            this.Inodes = inodes;
            this.Owner = owner;
            this.Group = group;
            this.Size = size;
            this.Month = month;
            this.Day = day;
            this.Year = year;
            this.Filename = filename;
            this.IsDirectory = isDirectory;
            FullPath = FtpUtils.UriBuilder(BasePath, Filename);
        }
        public override string ToString()
        {
            return Permissions + " " + Inodes + " " + Owner + " " + Group + " " + Size + " " + Month + " " + Day + " " + Year + " " + Filename + " Is Directory: " + IsDirectory;
        }
    }
}
