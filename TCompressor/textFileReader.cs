using System.Collections.Generic;
using System.IO;
using word = System.Collections.Generic.Queue<char>;    //def custom type Queue<char>

namespace TCompressor
{
    class textFileReader
    {
        public textFileReader(string file_path)
        {
            file_path_to_compress = file_path;
            processingFile();

        }

        private string file_path_to_compress;
        private Queue<word> processed_uploaded_text;
        private void processingFile()
        {
            var file_text = File.ReadAllText(file_path_to_compress);  //read all text in one line
            processed_uploaded_text = lineProcessing(file_text);
        }

        private Queue<word> lineProcessing(string text)
        {
            
            Queue<word> words = new Queue<word>();  //word is the custom type, that was def in file top
            word buffer = new word();

            for (var symbol_count = 0; symbol_count < text.Length; ++symbol_count)
            {
                if (text[symbol_count] != ' ' && text[symbol_count] != '.' && text[symbol_count] != ',')
                {
                    buffer.Enqueue(text[symbol_count]); //store one char in word
                } 
                else 
                {
                    buffer.Enqueue(text[symbol_count]); //store end of word symbol
                    words.Enqueue(buffer);  //store one word in words queue
                    //System.Console.WriteLine(words.Count); DEBUG
                    buffer.Clear(); //clear buffer
                }
            }

            return words;
        }
    }
}
