using System.Collections.Generic;
using word = System.Collections.Generic.Queue<char>;    //def custom type Queue<char>

namespace TCompressor
{
    class BWTCompression : ICompressionWorker
    {
        public BWTCompression()
        {
           
        }

        public Queue<word> doCompression(Queue<word> data)
        {
            processed_data = data;
            BWT_transformed_data = BWT(processed_data);

            return BWT_transformed_data;
        }

        private Queue<word> processed_data;
        private Queue<word> BWT_transformed_data;

        private char[] word_to_array(word data)
        {
            char[] word_array = new char[data.Count];

            for (var symbol = 0; symbol < word_array.Length; ++symbol)
            {
                word_array[symbol] = data.Dequeue();
            }

            return word_array;
        }

        private Queue<word> BWT(Queue<word> processsed_data)
        {
            char[][][] transformed_data = new char[processed_data.Count][][];

            var number_of_word_array = 0;
            foreach(var one_word in processed_data)
            {
                var word_length = one_word.Count;
                transformed_data[number_of_word_array] = new char[word_length][];
                transformed_data[number_of_word_array][0] = new char[word_length];
                transformed_data[number_of_word_array][0] = word_to_array(one_word);

                for (int number_of_combination = 1; number_of_combination < word_length; ++number_of_combination)
                {
                    transformed_data[number_of_word_array][number_of_combination] = new char[word_length];
                    one_word.Enqueue(one_word.Dequeue());
                    transformed_data[number_of_word_array][number_of_combination] = word_to_array(one_word);
                }

                ++number_of_word_array;
            }

            //sortClass sortBWT = new sortClass(transformed_data);
            //var sorted_BWT_data = sortBWT.getSortedData();
            var BWT_transformed_data = new Queue<word>();

            System.Console.WriteLine("DONE!");
            return BWT_transformed_data;
        }
    }
}
