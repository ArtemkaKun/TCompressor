using System.Windows.Forms;

namespace TCompressor
{
    class UIcontroller
    {
        public UIcontroller()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
