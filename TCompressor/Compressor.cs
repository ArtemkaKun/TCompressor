using System.Collections.Generic;
using word = System.Collections.Generic.Queue<char>;    //def custom type Queue<char>

namespace TCompressor
{
    class Compressor : ICompressor
    {
        public void startCompression(string path)
        {
            ITextReader reader = Core.class_fabric.getTextReaderComponent();
            Queue<word> proc_data = reader.startDataProcessing(path);
            Action(Core.class_fabric.getBWTCompression(), proc_data);
        }

        private void Action(ICompressionWorker worker, Queue<word> data)
        {
            worker.doCompression(data);
        }
    }
}
