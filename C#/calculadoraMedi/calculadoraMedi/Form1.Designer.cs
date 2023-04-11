namespace calculadoraMedi
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
            lblN1 = new Label();
            lblN2 = new Label();
            lblN3 = new Label();
            lblN4 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            txtN4 = new TextBox();
            lblMedia = new Label();
            lblSituation = new Label();
            txtMedia = new TextBox();
            btnCalc = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(83, 37);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(42, 15);
            lblN1.TabIndex = 0;
            lblN1.Text = "Nota 1";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(83, 88);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(42, 15);
            lblN2.TabIndex = 1;
            lblN2.Text = "Nota 2";
            // 
            // lblN3
            // 
            lblN3.AutoSize = true;
            lblN3.Location = new Point(510, 32);
            lblN3.Name = "lblN3";
            lblN3.Size = new Size(42, 15);
            lblN3.TabIndex = 2;
            lblN3.Text = "Nota 3";
            // 
            // lblN4
            // 
            lblN4.AutoSize = true;
            lblN4.Location = new Point(510, 100);
            lblN4.Name = "lblN4";
            lblN4.Size = new Size(42, 15);
            lblN4.TabIndex = 3;
            lblN4.Text = "Nota 4";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(184, 34);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(184, 97);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 5;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(589, 29);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(100, 23);
            txtN3.TabIndex = 6;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(589, 97);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(100, 23);
            txtN4.TabIndex = 7;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(83, 222);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(46, 15);
            lblMedia.TabIndex = 8;
            lblMedia.Text = "Média :";
            // 
            // lblSituation
            // 
            lblSituation.AutoSize = true;
            lblSituation.ForeColor = Color.DarkOrchid;
            lblSituation.Location = new Point(401, 332);
            lblSituation.Name = "lblSituation";
            lblSituation.Size = new Size(0, 15);
            lblSituation.TabIndex = 9;
            lblSituation.Click += label6_Click;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(184, 222);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(164, 23);
            txtMedia.TabIndex = 10;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(550, 182);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 12;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(510, 236);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(191, 32);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Limpar campos";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnCalc);
            Controls.Add(txtMedia);
            Controls.Add(lblSituation);
            Controls.Add(lblMedia);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblN4);
            Controls.Add(lblN3);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN1;
        private Label lblN2;
        private Label lblN3;
        private Label lblN4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN4;
        private Label lblMedia;
        private Label lblSituation;
        private TextBox txtMedia;
        private Button btnCalc;
        private Button btnRefresh;
    }
}