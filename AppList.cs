using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManagement
{
    public class AppList
    {
        public string appPath;
        public string category;
        public string description;


        public AppList(string path,string category,string description)
        {
            this.appPath = path;
            this.category = category;
            this.description = description;
        }
    }
}
