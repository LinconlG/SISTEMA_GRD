﻿
namespace ControladorGRD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnResp = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.labelUser);
            this.panelMenu.Controls.Add(this.linkLabel1);
            this.panelMenu.Controls.Add(this.btnResp);
            this.panelMenu.Controls.Add(this.btnEmitir);
            this.panelMenu.Controls.Add(this.btnReceber);
            this.panelMenu.Controls.Add(this.btnBuscar);
            this.panelMenu.Controls.Add(this.btnDoc);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 728);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ControladorGRD.Properties.Resources.pngwinguser;
            this.pictureBox1.Location = new System.Drawing.Point(55, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 88);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("PF Square Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(52, 650);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(37, 18);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "User";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(67, 668);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnResp
            // 
            this.btnResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnResp.FlatAppearance.BorderSize = 0;
            this.btnResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResp.Font = new System.Drawing.Font("PF Square Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResp.ForeColor = System.Drawing.Color.White;
            this.btnResp.Image = global::ControladorGRD.Properties.Resources.pngwing_com2;
            this.btnResp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResp.Location = new System.Drawing.Point(0, 454);
            this.btnResp.Name = "btnResp";
            this.btnResp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnResp.Size = new System.Drawing.Size(195, 60);
            this.btnResp.TabIndex = 5;
            this.btnResp.Text = "Cadastrar Responsável";
            this.btnResp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResp.UseVisualStyleBackColor = false;
            this.btnResp.Click += new System.EventHandler(this.btnResp_Click);
            // 
            // btnEmitir
            // 
            this.btnEmitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnEmitir.FlatAppearance.BorderSize = 0;
            this.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitir.Font = new System.Drawing.Font("PF Square Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitir.ForeColor = System.Drawing.Color.White;
            this.btnEmitir.Image = global::ControladorGRD.Properties.Resources.certificado2;
            this.btnEmitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitir.Location = new System.Drawing.Point(0, 256);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmitir.Size = new System.Drawing.Size(195, 60);
            this.btnEmitir.TabIndex = 4;
            this.btnEmitir.Text = "Emitir GRD";
            this.btnEmitir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmitir.UseVisualStyleBackColor = false;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnReceber.FlatAppearance.BorderSize = 0;
            this.btnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceber.Font = new System.Drawing.Font("PF Square Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceber.ForeColor = System.Drawing.Color.White;
            this.btnReceber.Image = global::ControladorGRD.Properties.Resources.doc_assinado2;
            this.btnReceber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceber.Location = new System.Drawing.Point(0, 322);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReceber.Size = new System.Drawing.Size(195, 60);
            this.btnReceber.TabIndex = 3;
            this.btnReceber.Text = "Gerenciar GRD";
            this.btnReceber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("PF Square Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ControladorGRD.Properties.Resources.varios_docs_checados2;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(0, 388);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(195, 60);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnDoc.FlatAppearance.BorderSize = 0;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("PF Square Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.Color.White;
            this.btnDoc.Image = global::ControladorGRD.Properties.Resources.varios_docs4;
            this.btnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.Location = new System.Drawing.Point(3, 190);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDoc.Size = new System.Drawing.Size(195, 60);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Cadastrar Documento";
            this.btnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.Image = global::ControladorGRD.Properties.Resources.Picture4;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 90);
            this.Logo.TabIndex = 0;
            this.Logo.UseVisualStyleBackColor = true;
            this.Logo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(783, 90);
            this.panelTitulo.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("PF Square Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.labelTitulo.Location = new System.Drawing.Point(201, 35);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(343, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PESSOAS QUE FAZEM A DIFERENÇA";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(783, 638);
            this.panelDesktop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PF Square Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(326, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bem vindo!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PF Square Sans Pro Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(327, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ótimo dia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(983, 728);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlador de GRD";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnResp;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

