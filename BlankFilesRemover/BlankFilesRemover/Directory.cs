using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankFilesRemover
{
    public class Directory:File
    {
        public override int Size
        {
            get
            {
                int r = 0;
                foreach (var item in GetFiles())
                {
                    r += item.Size;
                }
                return r;
            }
        }
        public Directory(string path):base(path)
        {
        }
        public override bool Delete()
        {
            var files=GetFiles();
            bool r = true;
            foreach (var item in files)
            {
                if (item.Delete() == false)
                    r = false;
            }
            if (r is false)
            {
                base.Delete();
                return r;
            }
            return base.Delete();
        }
        public List<Directory> GetSubDirectories()
        {
            var dirs=System.IO.Directory.GetDirectories(Path);
            //var files = System.IO.Directory.GetFiles(Path);
            List<Directory> r = new List<Directory>();
            foreach (var item in dirs)
            {
                r.Add(new Directory(item));
            }
            return r;
        }
        /// <summary>
        /// Gets all files and directories.
        /// </summary>
        /// <returns></returns>
        public List<File> GetFiles()
        {
            var files = System.IO.Directory.GetFiles(Path);
            List<File> r = new List<File>(GetSubDirectories());
            foreach (var item in files)
            {
                r.Add(new File(item));
            }
            return r;
        }

        /// <summary>
        /// Deletes all the files that are empty (does not include directories), and gets their paths.
        /// </summary>
        /// <param name="d">The directory to look into.</param>
        /// <returns>Returns the paths of all the files that has been deleted.</returns>
        public static string[] DeleteEmptyFiles(Directory d)
        {
            var files = d.GetFiles();
            List<string> r = new List<string>();
            foreach (var item in files)
            {
                if (item is Directory dir)
                {
                    r.AddRange(DeleteEmptyFiles(dir));
                }
                else
                    if (item is File)
                    if (item.Size == 0)
                    {
                        r.Add(item.Path);
                        item.Delete(); 
                    }
            }
            return r.ToArray();
        }
        public static List<File> FindEmptyFiles(Directory d)
        {
            var files = d.GetFiles();
            var r = new List<File>();
            foreach (var item in files)
            {
                if (item is File fl&&fl.Size==0)
                    r.Add(item);
                if (item is Directory dir)
                    r.AddRange(FindEmptyFiles(dir));
            }
            return r;
        }
    }
    
}
