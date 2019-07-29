using System.Collections.Generic;
using word = System.Collections.Generic.Queue<char>;    //def custom type Queue<char>

namespace TCompressor
{
    class Compressor
    {
        public Compressor(Queue<word> data)
        {
            processed_data = data;

        }

        private Queue<word> processed_data;
        private Queue<string> RLE(Queue<word> transformed_BWT_data)
        {
            Queue<string> compressed_data = new Queue<string>();

            return compressed_data;
        }

        private Queue<word> BWT(Queue<word> processsed_data)
        {
            Queue<word> transformed_data = new Queue<word>();

            foreach(var one_word in processed_data)
            {
                for (int number_of_combination = 0; number_of_combination < one_word.Count; ++number_of_combination)
                {

                }
            }

            return transformed_data;
        }
    }
}
