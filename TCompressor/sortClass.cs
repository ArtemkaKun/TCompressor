using System.Collections.Generic;
using word = System.Collections.Generic.Queue<char>;

namespace TCompressor
{
    class sortClass
    {
        public sortClass(char[][][] transformed_data)
        {
            transformed_BWT_data = transformed_data;
            sorted_transformed_BWT_data = BubbleSort(transformed_data);
        }

        public char[][][] getSortedData()
        {
            return sorted_transformed_BWT_data;
        }

        private char[][][] transformed_BWT_data;
        private char[][][] sorted_transformed_BWT_data;

        private char[][][] BubbleSort(char[][][] data)
        {
            for (var one_word = 0; one_word < data.Length; ++one_word)
            {
                for (var step_by_combination = data[one_word].Length - 1; step_by_combination > 0; --step_by_combination)
                {
                    for (var first_symbol = 0; first_symbol < step_by_combination; ++first_symbol)
                    {
                        if (data[one_word][step_by_combination][first_symbol] > data[one_word][step_by_combination + 1][first_symbol])
                        {
                            char[] temporary;

                            temporary = data[one_word][step_by_combination];
                            data[one_word][step_by_combination] = data[one_word][step_by_combination + 1];
                            data[one_word][step_by_combination + 1] = temporary;
                        }
                    }
                }
            }

            return data;
        }
    }
}
