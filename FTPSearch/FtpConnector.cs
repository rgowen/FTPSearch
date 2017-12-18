using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace FTPSearch
{
    class FtpConnector
    {
        RichTextBox OutputBox;
        
        public FtpConnector(RichTextBox outputBox)
        {
            this.OutputBox = outputBox;
        }
        private void AddLine(string newLine)
        {
            List<string> all = new List<String>();
            all.AddRange(OutputBox.Lines);
            all.Add(newLine);
            OutputBox.Lines = all.ToArray();
        }
        private void AddLines(string[] newLines)
        {
            List<string> all = new List<String>();
            all.AddRange(OutputBox.Lines);
            all.AddRange(newLines);
            OutputBox.Lines = all.ToArray();
        }
        public void Connect(string[] addresses, string searchQuery)
        {
            List<RequestInfo> allRequestInfo = FtpUtils.RequestInfoList(addresses);

            AddLine("Beginning conections...");
            foreach (RequestInfo info in allRequestInfo)
            {
                AddLine("Connecting to " + info.Host);
                try
                {
                    List<string> resultList = Search(info.Host, searchQuery, FtpUtils.DirectoryListingParser(GetDirectoryListing(info), info.Host));
                    AddLine("FOUND RESULTS:");
                    AddLines(resultList.ToArray());
                }
                catch(WebException)
                {
                    AddLine("WebException, Something failed.");
                }
            }
        }
        private List<string> Search(string baseAddr, string query, List<DirectoryItem> directories)
        {
            List<string> matches = new List<string>();
            foreach (DirectoryItem item in directories)
            {
                if (item.IsDirectory)
                {
                    string cd = FtpUtils.UriBuilder(baseAddr, item.Filename);
                    AddLine("Searching: " + cd);
                    try
                    {
                        List<DirectoryItem> newDir = FtpUtils.DirectoryListingParser(GetDirectoryListing(new RequestInfo() { Host = cd } ), baseAddr);
                        matches.AddRange(Search(cd, query, newDir));
                    }
                    catch (Exception)
                    {
                        AddLine("Searching folder " + cd);
                    }
                }
                if (FtpUtils.Match(query, item.Filename))
                {
                    matches.Add(FtpUtils.UriBuilder(baseAddr, item.Filename));
                } 
            }
            return matches;
        }
        private string GetDirectoryListing(RequestInfo info)
        {
            string output;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(info.Host);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            output = reader.ReadToEnd();
            reader.Close();
            response.Close();
            // need to handle response.statusDescription at some point, in case directory listing was denied or something
            return output;
        }
        private string CheckServer(RequestInfo info)
        {
            string output;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(info.Host);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            output = response.StatusDescription;
            response.Close();
            return info.Host + ": " + output;
        }
    }
}
