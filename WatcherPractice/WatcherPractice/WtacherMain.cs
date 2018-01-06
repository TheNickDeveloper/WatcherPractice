using System;
using System.IO;

namespace WatcherPractice
{
    class WtacherMain
    {
        public static void WatchStart(string path, string filter)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;

            watcher.Filter = filter;

            watcher.Changed += new FileSystemEventHandler(Onprocess);
            watcher.Created += new FileSystemEventHandler(Onprocess);

        }


        private static void Onprocess(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created)
            {
                Oncreated(source, e);
            } 
        }

        private static void Oncreated(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Created file event handling.");
        }
    }
}