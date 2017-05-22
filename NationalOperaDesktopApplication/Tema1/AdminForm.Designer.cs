namespace Tema1
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.showControlPanel = new System.Windows.Forms.Panel();
            this.labelOra = new System.Windows.Forms.Label();
            this.dateTimePickerOra = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewShowsTable = new System.Windows.Forms.DataGridView();
            this.ColumnShowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistributia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataPremierei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumarBilete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeleteShow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnUpdateShow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.numericUpDownNumarBilete = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDataPremierei = new System.Windows.Forms.DateTimePicker();
            this.lblMessageS = new System.Windows.Forms.Label();
            this.lblInfoS = new System.Windows.Forms.Label();
            this.comboBoxGenul = new System.Windows.Forms.ComboBox();
            this.lblGenul = new System.Windows.Forms.Label();
            this.btnAddS = new System.Windows.Forms.Button();
            this.textBoxDistributia = new System.Windows.Forms.TextBox();
            this.textBoxRegia = new System.Windows.Forms.TextBox();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.lblNumarBilete = new System.Windows.Forms.Label();
            this.lblDataPremierei = new System.Windows.Forms.Label();
            this.lblDistributia = new System.Windows.Forms.Label();
            this.lblRegia = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewUsersTable = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnUpdateRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.comboBoxShow = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControlPanel.SuspendLayout();
            this.showControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumarBilete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // userControlPanel
            // 
            this.userControlPanel.Controls.Add(this.showControlPanel);
            this.userControlPanel.Controls.Add(this.comboBoxRole);
            this.userControlPanel.Controls.Add(this.lblMessage);
            this.userControlPanel.Controls.Add(this.textBoxPassword);
            this.userControlPanel.Controls.Add(this.dataGridViewUsersTable);
            this.userControlPanel.Controls.Add(this.textBoxName);
            this.userControlPanel.Controls.Add(this.textBoxUsername);
            this.userControlPanel.Controls.Add(this.btnAdd);
            this.userControlPanel.Controls.Add(this.lblRole);
            this.userControlPanel.Controls.Add(this.lblPassword);
            this.userControlPanel.Controls.Add(this.lblName);
            this.userControlPanel.Controls.Add(this.lblUsername);
            this.userControlPanel.Controls.Add(this.lblInfo);
            this.userControlPanel.Location = new System.Drawing.Point(1, 33);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(953, 405);
            this.userControlPanel.TabIndex = 1;
            // 
            // showControlPanel
            // 
            this.showControlPanel.Controls.Add(this.labelOra);
            this.showControlPanel.Controls.Add(this.dateTimePickerOra);
            this.showControlPanel.Controls.Add(this.dataGridViewShowsTable);
            this.showControlPanel.Controls.Add(this.numericUpDownNumarBilete);
            this.showControlPanel.Controls.Add(this.dateTimePickerDataPremierei);
            this.showControlPanel.Controls.Add(this.lblMessageS);
            this.showControlPanel.Controls.Add(this.lblInfoS);
            this.showControlPanel.Controls.Add(this.comboBoxGenul);
            this.showControlPanel.Controls.Add(this.lblGenul);
            this.showControlPanel.Controls.Add(this.btnAddS);
            this.showControlPanel.Controls.Add(this.textBoxDistributia);
            this.showControlPanel.Controls.Add(this.textBoxRegia);
            this.showControlPanel.Controls.Add(this.textBoxTitlu);
            this.showControlPanel.Controls.Add(this.lblNumarBilete);
            this.showControlPanel.Controls.Add(this.lblDataPremierei);
            this.showControlPanel.Controls.Add(this.lblDistributia);
            this.showControlPanel.Controls.Add(this.lblRegia);
            this.showControlPanel.Controls.Add(this.lblTitlu);
            this.showControlPanel.Location = new System.Drawing.Point(0, 17);
            this.showControlPanel.Name = "showControlPanel";
            this.showControlPanel.Size = new System.Drawing.Size(950, 393);
            this.showControlPanel.TabIndex = 16;
            // 
            // labelOra
            // 
            this.labelOra.AutoSize = true;
            this.labelOra.Location = new System.Drawing.Point(33, 221);
            this.labelOra.Name = "labelOra";
            this.labelOra.Size = new System.Drawing.Size(31, 13);
            this.labelOra.TabIndex = 22;
            this.labelOra.Text = "*Ora:";
            // 
            // dateTimePickerOra
            // 
            this.dateTimePickerOra.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOra.Location = new System.Drawing.Point(115, 215);
            this.dateTimePickerOra.Name = "dateTimePickerOra";
            this.dateTimePickerOra.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerOra.TabIndex = 21;
            // 
            // dataGridViewShowsTable
            // 
            this.dataGridViewShowsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShowsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnShowID,
            this.ColumnTitlu,
            this.ColumnGenul,
            this.ColumnRegia,
            this.ColumnDistributia,
            this.ColumnDataPremierei,
            this.ColumnNumarBilete,
            this.ColumnDeleteShow,
            this.ColumnUpdateShow});
            this.dataGridViewShowsTable.Location = new System.Drawing.Point(242, 28);
            this.dataGridViewShowsTable.Name = "dataGridViewShowsTable";
            this.dataGridViewShowsTable.Size = new System.Drawing.Size(705, 360);
            this.dataGridViewShowsTable.TabIndex = 20;
            this.dataGridViewShowsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowsTable_CellContentClick);
            // 
            // ColumnShowID
            // 
            this.ColumnShowID.HeaderText = "ID";
            this.ColumnShowID.Name = "ColumnShowID";
            this.ColumnShowID.Visible = false;
            // 
            // ColumnTitlu
            // 
            this.ColumnTitlu.HeaderText = "Titlu";
            this.ColumnTitlu.Name = "ColumnTitlu";
            // 
            // ColumnGenul
            // 
            this.ColumnGenul.HeaderText = "Genul";
            this.ColumnGenul.Name = "ColumnGenul";
            this.ColumnGenul.Width = 80;
            // 
            // ColumnRegia
            // 
            this.ColumnRegia.HeaderText = "Regia";
            this.ColumnRegia.Name = "ColumnRegia";
            // 
            // ColumnDistributia
            // 
            this.ColumnDistributia.HeaderText = "Distributia";
            this.ColumnDistributia.Name = "ColumnDistributia";
            // 
            // ColumnDataPremierei
            // 
            this.ColumnDataPremierei.HeaderText = "Data Premierei";
            this.ColumnDataPremierei.Name = "ColumnDataPremierei";
            this.ColumnDataPremierei.Width = 70;
            // 
            // ColumnNumarBilete
            // 
            this.ColumnNumarBilete.HeaderText = "Numar Bilete";
            this.ColumnNumarBilete.Name = "ColumnNumarBilete";
            this.ColumnNumarBilete.Width = 50;
            // 
            // ColumnDeleteShow
            // 
            this.ColumnDeleteShow.HeaderText = "";
            this.ColumnDeleteShow.Name = "ColumnDeleteShow";
            this.ColumnDeleteShow.Width = 70;
            // 
            // ColumnUpdateShow
            // 
            this.ColumnUpdateShow.HeaderText = "";
            this.ColumnUpdateShow.Name = "ColumnUpdateShow";
            this.ColumnUpdateShow.Width = 70;
            // 
            // numericUpDownNumarBilete
            // 
            this.numericUpDownNumarBilete.Location = new System.Drawing.Point(115, 256);
            this.numericUpDownNumarBilete.Name = "numericUpDownNumarBilete";
            this.numericUpDownNumarBilete.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownNumarBilete.TabIndex = 19;
            // 
            // dateTimePickerDataPremierei
            // 
            this.dateTimePickerDataPremierei.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataPremierei.Location = new System.Drawing.Point(115, 180);
            this.dateTimePickerDataPremierei.Name = "dateTimePickerDataPremierei";
            this.dateTimePickerDataPremierei.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDataPremierei.TabIndex = 17;
            // 
            // lblMessageS
            // 
            this.lblMessageS.AutoSize = true;
            this.lblMessageS.Location = new System.Drawing.Point(31, 320);
            this.lblMessageS.Name = "lblMessageS";
            this.lblMessageS.Size = new System.Drawing.Size(0, 13);
            this.lblMessageS.TabIndex = 16;
            // 
            // lblInfoS
            // 
            this.lblInfoS.AutoSize = true;
            this.lblInfoS.Location = new System.Drawing.Point(30, 295);
            this.lblInfoS.Name = "lblInfoS";
            this.lblInfoS.Size = new System.Drawing.Size(186, 13);
            this.lblInfoS.TabIndex = 15;
            this.lblInfoS.Text = "Campurile marcate cu * sunt obligatorii";
            // 
            // comboBoxGenul
            // 
            this.comboBoxGenul.FormattingEnabled = true;
            this.comboBoxGenul.Items.AddRange(new object[] {
            "Balet",
            "Opera",
            "Opereta"});
            this.comboBoxGenul.Location = new System.Drawing.Point(115, 28);
            this.comboBoxGenul.Name = "comboBoxGenul";
            this.comboBoxGenul.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenul.TabIndex = 14;
            this.comboBoxGenul.Text = "Balet";
            // 
            // lblGenul
            // 
            this.lblGenul.AutoSize = true;
            this.lblGenul.Location = new System.Drawing.Point(31, 31);
            this.lblGenul.Name = "lblGenul";
            this.lblGenul.Size = new System.Drawing.Size(42, 13);
            this.lblGenul.TabIndex = 13;
            this.lblGenul.Text = "*Genul:";
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(33, 363);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(95, 25);
            this.btnAddS.TabIndex = 10;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // textBoxDistributia
            // 
            this.textBoxDistributia.Location = new System.Drawing.Point(115, 142);
            this.textBoxDistributia.Name = "textBoxDistributia";
            this.textBoxDistributia.Size = new System.Drawing.Size(121, 20);
            this.textBoxDistributia.TabIndex = 7;
            // 
            // textBoxRegia
            // 
            this.textBoxRegia.Location = new System.Drawing.Point(115, 103);
            this.textBoxRegia.Name = "textBoxRegia";
            this.textBoxRegia.Size = new System.Drawing.Size(121, 20);
            this.textBoxRegia.TabIndex = 6;
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(115, 66);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitlu.TabIndex = 5;
            // 
            // lblNumarBilete
            // 
            this.lblNumarBilete.AutoSize = true;
            this.lblNumarBilete.Location = new System.Drawing.Point(31, 258);
            this.lblNumarBilete.Name = "lblNumarBilete";
            this.lblNumarBilete.Size = new System.Drawing.Size(74, 13);
            this.lblNumarBilete.TabIndex = 4;
            this.lblNumarBilete.Text = "*Numar Bilete:";
            // 
            // lblDataPremierei
            // 
            this.lblDataPremierei.AutoSize = true;
            this.lblDataPremierei.Location = new System.Drawing.Point(31, 186);
            this.lblDataPremierei.Name = "lblDataPremierei";
            this.lblDataPremierei.Size = new System.Drawing.Size(83, 13);
            this.lblDataPremierei.TabIndex = 3;
            this.lblDataPremierei.Text = "*Data Premierei:";
            // 
            // lblDistributia
            // 
            this.lblDistributia.AutoSize = true;
            this.lblDistributia.Location = new System.Drawing.Point(30, 145);
            this.lblDistributia.Name = "lblDistributia";
            this.lblDistributia.Size = new System.Drawing.Size(60, 13);
            this.lblDistributia.TabIndex = 2;
            this.lblDistributia.Text = "*Distributia:";
            // 
            // lblRegia
            // 
            this.lblRegia.AutoSize = true;
            this.lblRegia.Location = new System.Drawing.Point(30, 106);
            this.lblRegia.Name = "lblRegia";
            this.lblRegia.Size = new System.Drawing.Size(42, 13);
            this.lblRegia.TabIndex = 1;
            this.lblRegia.Text = "*Regia:";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(30, 69);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(34, 13);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "*Titlu:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Casier"});
            this.comboBoxRole.Location = new System.Drawing.Point(102, 186);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(169, 21);
            this.comboBoxRole.TabIndex = 13;
            this.comboBoxRole.Text = "Casier";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(24, 268);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(102, 139);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // dataGridViewUsersTable
            // 
            this.dataGridViewUsersTable.AllowUserToOrderColumns = true;
            this.dataGridViewUsersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnUsername,
            this.ColumnRole,
            this.ColumnDeleteRow,
            this.ColumnUpdateRow});
            this.dataGridViewUsersTable.Location = new System.Drawing.Point(426, 44);
            this.dataGridViewUsersTable.Name = "dataGridViewUsersTable";
            this.dataGridViewUsersTable.Size = new System.Drawing.Size(488, 290);
            this.dataGridViewUsersTable.TabIndex = 12;
            this.dataGridViewUsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 40;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.Name = "ColumnUsername";
            // 
            // ColumnRole
            // 
            this.ColumnRole.HeaderText = "Role";
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.Width = 80;
            // 
            // ColumnDeleteRow
            // 
            this.ColumnDeleteRow.HeaderText = "";
            this.ColumnDeleteRow.Name = "ColumnDeleteRow";
            this.ColumnDeleteRow.Text = "";
            this.ColumnDeleteRow.Width = 70;
            // 
            // ColumnUpdateRow
            // 
            this.ColumnUpdateRow.HeaderText = "";
            this.ColumnUpdateRow.Name = "ColumnUpdateRow";
            this.ColumnUpdateRow.Width = 70;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(169, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(102, 44);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(169, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 25);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(24, 186);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 13);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "*Role:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "*Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "*Name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(24, 44);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(62, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "*Username:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(24, 232);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(189, 13);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Campurile marcate cu *  sunt obligatorii";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(13, 9);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(64, 13);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "User/Show:";
            // 
            // comboBoxShow
            // 
            this.comboBoxShow.FormattingEnabled = true;
            this.comboBoxShow.Items.AddRange(new object[] {
            "User",
            "Show"});
            this.comboBoxShow.Location = new System.Drawing.Point(83, 6);
            this.comboBoxShow.Name = "comboBoxShow";
            this.comboBoxShow.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShow.TabIndex = 3;
            this.comboBoxShow.Text = "User";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(210, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.comboBoxShow);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.userControlPanel);
            this.Name = "AdminForm";
            this.Text = "Admin Window";
            this.userControlPanel.ResumeLayout(false);
            this.userControlPanel.PerformLayout();
            this.showControlPanel.ResumeLayout(false);
            this.showControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumarBilete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox comboBoxShow;
        private System.Windows.Forms.DataGridView dataGridViewUsersTable;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel showControlPanel;
        private System.Windows.Forms.Label lblNumarBilete;
        private System.Windows.Forms.Label lblDataPremierei;
        private System.Windows.Forms.Label lblDistributia;
        private System.Windows.Forms.Label lblRegia;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.TextBox textBoxDistributia;
        private System.Windows.Forms.TextBox textBoxRegia;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.Label lblMessageS;
        private System.Windows.Forms.Label lblInfoS;
        private System.Windows.Forms.ComboBox comboBoxGenul;
        private System.Windows.Forms.Label lblGenul;
        private System.Windows.Forms.NumericUpDown numericUpDownNumarBilete;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataPremierei;
        private System.Windows.Forms.DataGridView dataGridViewShowsTable;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenul;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistributia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataPremierei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumarBilete;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteShow;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnUpdateShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeleteRow;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnUpdateRow;
        private System.Windows.Forms.Label labelOra;
        private System.Windows.Forms.DateTimePicker dateTimePickerOra;
    }
}