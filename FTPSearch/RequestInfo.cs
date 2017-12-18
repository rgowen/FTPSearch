using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPSearch
{
    class RequestInfo
    {
        public string Host; // Right now, this includes the path, THIS WILL BE FIXED LATER
        public string Username; 
        public string Password;
        public string Port;
        public bool HasCredentials;
        public bool HasPort;
        public RequestInfo()
        {

        }
        public RequestInfo(string host, string username, string password, string port, bool hasCredentials, bool hasPort)
        {
            this.Host = host;
            this.Username = username;
            this.Password = password;
            this.Port = port;
            this.HasCredentials = hasCredentials;
            this.HasPort = hasPort;
        }
        public override string ToString()
        {
            return (Host + " " + Port + " " + Username + " " + Password);
        }
    }
}
