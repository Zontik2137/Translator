namespace Tłumacz
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
            rtbInput = new RichTextBox();
            rtbOutput = new RichTextBox();
            cbSource = new ComboBox();
            cbTarget = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnTranslate = new Button();
            SuspendLayout();
            // 
            // rtbInput
            // 
            rtbInput.BackColor = SystemColors.Info;
            rtbInput.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rtbInput.Location = new Point(12, 12);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(497, 298);
            rtbInput.TabIndex = 0;
            rtbInput.Text = "";
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = SystemColors.Info;
            rtbOutput.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rtbOutput.Location = new Point(584, 12);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(497, 298);
            rtbOutput.TabIndex = 1;
            rtbOutput.Text = "";
            // 
            // cbSource
            // 
            cbSource.BackColor = SystemColors.HotTrack;
            cbSource.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbSource.FormattingEnabled = true;
            cbSource.Location = new Point(12, 358);
            cbSource.Name = "cbSource";
            cbSource.Size = new Size(497, 30);
            cbSource.TabIndex = 2;
            // 
            // cbTarget
            // 
            cbTarget.BackColor = Color.FromArgb(255, 128, 128);
            cbTarget.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cbTarget.FormattingEnabled = true;
            cbTarget.Location = new Point(584, 358);
            cbTarget.Name = "cbTarget";
            cbTarget.Size = new Size(497, 30);
            cbTarget.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(185, 322);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 4;
            label1.Text = "Tekst Tłumaczony";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(780, 322);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 5;
            label2.Text = "Tłumaczenie";
            // 
            // btnTranslate
            // 
            btnTranslate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnTranslate.Location = new Point(12, 426);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(1069, 103);
            btnTranslate.TabIndex = 6;
            btnTranslate.Text = "Tłumacz";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1093, 541);
            Controls.Add(btnTranslate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTarget);
            Controls.Add(cbSource);
            Controls.Add(rtbOutput);
            Controls.Add(rtbInput);
            Name = "Form1";
            Text = "Tłumacz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Null-forgiving init: pola zostaną zainicjalizowane w InitializeComponent()
        private RichTextBox rtbInput = null!;
        private RichTextBox rtbOutput = null!;
        private ComboBox cbSource = null!;
        private ComboBox cbTarget = null!;
        private Label label1 = null!;
        private Label label2 = null!;
        private Button btnTranslate = null!;
    }
}