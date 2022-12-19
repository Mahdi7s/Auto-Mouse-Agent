namespace AutoMouseControler
{
    partial class OptionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.rdbAlt = new System.Windows.Forms.RadioButton();
            this.rdbShift = new System.Windows.Forms.RadioButton();
            this.rdbControl = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRClick = new System.Windows.Forms.TextBox();
            this.txt2Click = new System.Windows.Forms.TextBox();
            this.txtClick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutoRunMinute = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNone);
            this.groupBox1.Controls.Add(this.rdbAlt);
            this.groupBox1.Controls.Add(this.rdbShift);
            this.groupBox1.Controls.Add(this.rdbControl);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifiers";
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Checked = true;
            this.rdbNone.Location = new System.Drawing.Point(18, 19);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(51, 17);
            this.rdbNone.TabIndex = 3;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "None";
            this.rdbNone.UseVisualStyleBackColor = true;
            this.rdbNone.CheckedChanged += new System.EventHandler(this.rdbNone_CheckedChanged);
            // 
            // rdbAlt
            // 
            this.rdbAlt.AutoSize = true;
            this.rdbAlt.Location = new System.Drawing.Point(18, 52);
            this.rdbAlt.Name = "rdbAlt";
            this.rdbAlt.Size = new System.Drawing.Size(37, 17);
            this.rdbAlt.TabIndex = 0;
            this.rdbAlt.TabStop = true;
            this.rdbAlt.Text = "Alt";
            this.rdbAlt.UseVisualStyleBackColor = true;
            this.rdbAlt.CheckedChanged += new System.EventHandler(this.rdbAlt_CheckedChanged);
            // 
            // rdbShift
            // 
            this.rdbShift.AutoSize = true;
            this.rdbShift.Location = new System.Drawing.Point(18, 116);
            this.rdbShift.Name = "rdbShift";
            this.rdbShift.Size = new System.Drawing.Size(46, 17);
            this.rdbShift.TabIndex = 2;
            this.rdbShift.TabStop = true;
            this.rdbShift.Text = "Shift";
            this.rdbShift.UseVisualStyleBackColor = true;
            this.rdbShift.CheckedChanged += new System.EventHandler(this.rdbShift_CheckedChanged);
            // 
            // rdbControl
            // 
            this.rdbControl.AutoSize = true;
            this.rdbControl.Location = new System.Drawing.Point(18, 84);
            this.rdbControl.Name = "rdbControl";
            this.rdbControl.Size = new System.Drawing.Size(58, 17);
            this.rdbControl.TabIndex = 1;
            this.rdbControl.TabStop = true;
            this.rdbControl.Text = "Control";
            this.rdbControl.UseVisualStyleBackColor = true;
            this.rdbControl.CheckedChanged += new System.EventHandler(this.rdbControl_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRClick);
            this.groupBox2.Controls.Add(this.txt2Click);
            this.groupBox2.Controls.Add(this.txtClick);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keys";
            // 
            // txtRClick
            // 
            this.txtRClick.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRClick.Location = new System.Drawing.Point(74, 104);
            this.txtRClick.Name = "txtRClick";
            this.txtRClick.ReadOnly = true;
            this.txtRClick.Size = new System.Drawing.Size(120, 20);
            this.txtRClick.TabIndex = 5;
            this.txtRClick.Text = "R";
            this.txtRClick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRClick_KeyDown);
            // 
            // txt2Click
            // 
            this.txt2Click.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt2Click.Location = new System.Drawing.Point(74, 65);
            this.txt2Click.Name = "txt2Click";
            this.txt2Click.ReadOnly = true;
            this.txt2Click.Size = new System.Drawing.Size(120, 20);
            this.txt2Click.TabIndex = 4;
            this.txt2Click.Text = "D";
            this.txt2Click.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt2Click_KeyDown);
            // 
            // txtClick
            // 
            this.txtClick.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtClick.Location = new System.Drawing.Point(74, 27);
            this.txtClick.Name = "txtClick";
            this.txtClick.ReadOnly = true;
            this.txtClick.Size = new System.Drawing.Size(120, 20);
            this.txtClick.TabIndex = 3;
            this.txtClick.Text = "C";
            this.txtClick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClick_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RClick :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2Click :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click :";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(133, 332);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(22, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Auto Run Minute :";
            // 
            // txtAutoRunMinute
            // 
            this.txtAutoRunMinute.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAutoRunMinute.Location = new System.Drawing.Point(109, 300);
            this.txtAutoRunMinute.Name = "txtAutoRunMinute";
            this.txtAutoRunMinute.ReadOnly = true;
            this.txtAutoRunMinute.Size = new System.Drawing.Size(88, 20);
            this.txtAutoRunMinute.TabIndex = 8;
            this.txtAutoRunMinute.Text = "1";
            this.txtAutoRunMinute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAutoRunMinute_KeyDown);
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 362);
            this.Controls.Add(this.txtAutoRunMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.RadioButton rdbAlt;
        private System.Windows.Forms.RadioButton rdbShift;
        private System.Windows.Forms.RadioButton rdbControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtRClick;
        public System.Windows.Forms.TextBox txt2Click;
        public System.Windows.Forms.TextBox txtClick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutoRunMinute;
    }
}