namespace TCompressor
{
    class ClassFabric : IFabric
    {
        public ClassFabric()
        {

        }

        public UIcontroller getUIComponent()
        {
            UImanager = new UIcontroller();
            return UImanager;
        }

        public Compressor getCompressorComponent()
        {
            compressor = new Compressor();
            return compressor;
        }

        public textFileReader getTextReaderComponent()
        {
            reader = new textFileReader();
            return reader;
        }

        public BWTCompression getBWTCompression()
        {
            BWT_transformer = new BWTCompression();
            return BWT_transformer;
        }

        private UIcontroller UImanager;
        private Compressor compressor;
        private textFileReader reader;
        private BWTCompression BWT_transformer;
    }
}
