namespace vizsgaminta1
{
    partial class UserControl1
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
            listBoxÜgyfél = new ListBox();
            listBoxRendelések = new ListBox();
            textBoxÜgyfélSzűrés = new TextBox();
            textBoxÖssz = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDarab = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxÜgyfél
            // 
            listBoxÜgyfél.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxÜgyfél.FormattingEnabled = true;
            listBoxÜgyfél.ItemHeight = 32;
            listBoxÜgyfél.Location = new Point(17, 128);
            listBoxÜgyfél.Name = "listBoxÜgyfél";
            listBoxÜgyfél.Size = new Size(907, 1060);
            listBoxÜgyfél.TabIndex = 0;
            listBoxÜgyfél.SelectedIndexChanged += listBoxÜgyfél_SelectedIndexChanged;
            // 
            // listBoxRendelések
            // 
            listBoxRendelések.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxRendelések.FormattingEnabled = true;
            listBoxRendelések.ItemHeight = 32;
            listBoxRendelések.Location = new Point(957, 128);
            listBoxRendelések.Name = "listBoxRendelések";
            listBoxRendelések.Size = new Size(846, 1060);
            listBoxRendelések.TabIndex = 1;
            listBoxRendelések.SelectedIndexChanged += listBoxRendelések_SelectedIndexChanged;
            // 
            // textBoxÜgyfélSzűrés
            // 
            textBoxÜgyfélSzűrés.Location = new Point(17, 59);
            textBoxÜgyfélSzűrés.Name = "textBoxÜgyfélSzűrés";
            textBoxÜgyfélSzűrés.Size = new Size(907, 39);
            textBoxÜgyfélSzűrés.TabIndex = 2;
            textBoxÜgyfélSzűrés.TextChanged += textBoxÜgyfélSzűrés_TextChanged;
            // 
            // textBoxÖssz
            // 
            textBoxÖssz.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxÖssz.Location = new Point(1829, 1042);
            textBoxÖssz.Name = "textBoxÖssz";
            textBoxÖssz.Size = new Size(524, 39);
            textBoxÖssz.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 4;
            label1.Text = "Ügyfél szűrés:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1833, 993);
            label2.Name = "label2";
            label2.Size = new Size(286, 32);
            label2.TabIndex = 5;
            label2.Text = "Rendelésének összértéke:";
            // 
            // textBoxDarab
            // 
            textBoxDarab.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDarab.Location = new Point(1833, 1156);
            textBoxDarab.Name = "textBoxDarab";
            textBoxDarab.Size = new Size(520, 39);
            textBoxDarab.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1835, 1115);
            label3.Name = "label3";
            label3.Size = new Size(246, 32);
            label3.TabIndex = 7;
            label3.Text = "Rendeléseinek száma:";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label3);
            Controls.Add(textBoxDarab);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxÖssz);
            Controls.Add(textBoxÜgyfélSzűrés);
            Controls.Add(listBoxRendelések);
            Controls.Add(listBoxÜgyfél);
            Name = "UserControl1";
            Size = new Size(2372, 1255);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxÜgyfél;
        private ListBox listBoxRendelések;
        private TextBox textBoxÜgyfélSzűrés;
        private TextBox textBoxÖssz;
        private Label label1;
        private Label label2;
        private TextBox textBoxDarab;
        private Label label3;
    }
}
