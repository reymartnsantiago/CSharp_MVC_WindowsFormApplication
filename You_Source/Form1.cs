using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using You_Source._View;
using You_Source._Controller;
namespace You_Source
{
    public partial class frmMain : Form, ISorting
    {

        public string SortingMethod {
            get{return cmbSortingMethod.Text;}
            set { cmbSortingMethod.Text = value;} 
        }

        public string Output{
            get{return lblOutput.Text;}
            set{ lblOutput.Text = value;}
        }

        public string StringValue {
            get { return txtInput.Text; }
            set { txtInput.Text = value; } 
        }

        public frmMain(){
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e){
            Controller controller = new Controller(this);
            controller.SortString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtInput.Focus();
            cmbSortingMethod.SelectedIndex = 0;
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller(this);
            controller.SortString();
        }

    }
}
