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
            watcher.Deleted += new FileSystemEventHandler(Onprocess);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
        }



        private static void Onprocess(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created)
            {
                OnCreated(source, e);
            }
            else if (e.ChangeType == WatcherChangeTypes.Changed)
            {
                OnChanged(source, e);
            }
            else if (e.ChangeType == WatcherChangeTypes.Deleted)
            {
                OnDelete(source, e);
            }
        }



        private static void OnCreated(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Created file event handling.");
        }

        private static void OnChanged(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Changed file event handling.");
        }

        private static void OnDelete(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Delete file event handling.");
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Rename event handling.");
        }
    }
}