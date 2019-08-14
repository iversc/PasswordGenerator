using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;

namespace PassGen
{
    public partial class PassGenMainForm : Form
    {
        public PassGenMainForm()
        {
            InitializeComponent();
        }

        private void PassGenMainForm_Load(object sender, EventArgs e)
        {
            passLen.Value = 12;
            Generate_Click(sender, e);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int passwordLength = Decimal.ToInt32(passLen.Value);
            string password = System.Web.Security.Membership.GeneratePassword(passwordLength, 1);

            Password.Text = password;

            Clipboard.SetText(password);
        }
    }
}
