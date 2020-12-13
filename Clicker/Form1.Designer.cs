
namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddClick = new System.Windows.Forms.Button();
            this.btnAddDelay = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(218, 132);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval (ms)";
            // 
            // flpActions
            // 
            this.flpActions.AutoScroll = true;
            this.flpActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpActions.Location = new System.Drawing.Point(0, 0);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(602, 67);
            this.flpActions.TabIndex = 6;
            this.flpActions.WrapContents = false;
            // 
            // btnAddClick
            // 
            this.btnAddClick.Location = new System.Drawing.Point(12, 73);
            this.btnAddClick.Name = "btnAddClick";
            this.btnAddClick.Size = new System.Drawing.Size(75, 23);
            this.btnAddClick.TabIndex = 7;
            this.btnAddClick.Text = "Add Click";
            this.btnAddClick.UseVisualStyleBackColor = true;
            this.btnAddClick.Click += new System.EventHandler(this.btnAddClick_Click);
            // 
            // btnAddDelay
            // 
            this.btnAddDelay.Location = new System.Drawing.Point(93, 73);
            this.btnAddDelay.Name = "btnAddDelay";
            this.btnAddDelay.Size = new System.Drawing.Size(75, 23);
            this.btnAddDelay.TabIndex = 8;
            this.btnAddDelay.Text = "Add Delay";
            this.btnAddDelay.UseVisualStyleBackColor = true;
            this.btnAddDelay.Click += new System.EventHandler(this.btnAddDelay_Click);
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(174, 73);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(75, 23);
            this.btnRem.TabIndex = 9;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(515, 73);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 10;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 191);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAddDelay);
            this.Controls.Add(this.btnAddClick);
            this.Controls.Add(this.flpActions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnAddClick;
        private System.Windows.Forms.Button btnAddDelay;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnClr;
    }
}

