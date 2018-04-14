namespace UIX
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPostpone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatVal = new System.Windows.Forms.Label();
            this.lblDisplayContent = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.dockTopBar = new System.Windows.Forms.Label();
            this.dockMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(224, 201);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseLeave += new System.EventHandler(this.btnRestart_MouseLeave);
            this.btnRestart.MouseHover += new System.EventHandler(this.btnRestart_MouseHover);
            // 
            // btnPostpone
            // 
            this.btnPostpone.FlatAppearance.BorderSize = 0;
            this.btnPostpone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostpone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostpone.ForeColor = System.Drawing.Color.White;
            this.btnPostpone.Location = new System.Drawing.Point(322, 201);
            this.btnPostpone.Name = "btnPostpone";
            this.btnPostpone.Size = new System.Drawing.Size(92, 23);
            this.btnPostpone.TabIndex = 1;
            this.btnPostpone.Text = "PostPone";
            this.btnPostpone.UseVisualStyleBackColor = true;
            this.btnPostpone.Click += new System.EventHandler(this.btnPostpone_Click);
            this.btnPostpone.MouseLeave += new System.EventHandler(this.btnPostpone_MouseLeave);
            this.btnPostpone.MouseHover += new System.EventHandler(this.btnPostpone_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(420, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(223, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(12, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 14);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(8, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 14);
            this.panel3.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblStatVal
            // 
            this.lblStatVal.AutoSize = true;
            this.lblStatVal.ForeColor = System.Drawing.Color.White;
            this.lblStatVal.Location = new System.Drawing.Point(3, 144);
            this.lblStatVal.Name = "lblStatVal";
            this.lblStatVal.Size = new System.Drawing.Size(13, 13);
            this.lblStatVal.TabIndex = 6;
            this.lblStatVal.Text = "0";
            this.lblStatVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayContent
            // 
            this.lblDisplayContent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayContent.ForeColor = System.Drawing.Color.Silver;
            this.lblDisplayContent.Location = new System.Drawing.Point(4, 44);
            this.lblDisplayContent.Name = "lblDisplayContent";
            this.lblDisplayContent.Size = new System.Drawing.Size(365, 58);
            this.lblDisplayContent.TabIndex = 7;
            this.lblDisplayContent.Text = "label1";
            this.lblDisplayContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisplayContent_MouseDown);
            this.lblDisplayContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDisplayContent_MouseMove);
            // 
            // lblTopBar
            // 
            this.lblTopBar.AutoSize = true;
            this.lblTopBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTopBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopBar.ForeColor = System.Drawing.Color.Gray;
            this.lblTopBar.Location = new System.Drawing.Point(5, 9);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(57, 21);
            this.lblTopBar.TabIndex = 8;
            this.lblTopBar.Text = "label1";
            this.lblTopBar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTopBar_MouseDown);
            this.lblTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTopBar_MouseMove);
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(490, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(31, 33);
            this.btnX.TabIndex = 9;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // dockTopBar
            // 
            this.dockTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockTopBar.ForeColor = System.Drawing.Color.White;
            this.dockTopBar.Location = new System.Drawing.Point(0, 0);
            this.dockTopBar.Name = "dockTopBar";
            this.dockTopBar.Size = new System.Drawing.Size(524, 37);
            this.dockTopBar.TabIndex = 10;
            this.dockTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dockTopBar_MouseDown);
            this.dockTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dockTopBar_MouseMove);
            // 
            // dockMain
            // 
            this.dockMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockMain.ForeColor = System.Drawing.Color.White;
            this.dockMain.Location = new System.Drawing.Point(0, 37);
            this.dockMain.Name = "dockMain";
            this.dockMain.Size = new System.Drawing.Size(524, 203);
            this.dockMain.TabIndex = 11;
            this.dockMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dockMain_MouseDown);
            this.dockMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dockMain_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(524, 241);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.lblDisplayContent);
            this.Controls.Add(this.lblStatVal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPostpone);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.dockTopBar);
            this.Controls.Add(this.dockMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPostpone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatVal;
        private System.Windows.Forms.Label lblDisplayContent;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label dockTopBar;
        private System.Windows.Forms.Label dockMain;
    }
}

