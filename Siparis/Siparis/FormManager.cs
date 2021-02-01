using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis
{
    class FormManager
    {
        static public Giris f1 = new Giris();
        static public Sepet f3 = new Sepet();
        public static void OpenNewForm1()
        {
            f1.Show();
        }
        public static void hideeForm1()
        {
            f1.Hide();
        }
        public static void OpenNewForm3()
        {
            f3.Show();
        }
        public static void hideeForm3()
        {
            f3.Hide();
        }
    }
}
