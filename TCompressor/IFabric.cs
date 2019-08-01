namespace TCompressor
{
    interface IFabric
    {
        UIcontroller getUIComponent();
        Compressor getCompressorComponent();
        textFileReader getTextReaderComponent();
        BWTCompression getBWTCompression();
    }
}
