using System;
using System.IO;

namespace WatcherPractice
{
    class WtacherHelper
    {
        private string _path;
        private string _filer;

        public WtacherHelper(string path, string filer)
        {
            this._path = path;
            this._filer = filer;
        }

        public void WatchStart()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = _path;
            watcher.Filter = _filer;

            watcher.Changed += new FileSystemEventHandler(Onprocess);
            watcher.Created += new FileSystemEventHandler(Onprocess);
            watcher.Deleted += new FileSystemEventHandler(Onprocess);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
        }



        private void Onprocess(object source, FileSystemEventArgs e)
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



        private void OnCreated(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Created file event handling.");
        }

        private void OnChanged(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Changed file event handling.");
        }

        private void OnDelete(object source, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine("Delete file event handling.");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Rename event handling.");
        }
    }
}