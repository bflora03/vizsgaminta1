namespace vizsgaminta1
{
    partial class UserControl2
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szulevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            buttonÚjÜgyfél = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { loginDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, szulevDataGridViewTextBoxColumn, nemDataGridViewTextBoxColumn, cimDataGridViewTextBoxColumn, rendelesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(325, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1512, 730);
            dataGridView1.TabIndex = 0;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 10;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 10;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 200;
            // 
            // szulevDataGridViewTextBoxColumn
            // 
            szulevDataGridViewTextBoxColumn.DataPropertyName = "Szulev";
            szulevDataGridViewTextBoxColumn.HeaderText = "Szulev";
            szulevDataGridViewTextBoxColumn.MinimumWidth = 10;
            szulevDataGridViewTextBoxColumn.Name = "szulevDataGridViewTextBoxColumn";
            szulevDataGridViewTextBoxColumn.Width = 200;
            // 
            // nemDataGridViewTextBoxColumn
            // 
            nemDataGridViewTextBoxColumn.DataPropertyName = "Nem";
            nemDataGridViewTextBoxColumn.HeaderText = "Nem";
            nemDataGridViewTextBoxColumn.MinimumWidth = 10;
            nemDataGridViewTextBoxColumn.Name = "nemDataGridViewTextBoxColumn";
            nemDataGridViewTextBoxColumn.Width = 200;
            // 
            // cimDataGridViewTextBoxColumn
            // 
            cimDataGridViewTextBoxColumn.DataPropertyName = "Cim";
            cimDataGridViewTextBoxColumn.HeaderText = "Cim";
            cimDataGridViewTextBoxColumn.MinimumWidth = 10;
            cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            cimDataGridViewTextBoxColumn.Width = 200;
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            rendelesDataGridViewTextBoxColumn.MinimumWidth = 10;
            rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            rendelesDataGridViewTextBoxColumn.Width = 200;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            ugyfelBindingSource.CurrentChanged += ugyfelBindingSource_CurrentChanged;
            // 
            // buttonÚjÜgyfél
            // 
            buttonÚjÜgyfél.BackColor = Color.LightSalmon;
            buttonÚjÜgyfél.Location = new Point(138, 867);
            buttonÚjÜgyfél.Name = "buttonÚjÜgyfél";
            buttonÚjÜgyfél.Size = new Size(226, 187);
            buttonÚjÜgyfél.TabIndex = 1;
            buttonÚjÜgyfél.Text = "Új ügyfél";
            buttonÚjÜgyfél.UseVisualStyleBackColor = false;
            buttonÚjÜgyfél.Click += buttonÚjÜgyfél_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(buttonÚjÜgyfél);
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(2153, 1156);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource ugyfelBindingSource;
        private Button buttonÚjÜgyfél;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szulevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
    }
}
