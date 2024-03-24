namespace GestionPensionEtBox
{
    partial class GestionPension
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBox_ville = new TextBox();
            txtBox_responsable = new TextBox();
            txtBox_tel = new TextBox();
            txtBox_adresse = new TextBox();
            txtBox_email = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(169, 32);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Pension";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 122);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Ville : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 258);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Adresse : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 213);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Télephone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 166);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Responsable :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 302);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Email :";
            // 
            // txtBox_ville
            // 
            txtBox_ville.BorderStyle = BorderStyle.FixedSingle;
            txtBox_ville.Location = new Point(191, 119);
            txtBox_ville.Name = "txtBox_ville";
            txtBox_ville.Size = new Size(342, 27);
            txtBox_ville.TabIndex = 6;
            // 
            // txtBox_responsable
            // 
            txtBox_responsable.BorderStyle = BorderStyle.FixedSingle;
            txtBox_responsable.Location = new Point(191, 163);
            txtBox_responsable.Name = "txtBox_responsable";
            txtBox_responsable.Size = new Size(342, 27);
            txtBox_responsable.TabIndex = 7;
            // 
            // txtBox_tel
            // 
            txtBox_tel.BorderStyle = BorderStyle.FixedSingle;
            txtBox_tel.Location = new Point(191, 210);
            txtBox_tel.Name = "txtBox_tel";
            txtBox_tel.Size = new Size(342, 27);
            txtBox_tel.TabIndex = 8;
            // 
            // txtBox_adresse
            // 
            txtBox_adresse.BorderStyle = BorderStyle.FixedSingle;
            txtBox_adresse.Location = new Point(191, 258);
            txtBox_adresse.Name = "txtBox_adresse";
            txtBox_adresse.Size = new Size(342, 27);
            txtBox_adresse.TabIndex = 9;
            // 
            // txtBox_email
            // 
            txtBox_email.BorderStyle = BorderStyle.FixedSingle;
            txtBox_email.Location = new Point(191, 302);
            txtBox_email.Name = "txtBox_email";
            txtBox_email.Size = new Size(342, 27);
            txtBox_email.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(203, 375);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 11;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            // 
            // GestionPension
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 450);
            Controls.Add(button1);
            Controls.Add(txtBox_email);
            Controls.Add(txtBox_adresse);
            Controls.Add(txtBox_tel);
            Controls.Add(txtBox_responsable);
            Controls.Add(txtBox_ville);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionPension";
            Text = "GestionPension";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBox_ville;
        private TextBox txtBox_responsable;
        private TextBox txtBox_tel;
        private TextBox txtBox_adresse;
        private TextBox txtBox_email;
        private Button button1;
    }
}