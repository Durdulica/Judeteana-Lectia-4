namespace ExempluDate
{
    partial class Planete
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstPlanete = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnToate = new System.Windows.Forms.Button();
            this.btnTraseu = new System.Windows.Forms.Button();
            this.btnInAfara = new System.Windows.Forms.Button();
            this.lblNumar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lstPlanete.FormattingEnabled = true;
            this.lstPlanete.ItemHeight = 17;
            this.lstPlanete.Location = new System.Drawing.Point(16, 16);
            this.lstPlanete.Name = "lstPlanete";
            this.lstPlanete.Size = new System.Drawing.Size(200, 208);
            this.lstPlanete.TabIndex = 0;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(240, 19);
            this.lblId.Name = "lblId";
            this.lblId.Text = "Id planeta:";
            this.txtId.Location = new System.Drawing.Point(240, 42);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(80, 25);
            this.txtId.TabIndex = 1;
            this.btnCauta.Location = new System.Drawing.Point(330, 40);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(90, 28);
            this.btnCauta.TabIndex = 2;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            this.btnToate.Location = new System.Drawing.Point(240, 100);
            this.btnToate.Name = "btnToate";
            this.btnToate.Size = new System.Drawing.Size(180, 28);
            this.btnToate.TabIndex = 3;
            this.btnToate.Text = "Toate";
            this.btnToate.UseVisualStyleBackColor = true;
            this.btnToate.Click += new System.EventHandler(this.btnToate_Click);
            this.btnTraseu.Location = new System.Drawing.Point(240, 134);
            this.btnTraseu.Name = "btnTraseu";
            this.btnTraseu.Size = new System.Drawing.Size(180, 28);
            this.btnTraseu.TabIndex = 4;
            this.btnTraseu.Text = "Pe traseu (2-5)";
            this.btnTraseu.UseVisualStyleBackColor = true;
            this.btnTraseu.Click += new System.EventHandler(this.btnTraseu_Click);
            this.btnInAfara.Location = new System.Drawing.Point(240, 168);
            this.btnInAfara.Name = "btnInAfara";
            this.btnInAfara.Size = new System.Drawing.Size(180, 28);
            this.btnInAfara.TabIndex = 5;
            this.btnInAfara.Text = "In afara traseului (6-8)";
            this.btnInAfara.UseVisualStyleBackColor = true;
            this.btnInAfara.Click += new System.EventHandler(this.btnInAfara_Click);
            this.lblNumar.AutoSize = true;
            this.lblNumar.Location = new System.Drawing.Point(16, 240);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Text = "Afisate: 0";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 276);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Planete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planete";
            this.Load += new System.EventHandler(this.Planete_Load);
            this.Controls.Add(this.lstPlanete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnToate);
            this.Controls.Add(this.btnTraseu);
            this.Controls.Add(this.btnInAfara);
            this.Controls.Add(this.lblNumar);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlanete;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnToate;
        private System.Windows.Forms.Button btnTraseu;
        private System.Windows.Forms.Button btnInAfara;
        private System.Windows.Forms.Label lblNumar;
    }
}
