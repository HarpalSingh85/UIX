using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIX
{
    public partial class Form1 : Form
    {
        public int StatVal { get; set; }
        float _tmpstatVal, _tmpwidthVal, tmp;
        
        Point _lastPoint;

        public Form1()
        {
            InitializeComponent();
            panel1.Height = btnRestart.Height;
            panel1.Top = btnRestart.Top;
           
            StatVal = 0;
            timer1.Start();
            timer1.Interval = 100;
            timer1.Tick += Timer1_Tick;
           
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {   
            panel1.Visible = false;
            lblTopBar.Text = "JUNOS PULSE INSTALLER NOTIFICATION";
            lblDisplayContent.Text = "Junos Pulse have been installed in your computer.\r\nPlease restart the computer.";
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            DragMove( sender, e);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DragLocation(e);
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (panel3.Width != panel2.Width && lblStatVal.Location.X != panel2.Width)
            {
                
                panel3.Width++;
                _tmpstatVal = StatVal;
                _tmpwidthVal = panel2.Width;
                lblStatVal.Left += 1;
                tmp = _tmpstatVal / _tmpwidthVal;
                lblStatVal.Text = (Math.Round(tmp * 100) + 1).ToString();                              
                StatVal++;
            }

        }

               

        private void btnCancel_Click(object sender, EventArgs e)
        {                       
            this.Close();
        }


        private void btnRestart_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Left = btnRestart.Location.X;
            panel1.Height = 3;
        }

        private void btnPostpone_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Left = btnPostpone.Location.X;
            panel1.Height = 3;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Left = btnCancel.Location.X;
            panel1.Height = 3;
        }

        private void btnRestart_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnPostpone_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void lblDisplayContent_MouseDown(object sender, MouseEventArgs e)
        {
            DragLocation(e);
        }

        private void lblDisplayContent_MouseMove(object sender, MouseEventArgs e)
        {
            DragMove( sender,  e);
        }

        private void DragLocation( MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _lastPoint.X;
                this.Top += e.Y - _lastPoint.Y;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void btnPostpone_Click(object sender, EventArgs e)
        {

        }

        private void dockTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            DragLocation(e);
        }

        private void dockTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            DragMove(sender, e);
        }

        private void dockMain_MouseMove(object sender, MouseEventArgs e)
        {
            DragMove(sender, e);
        }

        private void dockMain_MouseDown(object sender, MouseEventArgs e)
        {
            DragLocation(e);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            DragLocation(e);
        }

        private void lblTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            DragMove(sender, e);
        }
    }
}
