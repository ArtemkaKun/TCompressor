using System.Collections.Generic;
using word = System.Collections.Generic.Queue<char>;    //def custom type Queue<char>

namespace TCompressor
{
    interface ICompressionWorker
    {
        Queue<word> doCompression(Queue<word> processed_data);
    }
}
