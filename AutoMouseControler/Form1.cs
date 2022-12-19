using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MouseNS;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AutoMouseControler
{
    public enum MODIFIERS
    {
        MOD_ALT = 0x0001,
        MOD_CONTROL = 0x0002,
        MOD_SHIFT = 0x0004,
        MOD_WIN = 0x0008,
        MOD_KEYUP = 0x1000
    }

    public enum DOING { AutoRunning,RUNNIG, RECORDING, STOP_RECORDING,BLANK }

    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        private static extern bool RegisterHotKey(IntPtr handle, int id, MODIFIERS modifiers, Keys key);
        [DllImport("User32.dll")]
        private static extern bool UnregisterHotKey(IntPtr handle, int id);
        private Keys m_Click = Keys.C;
        private Keys m_2Click = Keys.D;
        private Keys m_RClick = Keys.R;
        private MODIFIERS m_Modifiers = MODIFIERS.MOD_ALT;
        private int m_Seconds = 0;
        private int m_AutoRunMinute = 0;
        private int m_Counter = 0;

        private OptionsForm m_Option = new OptionsForm();
        private DOING m_Doing = DOING.BLANK;
        private CRecord m_Records = new CRecord();
        //=============================================================================================
        public Form1()
        {
            InitializeComponent();
            RegisterHotKey();
        }

        private void RegisterHotKey()
        {
            RegisterHotKey(this.Handle, 1, m_Modifiers, m_Click); //Rgister Click
            RegisterHotKey(this.Handle, 2, m_Modifiers, m_2Click); //Rgister DoubleClick
            RegisterHotKey(this.Handle, 3, m_Modifiers, m_RClick); //Rgister RightClick
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 786 && m_Doing == DOING.RECORDING)
            {
                if (m.WParam.ToInt32() == 1)
                {
                    m_Records.Points.Add(Mouse.Position);
                    m_Records.Events.Add(EVENTS.CLICK);
                    m_Records.Seconds.Add(m_Seconds);
                    m_Seconds = 0;
                    Mouse.ClickAt(Mouse.Position);
                }
                else if (m.WParam.ToInt32() == 2)
                {
                    m_Records.Points.Add(Mouse.Position);
                    m_Records.Events.Add(EVENTS.DOUBLE_CLICK);
                    m_Records.Seconds.Add(m_Seconds);
                    m_Seconds = 0;
                    Mouse.DoubleClickAt(Mouse.Position);
                }
                else if (m.WParam.ToInt32() == 3)
                {
                    m_Records.Points.Add(Mouse.Position);
                    m_Records.Events.Add(EVENTS.RIGHT_CLICK);
                    m_Records.Seconds.Add(m_Seconds);
                    m_Seconds = 0;
                    Mouse.RightClickAt(Mouse.Position);
                }
            }
            else
            base.WndProc(ref m);
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Save()
        {
            string path = Application.StartupPath + @"\Records.amc";
            if (File.Exists(path)) File.Delete(path);
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter Serializer = new BinaryFormatter();
            Serializer.Serialize(stream, m_Records);
            stream.Close();
        }

        private void Recover()
        {
            string path = Application.StartupPath + @"\Records.amc";
            if (File.Exists(path))
            {
                FileStream stream = new FileStream(path,FileMode.Open,FileAccess.Read);
                BinaryFormatter Desrializer = new BinaryFormatter();
                m_Records = (CRecord)Desrializer.Deserialize(stream);
                stream.Close();
            }
            else MessageBox.Show("File Not Exit ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Doing = DOING.RUNNIG;
            runToolStripMenuItem.Enabled = false;
            recordToolStripMenuItem.Enabled = false;
            stopRecordingToolStripMenuItem.Enabled = false;
            optionToolStripMenuItem.Enabled = false;
            Recover();
            m_Seconds = 0;
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Records = new CRecord();
            m_Doing = DOING.RECORDING;
            runToolStripMenuItem.Enabled = false;
            recordToolStripMenuItem.Enabled = false;
            m_Seconds = 0;
        }

        private void stopRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Doing = DOING.STOP_RECORDING;
            Save();
            runToolStripMenuItem.Enabled = true;
            recordToolStripMenuItem.Enabled = true;
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_Option.ShowDialog() == DialogResult.OK)
            {
                m_Modifiers = m_Option.Modifiers;
                m_Click = m_Option.ClickKey;
                m_2Click = m_Option.DoubleClickKey;
                m_RClick = m_Option.RightClickKey;
                RegisterHotKey();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
            UnregisterHotKey(this.Handle, 3);
            Environment.Exit(Environment.ExitCode);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            ++m_Seconds;
            if (m_Doing == DOING.AutoRunning && m_Seconds == 60)
            {
                ++m_AutoRunMinute; m_Seconds = 0;
            }
            if (m_Doing == DOING.AutoRunning && m_AutoRunMinute == m_Option.AutoRunMinute)
            {
                m_Doing = DOING.RUNNIG;
                m_Seconds = 0;
                if (m_Records.Count == 0) Recover();
            }
            if (m_Doing == DOING.RUNNIG)
            {
                if (m_Seconds == m_Records.Seconds[m_Counter])
                {
                    switch (m_Records.Events[m_Counter])
                    {
                        case EVENTS.CLICK:
                            Mouse.ClickAt(m_Records.Points[m_Counter]);
                            break;
                        case EVENTS.DOUBLE_CLICK:
                            Mouse.DoubleClickAt(m_Records.Points[m_Counter]);
                            break;
                        case EVENTS.RIGHT_CLICK:
                            Mouse.RightClickAt(m_Records.Points[m_Counter]);
                            break;
                    }
                    m_Seconds = 0;
                    ++m_Counter;
                    if (m_Counter == m_Records.Count)
                    {
                        m_Counter = 0;
                        if (autoRunToolStripMenuItem.Checked)
                        {
                            m_Doing = DOING.AutoRunning;
                            m_AutoRunMinute = 0;
                        }
                        else
                        {
                            m_Doing = DOING.BLANK;
                            runToolStripMenuItem.Enabled = true;
                            recordToolStripMenuItem.Enabled = true;
                            stopRecordingToolStripMenuItem.Enabled = true;
                            optionToolStripMenuItem.Enabled = true;
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRunToolStripMenuItem.Checked)
            {
                m_AutoRunMinute = 0;
                m_Seconds = 0;
                m_Doing = DOING.AutoRunning;
            }
            runToolStripMenuItem.Enabled = !autoRunToolStripMenuItem.Checked;
            recordToolStripMenuItem.Enabled = !autoRunToolStripMenuItem.Checked;
            stopRecordingToolStripMenuItem.Enabled = !autoRunToolStripMenuItem.Checked;
        }
    }
}
