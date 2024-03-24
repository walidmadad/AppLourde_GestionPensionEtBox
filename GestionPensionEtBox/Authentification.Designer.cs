namespace GestionPensionEtBox
{
    partial class Authentification
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
            lbl_title = new Label();
            lbl_nomPension = new Label();
            txt_nomPension = new TextBox();
            lbl_mdp = new Label();
            txt_mdp = new TextBox();
            btn_cnx = new Button();
            lbl_error = new Label();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(214, 36);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(324, 41);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Connexion au Pension";
            // 
            // lbl_nomPension
            // 
            lbl_nomPension.AutoSize = true;
            lbl_nomPension.Location = new Point(137, 127);
            lbl_nomPension.Name = "lbl_nomPension";
            lbl_nomPension.Size = new Size(46, 20);
            lbl_nomPension.TabIndex = 1;
            lbl_nomPension.Text = "Email";
            // 
            // txt_nomPension
            // 
            txt_nomPension.BackColor = SystemColors.ButtonFace;
            txt_nomPension.BorderStyle = BorderStyle.FixedSingle;
            txt_nomPension.ForeColor = SystemColors.InactiveCaptionText;
            txt_nomPension.Location = new Point(142, 155);
            txt_nomPension.Name = "txt_nomPension";
            txt_nomPension.Size = new Size(435, 27);
            txt_nomPension.TabIndex = 2;
            // 
            // lbl_mdp
            // 
            lbl_mdp.AutoSize = true;
            lbl_mdp.Location = new Point(137, 216);
            lbl_mdp.Name = "lbl_mdp";
            lbl_mdp.Size = new Size(98, 20);
            lbl_mdp.TabIndex = 3;
            lbl_mdp.Text = "Mot de passe";
            // 
            // txt_mdp
            // 
            txt_mdp.BackColor = SystemColors.ButtonFace;
            txt_mdp.BorderStyle = BorderStyle.FixedSingle;
            txt_mdp.ForeColor = SystemColors.InactiveCaptionText;
            txt_mdp.Location = new Point(142, 244);
            txt_mdp.Name = "txt_mdp";
            txt_mdp.PasswordChar = '*';
            txt_mdp.Size = new Size(435, 27);
            txt_mdp.TabIndex = 4;
            // 
            // btn_cnx
            // 
            btn_cnx.BackColor = SystemColors.Menu;
            btn_cnx.Cursor = Cursors.Hand;
            btn_cnx.Location = new Point(273, 317);
            btn_cnx.Name = "btn_cnx";
            btn_cnx.Size = new Size(177, 41);
            btn_cnx.TabIndex = 5;
            btn_cnx.Text = "Connexion";
            btn_cnx.UseVisualStyleBackColor = false;
            btn_cnx.Click += btn_cnx_Click;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(144, 290);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 20);
            lbl_error.TabIndex = 6;
            // 
            // Authentification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(732, 403);
            Controls.Add(lbl_error);
            Controls.Add(btn_cnx);
            Controls.Add(txt_mdp);
            Controls.Add(lbl_mdp);
            Controls.Add(txt_nomPension);
            Controls.Add(lbl_nomPension);
            Controls.Add(lbl_title);
            Cursor = Cursors.IBeam;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Authentification";
            Text = "Authentifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_nomPension;
        private TextBox txt_nomPension;
        private Label lbl_mdp;
        private TextBox txt_mdp;
        private Button btn_cnx;
        private Label lbl_error;
    }
}