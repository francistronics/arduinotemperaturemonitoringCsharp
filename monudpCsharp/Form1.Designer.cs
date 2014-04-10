namespace monudpCsharp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TbIPdestinataire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPortdestinataire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbMessageToSend = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TbMessageReceive = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltemp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPdestinataire";
            // 
            // TbIPdestinataire
            // 
            this.TbIPdestinataire.Location = new System.Drawing.Point(100, 27);
            this.TbIPdestinataire.Name = "TbIPdestinataire";
            this.TbIPdestinataire.Size = new System.Drawing.Size(145, 20);
            this.TbIPdestinataire.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portdestinataire";
            // 
            // TbPortdestinataire
            // 
            this.TbPortdestinataire.Location = new System.Drawing.Point(113, 67);
            this.TbPortdestinataire.Name = "TbPortdestinataire";
            this.TbPortdestinataire.Size = new System.Drawing.Size(82, 20);
            this.TbPortdestinataire.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MessageToSend:";
            // 
            // TbMessageToSend
            // 
            this.TbMessageToSend.Location = new System.Drawing.Point(38, 131);
            this.TbMessageToSend.Multiline = true;
            this.TbMessageToSend.Name = "TbMessageToSend";
            this.TbMessageToSend.Size = new System.Drawing.Size(206, 59);
            this.TbMessageToSend.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(53, 197);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(170, 39);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ReceiveMessage:";
            // 
            // TbMessageReceive
            // 
            this.TbMessageReceive.Location = new System.Drawing.Point(38, 271);
            this.TbMessageReceive.Multiline = true;
            this.TbMessageReceive.Name = "TbMessageReceive";
            this.TbMessageReceive.Size = new System.Drawing.Size(212, 63);
            this.TbMessageReceive.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltemp.ForeColor = System.Drawing.Color.Blue;
            this.labeltemp.Location = new System.Drawing.Point(322, 38);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(0, 39);
            this.labeltemp.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "0";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(279, 131);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(353, 242);
            this.zedGraphControl1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 418);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.TbMessageReceive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbMessageToSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbPortdestinataire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbIPdestinataire);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ARDUINO_LedControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIPdestinataire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPortdestinataire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbMessageToSend;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbMessageReceive;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}

