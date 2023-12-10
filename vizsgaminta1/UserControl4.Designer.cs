namespace vizsgaminta1
{
    partial class UserControl4
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
            buttonExcel = new Button();
            buttonDiagram = new Button();
            SuspendLayout();
            // 
            // buttonExcel
            // 
            buttonExcel.Location = new Point(434, 502);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(331, 329);
            buttonExcel.TabIndex = 0;
            buttonExcel.Text = "Excel generálás";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // buttonDiagram
            // 
            buttonDiagram.Location = new Point(958, 502);
            buttonDiagram.Name = "buttonDiagram";
            buttonDiagram.Size = new Size(316, 329);
            buttonDiagram.TabIndex = 1;
            buttonDiagram.Text = "Diagram készítése";
            buttonDiagram.UseVisualStyleBackColor = true;
            buttonDiagram.Click += buttonDiagram_Click;
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDiagram);
            Controls.Add(buttonExcel);
            Name = "UserControl4";
            Size = new Size(1764, 1319);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonExcel;
        private Button buttonDiagram;
    }
}
