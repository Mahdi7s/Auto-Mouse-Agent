using System;
using System.Windows.Forms;

namespace AutoMouseControler
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Modifiers = 0;
            ClickKey = Keys.C;
            RightClickKey = Keys.R;
            DoubleClickKey = Keys.D;
            AutoRunMinute = 1;
        }
        //================"Properties"==============
        public MODIFIERS Modifiers { get; set; }
        public Keys ClickKey { get; set; }
        public Keys DoubleClickKey { get; set; }
        public Keys RightClickKey { get; set; }
        public int AutoRunMinute { get; set; }
        //=======================Events=============
        private void txtClick_KeyDown(object sender, KeyEventArgs e)
        {
            txtClick.Text = e.KeyCode.ToString();
            ClickKey = e.KeyCode;
        }

        private void txt2Click_KeyDown(object sender, KeyEventArgs e)
        {
            txt2Click.Text = e.KeyCode.ToString();
            DoubleClickKey = e.KeyCode;
        }

        private void txtRClick_KeyDown(object sender, KeyEventArgs e)
        {
            txtRClick.Text = e.KeyCode.ToString();
            RightClickKey = e.KeyCode;
        }

        private void rdbAlt_CheckedChanged(object sender, EventArgs e)
        {
            Modifiers = MODIFIERS.MOD_ALT;
        }

        private void rdbControl_CheckedChanged(object sender, EventArgs e)
        {
            Modifiers = MODIFIERS.MOD_CONTROL;
        }

        private void rdbShift_CheckedChanged(object sender, EventArgs e)
        {
            Modifiers = MODIFIERS.MOD_SHIFT;
        }

        private void rdbNone_CheckedChanged(object sender, EventArgs e)
        {
            Modifiers = 0;
        }

        private void txtAutoRunMinute_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue) && txtAutoRunMinute.TextLength <= 4)
            {
                txtAutoRunMinute.Text += ((char)e.KeyValue).ToString();
            }
            else if(e.KeyCode == Keys.Back)
            {
                txtAutoRunMinute.Text = txtAutoRunMinute.Text.Substring(0,txtAutoRunMinute.TextLength -1);
            }
            if(txtAutoRunMinute.TextLength == 0) txtAutoRunMinute.Text = "1";
            AutoRunMinute = int.Parse(txtAutoRunMinute.Text.Trim());
        }
    }
}
