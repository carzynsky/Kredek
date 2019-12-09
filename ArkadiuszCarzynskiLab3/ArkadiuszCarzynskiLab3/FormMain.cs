using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin(textBoxUserName.Text, textBoxPassword.Text);
            FormWarehouse fw = new FormWarehouse();

            if(signin.SignInWareHouse())
            {
                MessageBox.Show("Zalogowano");
                fw.Show();
            }
            else
            {
                MessageBox.Show("Nie udało się");
            }
        }
    }
}
