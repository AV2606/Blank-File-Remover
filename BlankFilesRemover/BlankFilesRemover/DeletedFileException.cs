using System;
using System.Runtime.Serialization;

namespace BlankFilesRemover
{
    [Serializable]
    internal class DeletedFileException : ApplicationException
    {
        public DeletedFileException()
        {
        }

        public DeletedFileException(string message) : base(message)
        {
        }

        public DeletedFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeletedFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}