using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManagement
{
    class FileHandle
    {
        public void addApps(AppList applist, int count)
        {
            using(StreamWriter sw = File.AppendText("appList.txt"))
            {
                sw.WriteLine($"\t---AppList-{count}");
                sw.WriteLine(applist.appPath);
                sw.WriteLine(applist.category);
                sw.WriteLine(applist.description);

                sw.Close();
            }
        }

        public void newAddApps(List<AppList> newlist, int count)
        {
            using (StreamWriter sw = File.CreateText("appList.txt"))
            {
                
                foreach (AppList item in newlist)
                {
                    sw.WriteLine($"\t---AppList-{count}");
                    sw.WriteLine(item.appPath);
                    sw.WriteLine(item.category);
                    sw.WriteLine(item.description);

                    
                }
                sw.Close();

            }
        }
        public List<AppList> readFile()
        {

            List<AppList> appList = new List<AppList>();
            string line = "";
            using (StreamReader sr = new StreamReader("appList.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {

                    appList.Add(new AppList(sr.ReadLine(), sr.ReadLine(), sr.ReadLine()));
                }

                sr.Close();
            }
            return appList;
        }

    }
}
