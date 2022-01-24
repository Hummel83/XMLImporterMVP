using XMLImporter.Business.Events;

namespace XMLImporter.Business.Interfaces
{
    public interface IFileService
    {
        /// <summary>
        /// File reader sent message event
        /// </summary>
        event FileReaderMessageEventHandler FileReaderMessageSent;

        /// <summary>
        /// Read file
        /// </summary>
        /// <param name="path">File path</param>
        void ReadFile(string path);
    }
}
