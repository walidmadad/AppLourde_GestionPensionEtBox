namespace GestionPensionEtBox
{
    partial class Menu
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
            label1 = new Label();
            btn_paraPension = new Button();
            btn_gestionBox = new Button();
            btn_changerPension = new Button();
            lbl_nomPension = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 49);
            label1.Name = "label1";
            label1.Size = new Size(233, 37);
            label1.TabIndex = 0;
            label1.Text = "GestionDePension";
            // 
            // btn_paraPension
            // 
            btn_paraPension.Location = new Point(268, 129);
            btn_paraPension.Name = "btn_paraPension";
            btn_paraPension.Size = new Size(245, 42);
            btn_paraPension.TabIndex = 1;
            btn_paraPension.Text = "Parametres Pension";
            btn_paraPension.UseVisualStyleBackColor = true;
            btn_paraPension.Click += btn_paraPension_Click;
            // 
            // btn_gestionBox
            // 
            btn_gestionBox.Location = new Point(268, 204);
            btn_gestionBox.Name = "btn_gestionBox";
            btn_gestionBox.Size = new Size(245, 42);
            btn_gestionBox.TabIndex = 2;
            btn_gestionBox.Text = "Gestion des Box";
            btn_gestionBox.UseVisualStyleBackColor = true;
            btn_gestionBox.Click += btn_gestionBox_Click;
            // 
            // btn_changerPension
            // 
            btn_changerPension.Location = new Point(268, 279);
            btn_changerPension.Name = "btn_changerPension";
            btn_changerPension.Size = new Size(245, 42);
            btn_changerPension.TabIndex = 3;
            btn_changerPension.Text = "Changer de pension";
            btn_changerPension.UseVisualStyleBackColor = true;
            btn_changerPension.Click += btn_changerPension_Click;
            // 
            // lbl_nomPension
            // 
            lbl_nomPension.AutoSize = true;
            lbl_nomPension.Location = new Point(342, 21);
            lbl_nomPension.Name = "lbl_nomPension";
            lbl_nomPension.Size = new Size(0, 20);
            lbl_nomPension.TabIndex = 10;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(lbl_nomPension);
            Controls.Add(btn_changerPension);
            Controls.Add(btn_gestionBox);
            Controls.Add(btn_paraPension);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_paraPension;
        private Button btn_gestionBox;
        private Button btn_changerPension;
        public Label lbl_nomPension;
    }
}