namespace vizsgaminta1
{
    partial class UserControl3
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
            rendelesTetelBindingSource = new BindingSource(components);
            buttonPlusz = new Button();
            buttonMinusz = new Button();
            labelMegyseg = new Label();
            listBoxUgyfelek = new ListBox();
            listBoxSorszamok = new ListBox();
            textBoxMennyiseg = new TextBox();
            textBoxUgyfelSzures = new TextBox();
            listBoxRendelesiTetelek = new ListBox();
            textBoxEgysegAr = new TextBox();
            labelFt = new Label();
            textBoxTetelSzuro = new TextBox();
            tételekBindingSource = new BindingSource(components);
            termékkódDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            megnevezésDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egységárDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiségDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            megységDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tételekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { termékkódDataGridViewTextBoxColumn, megnevezésDataGridViewTextBoxColumn, egységárDataGridViewTextBoxColumn, mennyiségDataGridViewTextBoxColumn, megységDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tételekBindingSource;
            dataGridView1.Location = new Point(1039, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1146, 525);
            dataGridView1.TabIndex = 0;
            // 
            // rendelesTetelBindingSource
            // 
            rendelesTetelBindingSource.DataSource = typeof(Models.RendelesTetel);
            // 
            // buttonPlusz
            // 
            buttonPlusz.Location = new Point(1492, 622);
            buttonPlusz.Name = "buttonPlusz";
            buttonPlusz.Size = new Size(150, 46);
            buttonPlusz.TabIndex = 1;
            buttonPlusz.Text = "+";
            buttonPlusz.UseVisualStyleBackColor = true;
            buttonPlusz.Click += buttonPlusz_Click;
            // 
            // buttonMinusz
            // 
            buttonMinusz.Location = new Point(1707, 622);
            buttonMinusz.Name = "buttonMinusz";
            buttonMinusz.Size = new Size(150, 46);
            buttonMinusz.TabIndex = 2;
            buttonMinusz.Text = "-";
            buttonMinusz.UseVisualStyleBackColor = true;
            buttonMinusz.Click += buttonMinusz_Click;
            // 
            // labelMegyseg
            // 
            labelMegyseg.AutoSize = true;
            labelMegyseg.Location = new Point(1921, 748);
            labelMegyseg.Name = "labelMegyseg";
            labelMegyseg.Size = new Size(78, 32);
            labelMegyseg.TabIndex = 3;
            labelMegyseg.Text = "label1";
            // 
            // listBoxUgyfelek
            // 
            listBoxUgyfelek.FormattingEnabled = true;
            listBoxUgyfelek.ItemHeight = 32;
            listBoxUgyfelek.Location = new Point(55, 87);
            listBoxUgyfelek.Name = "listBoxUgyfelek";
            listBoxUgyfelek.Size = new Size(410, 388);
            listBoxUgyfelek.TabIndex = 4;
            listBoxUgyfelek.SelectedIndexChanged += listBoxUgyfelek_SelectedIndexChanged;
            // 
            // listBoxSorszamok
            // 
            listBoxSorszamok.FormattingEnabled = true;
            listBoxSorszamok.ItemHeight = 32;
            listBoxSorszamok.Location = new Point(652, 87);
            listBoxSorszamok.Name = "listBoxSorszamok";
            listBoxSorszamok.Size = new Size(315, 388);
            listBoxSorszamok.TabIndex = 5;
            listBoxSorszamok.SelectedIndexChanged += listBoxSorszamok_SelectedIndexChanged;
            // 
            // textBoxMennyiseg
            // 
            textBoxMennyiseg.Location = new Point(1534, 745);
            textBoxMennyiseg.Name = "textBoxMennyiseg";
            textBoxMennyiseg.Size = new Size(336, 39);
            textBoxMennyiseg.TabIndex = 6;
            // 
            // textBoxUgyfelSzures
            // 
            textBoxUgyfelSzures.Location = new Point(55, 34);
            textBoxUgyfelSzures.Name = "textBoxUgyfelSzures";
            textBoxUgyfelSzures.Size = new Size(200, 39);
            textBoxUgyfelSzures.TabIndex = 7;
            textBoxUgyfelSzures.TextChanged += textBoxUgyfelSzures_TextChanged;
            // 
            // listBoxRendelesiTetelek
            // 
            listBoxRendelesiTetelek.FormattingEnabled = true;
            listBoxRendelesiTetelek.ItemHeight = 32;
            listBoxRendelesiTetelek.Location = new Point(937, 686);
            listBoxRendelesiTetelek.Name = "listBoxRendelesiTetelek";
            listBoxRendelesiTetelek.Size = new Size(483, 388);
            listBoxRendelesiTetelek.TabIndex = 8;
            listBoxRendelesiTetelek.SelectedIndexChanged += listBoxRendelesiTetelek_SelectedIndexChanged;
            // 
            // textBoxEgysegAr
            // 
            textBoxEgysegAr.Location = new Point(1534, 837);
            textBoxEgysegAr.Name = "textBoxEgysegAr";
            textBoxEgysegAr.Size = new Size(336, 39);
            textBoxEgysegAr.TabIndex = 9;
            // 
            // labelFt
            // 
            labelFt.AutoSize = true;
            labelFt.Location = new Point(1924, 834);
            labelFt.Name = "labelFt";
            labelFt.Size = new Size(34, 32);
            labelFt.TabIndex = 10;
            labelFt.Text = "Ft";
            // 
            // textBoxTetelSzuro
            // 
            textBoxTetelSzuro.Location = new Point(937, 622);
            textBoxTetelSzuro.Name = "textBoxTetelSzuro";
            textBoxTetelSzuro.Size = new Size(200, 39);
            textBoxTetelSzuro.TabIndex = 11;
            textBoxTetelSzuro.TextChanged += textBoxTetelSzuro_TextChanged;
            // 
            // tételekBindingSource
            // 
            tételekBindingSource.DataSource = typeof(Tételek);
            // 
            // termékkódDataGridViewTextBoxColumn
            // 
            termékkódDataGridViewTextBoxColumn.DataPropertyName = "Termékkód";
            termékkódDataGridViewTextBoxColumn.HeaderText = "Termékkód";
            termékkódDataGridViewTextBoxColumn.MinimumWidth = 10;
            termékkódDataGridViewTextBoxColumn.Name = "termékkódDataGridViewTextBoxColumn";
            termékkódDataGridViewTextBoxColumn.Width = 200;
            // 
            // megnevezésDataGridViewTextBoxColumn
            // 
            megnevezésDataGridViewTextBoxColumn.DataPropertyName = "Megnevezés";
            megnevezésDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            megnevezésDataGridViewTextBoxColumn.MinimumWidth = 10;
            megnevezésDataGridViewTextBoxColumn.Name = "megnevezésDataGridViewTextBoxColumn";
            megnevezésDataGridViewTextBoxColumn.Width = 200;
            // 
            // egységárDataGridViewTextBoxColumn
            // 
            egységárDataGridViewTextBoxColumn.DataPropertyName = "Egységár";
            egységárDataGridViewTextBoxColumn.HeaderText = "Egységár";
            egységárDataGridViewTextBoxColumn.MinimumWidth = 10;
            egységárDataGridViewTextBoxColumn.Name = "egységárDataGridViewTextBoxColumn";
            egységárDataGridViewTextBoxColumn.Width = 200;
            // 
            // mennyiségDataGridViewTextBoxColumn
            // 
            mennyiségDataGridViewTextBoxColumn.DataPropertyName = "Mennyiség";
            mennyiségDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            mennyiségDataGridViewTextBoxColumn.MinimumWidth = 10;
            mennyiségDataGridViewTextBoxColumn.Name = "mennyiségDataGridViewTextBoxColumn";
            mennyiségDataGridViewTextBoxColumn.Width = 200;
            // 
            // megységDataGridViewTextBoxColumn
            // 
            megységDataGridViewTextBoxColumn.DataPropertyName = "Megység";
            megységDataGridViewTextBoxColumn.HeaderText = "Megység";
            megységDataGridViewTextBoxColumn.MinimumWidth = 10;
            megységDataGridViewTextBoxColumn.Name = "megységDataGridViewTextBoxColumn";
            megységDataGridViewTextBoxColumn.Width = 200;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            Controls.Add(textBoxTetelSzuro);
            Controls.Add(labelFt);
            Controls.Add(textBoxEgysegAr);
            Controls.Add(listBoxRendelesiTetelek);
            Controls.Add(textBoxUgyfelSzures);
            Controls.Add(textBoxMennyiseg);
            Controls.Add(listBoxSorszamok);
            Controls.Add(listBoxUgyfelek);
            Controls.Add(labelMegyseg);
            Controls.Add(buttonMinusz);
            Controls.Add(buttonPlusz);
            Controls.Add(dataGridView1);
            Name = "UserControl3";
            Size = new Size(2227, 1108);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tételekBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonPlusz;
        private Button buttonMinusz;
        private ListBox listBoxUgyfelek;
        private ListBox listBoxSorszamok;
        private TextBox textBoxMennyiseg;
        private TextBox textBoxUgyfelSzures;
        private ListBox listBoxRendelesiTetelek;
        private BindingSource rendelesTetelBindingSource;
        private Label labelMegyseg;
        private TextBox textBoxEgysegAr;
        private Label labelFt;
        private TextBox textBoxTetelSzuro;
        private DataGridViewTextBoxColumn termékkódDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn megnevezésDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egységárDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiségDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn megységDataGridViewTextBoxColumn;
        private BindingSource tételekBindingSource;
    }
}
