using System;
using Shell32;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace BlankFilesRemover
{
    public class File : IFile
    {
        public readonly static Shell32.Shell shell = new Shell();
        /// <summary>
        /// The <seealso cref="Shell32.Folder"/> that represents the recycle bin.
        /// </summary>
        public readonly static Folder recycleBin = shell.NameSpace(10);


        private System.IO.FileInfo info;

        public string Path { get; protected set; }
        public virtual long Size { get { 
                if(this.Deleted)
                    throw new DeletedFileException("The file has been deleted!");
                return this.info.Length;
            } }
        /// <summary>
        /// Indicates that the file has been deleted.
        /// </summary>
        public bool Deleted { get; private set; } = false;

        /// <summary>
        /// Creats a new <see cref="File"/> instance.
        /// </summary>
        /// <param name="path">The URL of the file.</param>
        public File(string path)
        {
            this.Path = path;
            this.info = new System.IO.FileInfo(path);
        }
        /// <summary>
        /// Deletes the file premenantly.
        /// </summary>
        /// <returns>true if the file deleted succefully, false otherwise.</returns>
        public virtual bool Delete()
        {
            //Debug.WriteLine($"The file with the path: {this.Path}\n" +
            //    $"and size: {this.Size} is about to be deleted!");
            //return true;
            try
            {
                //System.IO.File.Delete(this.Path);
                recycleBin.MoveHere(this.Path, 4096);
            }
            catch (Exception e)
            {
                return false;
            }
            this.Deleted = true;
            return true;
        }
        /// <summary>
        /// Deletes the files and returns whether the operation succeed or not.
        /// </summary>
        /// <param name="files">The list of files to delete.</param>
        /// <returns>true if all the files deleted succefully, false otherwise.</returns>
        public static bool DeleteFiles(IEnumerable<File> files)
        {
            var r = true;
            foreach (var item in files)
            {
                var b=item.Delete();
                if (b == false)
                    r = false;
            }
            return r;
        }
    }

    public static class FileExtensions
    {
        /// <summary>
        /// Returns the path of this list of files.
        /// </summary>
        /// <param name="files">The files to get their paths.</param>
        /// <returns></returns>
        public static string[] GetPaths(this IEnumerable<IFile> files)
        {
            var r = new string[files.Count()];
            int index = 0;
            foreach (var item in files)
            {
                r[index++] = item.Path;
            }
            return r;
        }
    }
}