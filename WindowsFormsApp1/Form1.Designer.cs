
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtPlus = new System.Windows.Forms.Button();
            this.BtSous = new System.Windows.Forms.Button();
            this.BtMulti = new System.Windows.Forms.Button();
            this.BtDiv = new System.Windows.Forms.Button();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultat";
            // 
            // BtPlus
            // 
            this.BtPlus.Location = new System.Drawing.Point(22, 203);
            this.BtPlus.Name = "BtPlus";
            this.BtPlus.Size = new System.Drawing.Size(75, 23);
            this.BtPlus.TabIndex = 3;
            this.BtPlus.Text = "+";
            this.BtPlus.UseVisualStyleBackColor = true;
            this.BtPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtSous
            // 
            this.BtSous.Location = new System.Drawing.Point(115, 203);
            this.BtSous.Name = "BtSous";
            this.BtSous.Size = new System.Drawing.Size(75, 23);
            this.BtSous.TabIndex = 4;
            this.BtSous.Text = "-";
            this.BtSous.UseVisualStyleBackColor = true;
            this.BtSous.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtMulti
            // 
            this.BtMulti.Location = new System.Drawing.Point(211, 203);
            this.BtMulti.Name = "BtMulti";
            this.BtMulti.Size = new System.Drawing.Size(75, 23);
            this.BtMulti.TabIndex = 5;
            this.BtMulti.Text = "*";
            this.BtMulti.UseVisualStyleBackColor = true;
            this.BtMulti.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtDiv
            // 
            this.BtDiv.Location = new System.Drawing.Point(309, 203);
            this.BtDiv.Name = "BtDiv";
            this.BtDiv.Size = new System.Drawing.Size(75, 23);
            this.BtDiv.TabIndex = 6;
            this.BtDiv.Text = "/";
            this.BtDiv.UseVisualStyleBackColor = true;
            this.BtDiv.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(133, 36);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 20);
            this.txtx.TabIndex = 7;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(133, 83);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(100, 20);
            this.txty.TabIndex = 8;
            // 
            // txtz
            // 
            this.txtz.Location = new System.Drawing.Point(133, 136);
            this.txtz.Name = "txtz";
            this.txtz.Size = new System.Drawing.Size(100, 20);
            this.txtz.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 248);
            this.Controls.Add(this.txtz);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.BtDiv);
            this.Controls.Add(this.BtMulti);
            this.Controls.Add(this.BtSous);
            this.Controls.Add(this.BtPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtPlus;
        private System.Windows.Forms.Button BtSous;
        private System.Windows.Forms.Button BtMulti;
        private System.Windows.Forms.Button BtDiv;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtz;
    }
}

