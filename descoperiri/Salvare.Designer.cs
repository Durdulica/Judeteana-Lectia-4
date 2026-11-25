namespace Descoperiri
{
    partial class Salvare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salvare));
            this.lstInsule = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumar = new System.Windows.Forms.Label();
            this.btnToate = new System.Windows.Forms.Button();
            this.btnTraseu = new System.Windows.Forms.Button();
            this.btnInAfara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstInsule
            // 
            this.lstInsule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInsule.DisplayMember = "nume";
            this.lstInsule.FormattingEnabled = true;
            this.lstInsule.ItemHeight = 19;
            this.lstInsule.Location = new System.Drawing.Point(13, 13);
            this.lstInsule.Margin = new System.Windows.Forms.Padding(4);
            this.lstInsule.Name = "lstInsule";
            this.lstInsule.Size = new System.Drawing.Size(200, 211);
            this.lstInsule.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(231, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 26);
            this.txtId.TabIndex = 1;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(328, 61);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(74, 24);
            this.btnCauta.TabIndex = 2;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(234, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id insula:";
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Location = new System.Drawing.Point(9, 239);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(63, 19);
            this.lblNumar.TabIndex = 4;
            this.lblNumar.Text = "Afisate:";
            // 
            // btnToate
            // 
            this.btnToate.Location = new System.Drawing.Point(231, 113);
            this.btnToate.Name = "btnToate";
            this.btnToate.Size = new System.Drawing.Size(171, 24);
            this.btnToate.TabIndex = 5;
            this.btnToate.Text = "Toate";
            this.btnToate.UseVisualStyleBackColor = true;
            this.btnToate.Click += new System.EventHandler(this.btnToate_Click);
            // 
            // btnTraseu
            // 
            this.btnTraseu.Location = new System.Drawing.Point(231, 143);
            this.btnTraseu.Name = "btnTraseu";
            this.btnTraseu.Size = new System.Drawing.Size(171, 24);
            this.btnTraseu.TabIndex = 6;
            this.btnTraseu.Text = "Pe traseu (2-7)";
            this.btnTraseu.UseVisualStyleBackColor = true;
            this.btnTraseu.Click += new System.EventHandler(this.btnTraseu_Click);
            // 
            // btnInAfara
            // 
            this.btnInAfara.Location = new System.Drawing.Point(231, 173);
            this.btnInAfara.Name = "btnInAfara";
            this.btnInAfara.Size = new System.Drawing.Size(171, 24);
            this.btnInAfara.TabIndex = 7;
            this.btnInAfara.Text = "In afara traseului (8-11)";
            this.btnInAfara.UseVisualStyleBackColor = true;
            this.btnInAfara.Click += new System.EventHandler(this.btnInAfara_Click);
            // 
            // Salvare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(430, 281);
            this.Controls.Add(this.btnInAfara);
            this.Controls.Add(this.btnTraseu);
            this.Controls.Add(this.btnToate);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lstInsule);
            this.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Salvare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salvare";
            this.Load += new System.EventHandler(this.Salvare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstInsule;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.Button btnToate;
        private System.Windows.Forms.Button btnTraseu;
        private System.Windows.Forms.Button btnInAfara;
    }
}

