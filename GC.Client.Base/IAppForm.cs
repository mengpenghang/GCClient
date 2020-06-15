using System.Windows.Forms;

namespace GC.Client.Base
{
    public interface IAppForm
    {
        Form MdiParent { get; set; }

        void Show();

        void Activate();
    }
}
