using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetrolBunkManagement.src
{
    enum DBoperation
    {
        kdefault =0 ,
        kAdd,
        kUpdate,
        kDelete,
        kCreateTable,
        kQuery
    };
    class cUtility
    {
        public void shutdown(Form iform ,bool iAsk = true)
        {
            if (MessageBox.Show("Are you sure you want to exit ? ", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                iform.Show();
            }
        }
    }
}
