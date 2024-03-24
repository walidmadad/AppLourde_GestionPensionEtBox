namespace GestionPensionEtBox
{
    partial class GestionDeBox
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
            txtBox_tarif = new TextBox();
            modifier_btn = new Button();
            label4 = new Label();
            label5 = new Label();
            txtbox_Superficie = new TextBox();
            lbl_nomPension = new Label();
            listBox_TypeGard = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 56);
            label1.Name = "label1";
            label1.Size = new Size(446, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestion des Pensions et des Box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 184);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Type Gardiennage : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 234);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarif par jour (€):";
            // 
            // txtBox_tarif
            // 
            txtBox_tarif.BorderStyle = BorderStyle.FixedSingle;
            txtBox_tarif.Cursor = Cursors.IBeam;
            txtBox_tarif.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_tarif.Location = new Point(305, 232);
            txtBox_tarif.Name = "txtBox_tarif";
            txtBox_tarif.Size = new Size(276, 27);
            txtBox_tarif.TabIndex = 4;
            // 
            // modifier_btn
            // 
            modifier_btn.Cursor = Cursors.Hand;
            modifier_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            modifier_btn.Location = new Point(195, 348);
            modifier_btn.Name = "modifier_btn";
            modifier_btn.Size = new Size(195, 33);
            modifier_btn.TabIndex = 5;
            modifier_btn.Text = "Modifier";
            modifier_btn.UseVisualStyleBackColor = true;
            modifier_btn.Click += modifier_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(276, 121);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 6;
            label4.Text = "Type Gardiennage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 286);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 7;
            label5.Text = "Superficie Box (m²) :";
            // 
            // txtbox_Superficie
            // 
            txtbox_Superficie.BorderStyle = BorderStyle.FixedSingle;
            txtbox_Superficie.Cursor = Cursors.IBeam;
            txtbox_Superficie.Location = new Point(305, 284);
            txtbox_Superficie.Name = "txtbox_Superficie";
            txtbox_Superficie.Size = new Size(276, 27);
            txtbox_Superficie.TabIndex = 8;
            // 
            // lbl_nomPension
            // 
            lbl_nomPension.AutoSize = true;
            lbl_nomPension.Location = new Point(335, 20);
            lbl_nomPension.Name = "lbl_nomPension";
            lbl_nomPension.Size = new Size(0, 20);
            lbl_nomPension.TabIndex = 9;
            // 
            // listBox_TypeGard
            // 
            listBox_TypeGard.Cursor = Cursors.Hand;
            listBox_TypeGard.FormattingEnabled = true;
            listBox_TypeGard.Location = new Point(305, 181);
            listBox_TypeGard.Name = "listBox_TypeGard";
            listBox_TypeGard.Size = new Size(276, 28);
            listBox_TypeGard.TabIndex = 10;
            listBox_TypeGard.Text = "Choisissez le Type de Gardiennage";
            listBox_TypeGard.SelectedIndexChanged += listBox_TypeGard_SelectedIndexChanged;
            // 
            // GestionDePension
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 403);
            Controls.Add(listBox_TypeGard);
            Controls.Add(lbl_nomPension);
            Controls.Add(txtbox_Superficie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(modifier_btn);
            Controls.Add(txtBox_tarif);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionDePension";
            Text = "Gestion De Pension";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBox_tarif;
        private Button modifier_btn;
        private Label label4;
        private Label label5;
        private TextBox txtbox_Superficie;
        public Label lbl_nomPension;
        private ComboBox listBox_TypeGard;
    }
}