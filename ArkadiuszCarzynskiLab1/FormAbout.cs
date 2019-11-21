using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab1
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            labelName.Text = formName;
        }
        public string formName = "text";

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelName.Text = formName;
        }
    }
}
