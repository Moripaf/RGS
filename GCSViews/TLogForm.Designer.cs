namespace MissionPlanner.GCSViews
{
    partial class TLogForm
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
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.lbl_playbackspeed = new System.Windows.Forms.Label();
            this.lbl_logpercent = new System.Windows.Forms.Label();
            this.LBL_logfn = new System.Windows.Forms.Label();
            this.BUT_log2kml = new MissionPlanner.Controls.MyButton();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.tableLayoutPaneltlogs.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPaneltlogs
            // 
            this.tableLayoutPaneltlogs.ColumnCount = 3;
            this.tableLayoutPaneltlogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPaneltlogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPaneltlogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_playbackspeed, 2, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_logpercent, 2, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.LBL_logfn, 1, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_log2kml, 0, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 0, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.tracklog, 1, 1);
            this.tableLayoutPaneltlogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPaneltlogs.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            this.tableLayoutPaneltlogs.RowCount = 3;
            this.tableLayoutPaneltlogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPaneltlogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPaneltlogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPaneltlogs.Size = new System.Drawing.Size(619, 454);
            this.tableLayoutPaneltlogs.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BUT_speed10);
            this.panel2.Controls.Add(this.BUT_speed5);
            this.panel2.Controls.Add(this.BUT_speed2);
            this.panel2.Controls.Add(this.BUT_speed1);
            this.panel2.Controls.Add(this.BUT_speed1_2);
            this.panel2.Controls.Add(this.BUT_speed1_4);
            this.panel2.Controls.Add(this.BUT_speed1_10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(94, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 382);
            this.panel2.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(49, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Speed";
            // 
            // BUT_speed10
            // 
            this.BUT_speed10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed10.Location = new System.Drawing.Point(64, 59);
            this.BUT_speed10.Name = "BUT_speed10";
            this.BUT_speed10.Size = new System.Drawing.Size(23, 30);
            this.BUT_speed10.TabIndex = 83;
            this.BUT_speed10.Tag = "10";
            this.BUT_speed10.Text = "10x";
            this.BUT_speed10.UseVisualStyleBackColor = true;
            // 
            // BUT_speed5
            // 
            this.BUT_speed5.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed5.Location = new System.Drawing.Point(35, 59);
            this.BUT_speed5.Name = "BUT_speed5";
            this.BUT_speed5.Size = new System.Drawing.Size(23, 30);
            this.BUT_speed5.TabIndex = 82;
            this.BUT_speed5.Tag = "5";
            this.BUT_speed5.Text = "5x";
            this.BUT_speed5.UseVisualStyleBackColor = true;
            // 
            // BUT_speed2
            // 
            this.BUT_speed2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed2.Location = new System.Drawing.Point(6, 59);
            this.BUT_speed2.Name = "BUT_speed2";
            this.BUT_speed2.Size = new System.Drawing.Size(23, 30);
            this.BUT_speed2.TabIndex = 81;
            this.BUT_speed2.Tag = "2";
            this.BUT_speed2.Text = "2x";
            this.BUT_speed2.UseVisualStyleBackColor = true;
            // 
            // BUT_speed1
            // 
            this.BUT_speed1.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1.Location = new System.Drawing.Point(97, 23);
            this.BUT_speed1.Name = "BUT_speed1";
            this.BUT_speed1.Size = new System.Drawing.Size(23, 30);
            this.BUT_speed1.TabIndex = 80;
            this.BUT_speed1.Tag = "1";
            this.BUT_speed1.Text = "1x";
            this.BUT_speed1.UseVisualStyleBackColor = true;
            // 
            // BUT_speed1_2
            // 
            this.BUT_speed1_2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1_2.Location = new System.Drawing.Point(68, 23);
            this.BUT_speed1_2.Name = "BUT_speed1_2";
            this.BUT_speed1_2.Size = new System.Drawing.Size(23, 30);
            this.BUT_speed1_2.TabIndex = 79;
            this.BUT_speed1_2.Tag = "0.5";
            this.BUT_speed1_2.Text = "0.5";
            this.BUT_speed1_2.UseVisualStyleBackColor = true;
            // 
            // BUT_speed1_4
            // 
            this.BUT_speed1_4.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1_4.Location = new System.Drawing.Point(35, 23);
            this.BUT_speed1_4.Name = "BUT_speed1_4";
            this.BUT_speed1_4.Size = new System.Drawing.Size(27, 30);
            this.BUT_speed1_4.TabIndex = 78;
            this.BUT_speed1_4.Tag = "0.25";
            this.BUT_speed1_4.Text = "0.25";
            this.BUT_speed1_4.UseVisualStyleBackColor = true;
            // 
            // BUT_speed1_10
            // 
            this.BUT_speed1_10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_speed1_10.Location = new System.Drawing.Point(6, 23);
            this.BUT_speed1_10.Name = "BUT_speed1_10";
            this.BUT_speed1_10.Size = new System.Drawing.Size(23, 30);
            this.BUT_speed1_10.TabIndex = 77;
            this.BUT_speed1_10.Tag = "0.1";
            this.BUT_speed1_10.Text = "0.1";
            this.BUT_speed1_10.UseVisualStyleBackColor = true;
            // 
            // BUT_loadtelem
            // 
            this.BUT_loadtelem.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_loadtelem.Location = new System.Drawing.Point(3, 3);
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.Size = new System.Drawing.Size(80, 27);
            this.BUT_loadtelem.TabIndex = 71;
            this.BUT_loadtelem.Text = "Load Log";
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // lbl_playbackspeed
            // 
            this.lbl_playbackspeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_playbackspeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_playbackspeed.Location = new System.Drawing.Point(565, 66);
            this.lbl_playbackspeed.Name = "lbl_playbackspeed";
            this.lbl_playbackspeed.Size = new System.Drawing.Size(51, 388);
            this.lbl_playbackspeed.TabIndex = 79;
            this.lbl_playbackspeed.Text = "x 1.0";
            // 
            // lbl_logpercent
            // 
            this.lbl_logpercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_logpercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_logpercent.Location = new System.Drawing.Point(565, 33);
            this.lbl_logpercent.Name = "lbl_logpercent";
            this.lbl_logpercent.Size = new System.Drawing.Size(51, 33);
            this.lbl_logpercent.TabIndex = 78;
            this.lbl_logpercent.Text = "0.00 %";
            // 
            // LBL_logfn
            // 
            this.tableLayoutPaneltlogs.SetColumnSpan(this.LBL_logfn, 2);
            this.LBL_logfn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_logfn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_logfn.Location = new System.Drawing.Point(94, 0);
            this.LBL_logfn.Name = "LBL_logfn";
            this.LBL_logfn.Size = new System.Drawing.Size(522, 33);
            this.LBL_logfn.TabIndex = 80;
            // 
            // BUT_log2kml
            // 
            this.BUT_log2kml.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_log2kml.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_log2kml.Location = new System.Drawing.Point(3, 69);
            this.BUT_log2kml.Name = "BUT_log2kml";
            this.BUT_log2kml.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.BUT_log2kml.Size = new System.Drawing.Size(80, 46);
            this.BUT_log2kml.TabIndex = 76;
            this.BUT_log2kml.Text = "Tlog > Kml or Graph";
            this.BUT_log2kml.UseVisualStyleBackColor = true;
            // 
            // BUT_playlog
            // 
            this.BUT_playlog.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorNotEnabled = System.Drawing.Color.Empty;
            this.BUT_playlog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_playlog.Location = new System.Drawing.Point(3, 36);
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.Size = new System.Drawing.Size(80, 27);
            this.BUT_playlog.TabIndex = 73;
            this.BUT_playlog.Text = "Play/Pause";
            this.BUT_playlog.UseVisualStyleBackColor = true;
            // 
            // tracklog
            // 
            this.tracklog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracklog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tracklog.Location = new System.Drawing.Point(94, 36);
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.Size = new System.Drawing.Size(465, 27);
            this.tracklog.TabIndex = 75;
            this.tracklog.TickFrequency = 5;
            // 
            // TLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 454);
            this.Controls.Add(this.tableLayoutPaneltlogs);
            this.Name = "TLogForm";
            this.Text = "TLogForm";
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private Controls.MyButton BUT_loadtelem;
        private System.Windows.Forms.Label lbl_playbackspeed;
        private System.Windows.Forms.Label lbl_logpercent;
        private System.Windows.Forms.Label LBL_logfn;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_playlog;
        private System.Windows.Forms.TrackBar tracklog;
    }
}