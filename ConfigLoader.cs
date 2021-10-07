using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Grabber
{
    class ConfigLoader
    {
        public Config loadConfig(String file)
        {

            String filetext = File.ReadAllText(file);
            String[] info = filetext.Split(';');
            String server = info[0] ?? "127.0.0.1";
            String name = info[1] ?? "example";
            int version = int.Parse(info[2]);
            String description = info[3] ?? "";
            Config c = new Config(server,version,name,description);
            return c;

        }
    }
}
