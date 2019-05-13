namespace CompanyStructureApp
{
    partial class FirmsView
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
            this.dGVFirms = new System.Windows.Forms.DataGridView();
            this.btnAddFirm = new System.Windows.Forms.Button();
            this.btnEditFirm = new System.Windows.Forms.Button();
            this.btnShowFirm = new System.Windows.Forms.Button();
            this.lblFirmsList = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateCompanytStructure = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFirms)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVFirms
            // 
            this.dGVFirms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFirms.Location = new System.Drawing.Point(15, 25);
            this.dGVFirms.Name = "dGVFirms";
            this.dGVFirms.Size = new System.Drawing.Size(497, 426);
            this.dGVFirms.TabIndex = 1;
            // 
            // btnAddFirm
            // 
            this.btnAddFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddFirm.Location = new System.Drawing.Point(15, 468);
            this.btnAddFirm.Name = "btnAddFirm";
            this.btnAddFirm.Size = new System.Drawing.Size(103, 23);
            this.btnAddFirm.TabIndex = 3;
            this.btnAddFirm.Text = "Pridaj ";
            this.btnAddFirm.UseVisualStyleBackColor = true;
            this.btnAddFirm.Click += new System.EventHandler(this.btnAddFirm_Click);
            // 
            // btnEditFirm
            // 
            this.btnEditFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditFirm.Location = new System.Drawing.Point(138, 468);
            this.btnEditFirm.Name = "btnEditFirm";
            this.btnEditFirm.Size = new System.Drawing.Size(99, 23);
            this.btnEditFirm.TabIndex = 4;
            this.btnEditFirm.Text = "Oprav";
            this.btnEditFirm.UseVisualStyleBackColor = true;
            this.btnEditFirm.Click += new System.EventHandler(this.btnEditFirm_Click);
            // 
            // btnShowFirm
            // 
            this.btnShowFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowFirm.Location = new System.Drawing.Point(257, 468);
            this.btnShowFirm.Name = "btnShowFirm";
            this.btnShowFirm.Size = new System.Drawing.Size(93, 23);
            this.btnShowFirm.TabIndex = 5;
            this.btnShowFirm.Text = "Ukáž";
            this.btnShowFirm.UseVisualStyleBackColor = true;
            this.btnShowFirm.Click += new System.EventHandler(this.btnShowFirm_Click);
            // 
            // lblFirmsList
            // 
            this.lblFirmsList.AutoSize = true;
            this.lblFirmsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirmsList.Location = new System.Drawing.Point(12, 9);
            this.lblFirmsList.Name = "lblFirmsList";
            this.lblFirmsList.Size = new System.Drawing.Size(85, 13);
            this.lblFirmsList.TabIndex = 6;
            this.lblFirmsList.Text = "Zoznam firiem";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(420, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Zatvor";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateCompanytStructure
            // 
            this.btnCreateCompanytStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateCompanytStructure.Location = new System.Drawing.Point(15, 505);
            this.btnCreateCompanytStructure.Name = "btnCreateCompanytStructure";
            this.btnCreateCompanytStructure.Size = new System.Drawing.Size(175, 23);
            this.btnCreateCompanytStructure.TabIndex = 8;
            this.btnCreateCompanytStructure.Text = "Organizačná štruktúra";
            this.btnCreateCompanytStructure.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEmployees.Location = new System.Drawing.Point(209, 505);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(141, 23);
            this.btnEmployees.TabIndex = 9;
            this.btnEmployees.Text = "Zamestnanci";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // FirmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 546);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCreateCompanytStructure);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFirmsList);
            this.Controls.Add(this.btnShowFirm);
            this.Controls.Add(this.btnEditFirm);
            this.Controls.Add(this.btnAddFirm);
            this.Controls.Add(this.dGVFirms);
            this.Name = "FirmsView";
            this.Text = "Firmy";
            ((System.ComponentModel.ISupportInitialize)(this.dGVFirms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVFirms;
        private System.Windows.Forms.Button btnAddFirm;
        private System.Windows.Forms.Button btnEditFirm;
        private System.Windows.Forms.Button btnShowFirm;
        private System.Windows.Forms.Label lblFirmsList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateCompanytStructure;
        private System.Windows.Forms.Button btnEmployees;
    }
}

