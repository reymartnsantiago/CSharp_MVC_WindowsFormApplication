using System.Windows.Forms;
using System; 

using System.Collections.Generic; 

using System.ComponentModel; 

using System.Data; 

using System.Drawing; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks;
namespace You_Source
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbSortingMethod = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(22, 20);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(307, 56);
            this.txtInput.TabIndex = 0;
            // 
            // cmbSortingMethod
            // 
            this.cmbSortingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortingMethod.FormattingEnabled = true;
            this.cmbSortingMethod.Items.AddRange(new object[] {
            "QuickSort",
            "BubbleSort"});
            this.cmbSortingMethod.Location = new System.Drawing.Point(22, 104);
            this.cmbSortingMethod.Name = "cmbSortingMethod";
            this.cmbSortingMethod.Size = new System.Drawing.Size(307, 37);
            this.cmbSortingMethod.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(22, 152);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(307, 95);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "S&ORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblOutput);
            this.panel2.Location = new System.Drawing.Point(335, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 227);
            this.panel2.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(16, 70);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 108);
            this.lblOutput.TabIndex = 0;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(857, 255);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cmbSortingMethod);
            this.Controls.Add(this.txtInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private TextBox txtInput;
        private ComboBox cmbSortingMethod;
        private Button btnSort;
        private Panel panel2;
        private Label lblOutput;
    }
}

