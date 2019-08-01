using System.Collections.Generic;
using word = System.Collections.Generic.Queue<char>;    //def custom type Queue<char>

namespace TCompressor
{
    interface ITextReader
    {
        Queue<word> startDataProcessing(string path);
    }
}
