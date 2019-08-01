using System;

namespace TCompressor
{
    static class Core
    {
        static public IFabric class_fabric = new ClassFabric();

        [STAThreadAttribute]       
        static void Main()
        {           
            IUI ui_manager = class_fabric.getUIComponent();
                      
            ui_manager.ShowUI();

        }

        static public void startCompression(string path)
        {
            ICompressor compressor_block = class_fabric.getCompressorComponent();
            compressor_block.startCompression(path);
        }
    }
}
