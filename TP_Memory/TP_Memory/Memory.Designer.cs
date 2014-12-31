namespace TP_Memory
{
    partial class Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_03 = new System.Windows.Forms.PictureBox();
            this.pb_04 = new System.Windows.Forms.PictureBox();
            this.btn_Distribuer = new System.Windows.Forms.Button();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.btn_Test = new System.Windows.Forms.Button();
            this.tlpTapisDeCartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTapisDeCartes
            // 
            this.tlpTapisDeCartes.ColumnCount = 4;
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.Controls.Add(this.pb_01, 0, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_02, 1, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_03, 2, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_04, 3, 0);
            this.tlpTapisDeCartes.Location = new System.Drawing.Point(179, 183);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.RowCount = 1;
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTapisDeCartes.Size = new System.Drawing.Size(440, 110);
            this.tlpTapisDeCartes.TabIndex = 0;
            // 
            // pb_01
            // 
            this.pb_01.Location = new System.Drawing.Point(3, 3);
            this.pb_01.Name = "pb_01";
            this.pb_01.Size = new System.Drawing.Size(100, 100);
            this.pb_01.TabIndex = 0;
            this.pb_01.TabStop = false;
            // 
            // pb_02
            // 
            this.pb_02.Location = new System.Drawing.Point(113, 3);
            this.pb_02.Name = "pb_02";
            this.pb_02.Size = new System.Drawing.Size(100, 100);
            this.pb_02.TabIndex = 0;
            this.pb_02.TabStop = false;
            // 
            // pb_03
            // 
            this.pb_03.Location = new System.Drawing.Point(223, 3);
            this.pb_03.Name = "pb_03";
            this.pb_03.Size = new System.Drawing.Size(100, 100);
            this.pb_03.TabIndex = 0;
            this.pb_03.TabStop = false;
            // 
            // pb_04
            // 
            this.pb_04.Location = new System.Drawing.Point(333, 3);
            this.pb_04.Name = "pb_04";
            this.pb_04.Size = new System.Drawing.Size(100, 100);
            this.pb_04.TabIndex = 0;
            this.pb_04.TabStop = false;
            // 
            // btn_Distribuer
            // 
            this.btn_Distribuer.Location = new System.Drawing.Point(512, 332);
            this.btn_Distribuer.Name = "btn_Distribuer";
            this.btn_Distribuer.Size = new System.Drawing.Size(100, 34);
            this.btn_Distribuer.TabIndex = 1;
            this.btn_Distribuer.Text = "Distribuer";
            this.btn_Distribuer.UseVisualStyleBackColor = true;
            this.btn_Distribuer.Click += new System.EventHandler(this.btn_Distribuer_Click);
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "FemmeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "FemmeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "FemmeBlanche.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "FemmeBleue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "FemmeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "FemmeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "FemmeInformaticienBrune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "FemmeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "FemmeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "FemmeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "FemmeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "FemmeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "FemmePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "FemmePoliciere.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "HommeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "HommeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "HommeBleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "HommeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "HommeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "HommeGarde.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "HommeInformaticienBrun.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "HommeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "HommeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "HommeMarron.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "HommeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "HommeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "HommeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "HommePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "HommePolicier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "Joker.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "LivreurPizza.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "MarinMousse.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "MarinOfficier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "MarinPompon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "Mecanicien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "Pilote.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "Pompier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "Serveur.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "Dialogue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "Diplome.jpg");
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(304, 88);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 2;
            this.btn_Test.Text = "TEST LotoMachine";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 367);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Distribuer);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Name = "Memory";
            this.Text = "Memory";
            this.tlpTapisDeCartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_03;
        private System.Windows.Forms.PictureBox pb_04;
        private System.Windows.Forms.Button btn_Distribuer;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.Button btn_Test;
    }
}

