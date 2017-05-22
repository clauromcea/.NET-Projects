namespace Tema1
{
    partial class CashierForm
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
            this.lblNumeSpectacol = new System.Windows.Forms.Label();
            this.lblRand = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.textBoxNumeSpectacol = new System.Windows.Forms.TextBox();
            this.textBoxRand = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewTicketsTable = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumeSpectacol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeleteTicket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.numericUpDownLoc = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewShowsTable = new System.Windows.Forms.DataGridView();
            this.ColumnShowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowDataPremierei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowNumarBilete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeSpectacol
            // 
            this.lblNumeSpectacol.AutoSize = true;
            this.lblNumeSpectacol.Location = new System.Drawing.Point(26, 53);
            this.lblNumeSpectacol.Name = "lblNumeSpectacol";
            this.lblNumeSpectacol.Size = new System.Drawing.Size(93, 13);
            this.lblNumeSpectacol.TabIndex = 0;
            this.lblNumeSpectacol.Text = "*Nume Spectacol:";
            // 
            // lblRand
            // 
            this.lblRand.AutoSize = true;
            this.lblRand.Location = new System.Drawing.Point(26, 103);
            this.lblRand.Name = "lblRand";
            this.lblRand.Size = new System.Drawing.Size(40, 13);
            this.lblRand.TabIndex = 1;
            this.lblRand.Text = "*Rand:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(26, 152);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(32, 13);
            this.lblLoc.TabIndex = 2;
            this.lblLoc.Text = "*Loc:";
            // 
            // textBoxNumeSpectacol
            // 
            this.textBoxNumeSpectacol.Location = new System.Drawing.Point(121, 50);
            this.textBoxNumeSpectacol.Name = "textBoxNumeSpectacol";
            this.textBoxNumeSpectacol.Size = new System.Drawing.Size(150, 20);
            this.textBoxNumeSpectacol.TabIndex = 3;
            // 
            // textBoxRand
            // 
            this.textBoxRand.Location = new System.Drawing.Point(121, 100);
            this.textBoxRand.Name = "textBoxRand";
            this.textBoxRand.Size = new System.Drawing.Size(150, 20);
            this.textBoxRand.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewTicketsTable
            // 
            this.dataGridViewTicketsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTicketsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTicketsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNumeSpectacol,
            this.ColumnRand,
            this.ColumnLoc,
            this.ColumnDeleteTicket});
            this.dataGridViewTicketsTable.Location = new System.Drawing.Point(318, 50);
            this.dataGridViewTicketsTable.Name = "dataGridViewTicketsTable";
            this.dataGridViewTicketsTable.Size = new System.Drawing.Size(439, 168);
            this.dataGridViewTicketsTable.TabIndex = 7;
            this.dataGridViewTicketsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // ColumnNumeSpectacol
            // 
            this.ColumnNumeSpectacol.HeaderText = "Nume Spectacol";
            this.ColumnNumeSpectacol.Name = "ColumnNumeSpectacol";
            // 
            // ColumnRand
            // 
            this.ColumnRand.HeaderText = "Rand";
            this.ColumnRand.Name = "ColumnRand";
            // 
            // ColumnLoc
            // 
            this.ColumnLoc.HeaderText = "Loc";
            this.ColumnLoc.Name = "ColumnLoc";
            // 
            // ColumnDeleteTicket
            // 
            this.ColumnDeleteTicket.HeaderText = "";
            this.ColumnDeleteTicket.Name = "ColumnDeleteTicket";
            this.ColumnDeleteTicket.Width = 70;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(29, 205);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(186, 13);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Campurile marcate cu * sunt obligatorii";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(29, 240);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 9;
            // 
            // numericUpDownLoc
            // 
            this.numericUpDownLoc.Location = new System.Drawing.Point(121, 150);
            this.numericUpDownLoc.Name = "numericUpDownLoc";
            this.numericUpDownLoc.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownLoc.TabIndex = 10;
            // 
            // dataGridViewShowsTable
            // 
            this.dataGridViewShowsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShowsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnShowID,
            this.ColumnShowTitle,
            this.ColumnShowDataPremierei,
            this.ColumnShowNumarBilete});
            this.dataGridViewShowsTable.Location = new System.Drawing.Point(318, 240);
            this.dataGridViewShowsTable.Name = "dataGridViewShowsTable";
            this.dataGridViewShowsTable.Size = new System.Drawing.Size(433, 150);
            this.dataGridViewShowsTable.TabIndex = 11;
            // 
            // ColumnShowID
            // 
            this.ColumnShowID.HeaderText = "ID";
            this.ColumnShowID.Name = "ColumnShowID";
            this.ColumnShowID.Visible = false;
            // 
            // ColumnShowTitle
            // 
            this.ColumnShowTitle.HeaderText = "Titlu";
            this.ColumnShowTitle.Name = "ColumnShowTitle";
            this.ColumnShowTitle.Width = 120;
            // 
            // ColumnShowDataPremierei
            // 
            this.ColumnShowDataPremierei.HeaderText = "Data Premierei";
            this.ColumnShowDataPremierei.Name = "ColumnShowDataPremierei";
            this.ColumnShowDataPremierei.Width = 150;
            // 
            // ColumnShowNumarBilete
            // 
            this.ColumnShowNumarBilete.HeaderText = "NumarBilete";
            this.ColumnShowNumarBilete.Name = "ColumnShowNumarBilete";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 497);
            this.Controls.Add(this.dataGridViewShowsTable);
            this.Controls.Add(this.numericUpDownLoc);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewTicketsTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxRand);
            this.Controls.Add(this.textBoxNumeSpectacol);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblRand);
            this.Controls.Add(this.lblNumeSpectacol);
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeSpectacol;
        private System.Windows.Forms.Label lblRand;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.TextBox textBoxNumeSpectacol;
        private System.Windows.Forms.TextBox textBoxRand;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewTicketsTable;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeSpectacol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLoc;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteTicket;
        private System.Windows.Forms.NumericUpDown numericUpDownLoc;
        private System.Windows.Forms.DataGridView dataGridViewShowsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowDataPremierei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowNumarBilete;
    }
}