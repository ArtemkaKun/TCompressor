using System.Windows.Forms;

namespace TCompressor
{
    class UIcontroller : IUI
    {
        public UIcontroller()
        {
                      
        }

        public void ShowUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }
    }
}
