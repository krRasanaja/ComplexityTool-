﻿namespace ComplexityTool
{
    partial class Main
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
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSizeScore = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExtendCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCode.Location = new System.Drawing.Point(51, 245);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(511, 579);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            this.txtCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCode_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Put your code here :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(601, 795);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 46);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(947, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size Complexity Score (Cs) :";
            // 
            // txtSizeScore
            // 
            this.txtSizeScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSizeScore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSizeScore.Enabled = false;
            this.txtSizeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSizeScore.Location = new System.Drawing.Point(1219, 187);
            this.txtSizeScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSizeScore.Name = "txtSizeScore";
            this.txtSizeScore.Size = new System.Drawing.Size(184, 30);
            this.txtSizeScore.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNo,
            this.Statement,
            this.Cs,
            this.Ctc,
            this.Cnc,
            this.Ci,
            this.TW,
            this.Cps,
            this.Cr,
            this.EC});
            this.dataGridView.Location = new System.Drawing.Point(581, 271);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(900, 517);
            this.dataGridView.TabIndex = 5;
            // 
            // LineNo
            // 
            this.LineNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LineNo.HeaderText = "Line No";
            this.LineNo.Name = "LineNo";
            // 
            // Statement
            // 
            this.Statement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Statement.FillWeight = 500F;
            this.Statement.HeaderText = "Program Statement";
            this.Statement.Name = "Statement";
            this.Statement.Width = 145;
            // 
            // Cs
            // 
            this.Cs.HeaderText = "Cs";
            this.Cs.Name = "Cs";
            // 
            // Ctc
            // 
            this.Ctc.HeaderText = "Ctc";
            this.Ctc.Name = "Ctc";
            // 
            // Cnc
            // 
            this.Cnc.HeaderText = "Cnc";
            this.Cnc.Name = "Cnc";
            // 
            // Ci
            // 
            this.Ci.HeaderText = "Ci";
            this.Ci.Name = "Ci";
            // 
            // TW
            // 
            this.TW.HeaderText = "TW";
            this.TW.Name = "TW";
            // 
            // Cps
            // 
            this.Cps.HeaderText = "Cps";
            this.Cps.Name = "Cps";
            // 
            // Cr
            // 
            this.Cr.HeaderText = "Cr";
            this.Cr.Name = "Cr";
            // 
            // EC
            // 
            this.EC.HeaderText = "EC";
            this.EC.Name = "EC";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1071, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Extend Count :";
            // 
            // lblExtendCount
            // 
            this.lblExtendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExtendCount.AutoSize = true;
            this.lblExtendCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtendCount.Location = new System.Drawing.Point(1231, 242);
            this.lblExtendCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtendCount.Name = "lblExtendCount";
            this.lblExtendCount.Size = new System.Drawing.Size(23, 25);
            this.lblExtendCount.TabIndex = 7;
            this.lblExtendCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(753, 795);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 46);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblExtendCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtSizeScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSizeScore;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn TW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExtendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn EC;
        private System.Windows.Forms.Button btnReset;
    }
}

