namespace vizsgaminta1
{
    partial class UjUgyfelForm
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
            components = new System.ComponentModel.Container();
            buttonOK = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            textBoxEmail = new TextBox();
            textBoxLakcim = new TextBox();
            textBoxFN = new TextBox();
            textBoxSzulev = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(348, 843);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(150, 46);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.CausesValidation = false;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(622, 843);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 53);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 2;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 136);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "Login:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 39);
            textBox1.TabIndex = 4;
            textBox1.Validating += textBox1_Validating;
            textBox1.Validated += textBox1_Validated;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(325, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(574, 39);
            textBox2.TabIndex = 5;
            textBox2.Validating += textBox2_Validating;
            textBox2.Validated += textBox2_Validated;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(329, 215);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(570, 39);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.Validating += textBoxEmail_Validating;
            textBoxEmail.Validated += textBoxEmail_Validated;
            // 
            // textBoxLakcim
            // 
            textBoxLakcim.Location = new Point(329, 524);
            textBoxLakcim.Name = "textBoxLakcim";
            textBoxLakcim.Size = new Size(570, 39);
            textBoxLakcim.TabIndex = 7;
            textBoxLakcim.Validating += textBoxLakcim_Validating;
            textBoxLakcim.Validated += textBoxLakcim_Validated;
            // 
            // textBoxFN
            // 
            textBoxFN.Location = new Point(329, 420);
            textBoxFN.Name = "textBoxFN";
            textBoxFN.Size = new Size(570, 39);
            textBoxFN.TabIndex = 8;
            textBoxFN.Validating += textBoxFN_Validating;
            textBoxFN.Validated += textBoxFN_Validated;
            // 
            // textBoxSzulev
            // 
            textBoxSzulev.Location = new Point(329, 325);
            textBoxSzulev.Name = "textBoxSzulev";
            textBoxSzulev.Size = new Size(570, 39);
            textBoxSzulev.TabIndex = 9;
            textBoxSzulev.Validating += textBoxSzulev_Validating;
            textBoxSzulev.Validated += textBoxSzulev_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 222);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 10;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 325);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 11;
            label4.Text = "Születési év:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 420);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 12;
            label5.Text = "Nem (F/N):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(114, 524);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 13;
            label6.Text = "Lakcím:";
            // 
            // UjUgyfelForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1175, 1006);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSzulev);
            Controls.Add(textBoxFN);
            Controls.Add(textBoxLakcim);
            Controls.Add(textBoxEmail);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Name = "UjUgyfelForm";
            Text = "UjUgyfelForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        public TextBox textBox1;
        public TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        public TextBox textBoxSzulev;
        public TextBox textBoxFN;
        public TextBox textBoxLakcim;
        public TextBox textBoxEmail;
    }
}