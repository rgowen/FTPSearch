using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FTPSearch
{
    static class FtpUtils
    {
        public static List<DirectoryItem> DirectoryListingParser(string dirListing, string basePath)
        {
            List<DirectoryItem> items = new List<DirectoryItem>();
            string[] lines = dirListing.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in lines) 
            {
                DirectoryItem newItem = new DirectoryItem();
                newItem.BasePath = basePath;
                string lineExceptFilename = s.Substring(0, 55);
                string[] lineExceptFilenameArray = lineExceptFilename.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lineExceptFilenameArray.Length; i++)
                {
                    switch(i)
                    {
                        case 0:                      
                            newItem.Permissions = lineExceptFilenameArray[i];
                            if (lineExceptFilenameArray[i].StartsWith("dr"))
                            {
                                newItem.IsDirectory = true;
                            }
                            else newItem.IsDirectory = false;
                            break;
                        case 1:
                            newItem.Inodes = lineExceptFilenameArray[i];
                            break;
                        case 2:
                            newItem.Owner = lineExceptFilenameArray[i];
                            break;
                        case 3:
                            newItem.Group = lineExceptFilenameArray[i];
                            break;
                        case 4:
                            newItem.Size = lineExceptFilenameArray[i];
                            break;
                        case 5:
                            newItem.Month = lineExceptFilenameArray[i];
                            break;
                        case 6:
                            newItem.Day = lineExceptFilenameArray[i];
                            break;
                        case 7:
                            newItem.Year = lineExceptFilenameArray[i];
                            break;
                    }
                }
                newItem.Filename = s.Substring(55).Trim();
                items.Add(newItem);
            }
            return items;
        }
        public static string UriBuilder(string uriBase, string itemName)
        {
            if (uriBase.EndsWith(@"/"))
            {
                uriBase = uriBase.Substring(0, uriBase.Length - 1);
            }
            string newUri = uriBase + @"/" + itemName;
            return newUri;
        }
        public static string UriBuilder(string uriBase, string[] subfolders)
        {
            if (uriBase.EndsWith(@"/"))
            {
                uriBase = uriBase.Substring(0, uriBase.Length - 1);
            }

            StringBuilder newUri = new StringBuilder(uriBase);
            foreach(string folder in subfolders)
            {
                newUri.Append(@"/" + folder);
            }
            return newUri.ToString();
        }
        public static bool Match(string searchTerm, string filename)
        {
            if (filename.ToLower().IndexOf(searchTerm.ToLower()) == -1) return false;
            else return true;
        }

        public static List<RequestInfo> RequestInfoList(string[] lines)
        {
            List<RequestInfo> infoList = new List<RequestInfo>();
            foreach (string line in lines)
            {
                infoList.Add(RequestInfoBuilder(line));
            }
            return infoList;
        }
        public static RequestInfo RequestInfoBuilder(string line)
        {
            RequestInfo info = new RequestInfo();
            info.Host = line;
            return info;
        }

    }
}
