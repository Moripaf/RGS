namespace MissionPlanner.Controls
{
    partial class myQuickView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("B Yekan", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label.Size = new System.Drawing.Size(112, 25);
            this.label.TabIndex = 0;
            this.label.Text = "عنوان";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // number
            // 
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F);
            this.number.Location = new System.Drawing.Point(0, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(112, 38);
            this.number.TabIndex = 1;
            this.number.Text = "0.00";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.number);
            this.splitContainer.Size = new System.Drawing.Size(112, 64);
            this.splitContainer.SplitterDistance = 25;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // myQuickView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("B Yekan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "myQuickView";
            this.Size = new System.Drawing.Size(112, 64);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
