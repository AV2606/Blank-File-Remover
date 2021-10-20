namespace BlankFilesRemover
{
    public interface IFile
    {
        /// <summary>
        /// The path of the file.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// The size (in bytes) of the file.
        /// </summary>
        public long Size { get; }
    }
}