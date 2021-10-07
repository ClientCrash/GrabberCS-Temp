using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabber
{
    class Config
    {
        public Config(String remoteServer,int currentVersion,String name,String description)
        {
            this.remoteServer = remoteServer;
            this.currentVersion = currentVersion;
            this.name = name;
            this.description = description;
        }
        public String remoteServer = "";
        public int currentVersion;
        public String name = "";
        public String description = "";
        
    }
}
