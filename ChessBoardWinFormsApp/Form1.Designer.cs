namespace ChessBoardWinFormsApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Peice_Name = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a peice for the drop down and Click any move";
            // 
            // cb_Peice_Name
            // 
            this.cb_Peice_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Peice_Name.FormattingEnabled = true;
            this.cb_Peice_Name.Items.AddRange(new object[] {
            " ",
            "Bishop",
            "Rook",
            "Knight",
            "Queen",
            "King"});
            this.cb_Peice_Name.Location = new System.Drawing.Point(392, 10);
            this.cb_Peice_Name.Name = "cb_Peice_Name";
            this.cb_Peice_Name.Size = new System.Drawing.Size(121, 21);
            this.cb_Peice_Name.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(13, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Peice_Name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chess Peice Moves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Peice_Name;
        private System.Windows.Forms.Panel panel1;
    }
}

