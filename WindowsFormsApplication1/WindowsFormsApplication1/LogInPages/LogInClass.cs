using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.LogInPages
{
    class LogInClass
    {



        public static void checkEmptyTextBox(String id, String pw)
        {
            if (id == "")
            {
                MessageBox.Show("Kullanıcı adı sahası boş bırakılamaz!", "Eksik Saha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pw == "")
                MessageBox.Show("Şifre sahası boş bırakılamaz!", "Eksik Saha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool checkLogIn(String id, String pw)
        {
            if (id == "asd" && pw == "asd")
                return true;
            else
                return false;
        }

    }
}
