namespace ImportExcell.Forms
{
    partial class ImportExcell
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExcellColumn = new DevExpress.XtraEditors.TextEdit();
            this.txtTableColumn = new DevExpress.XtraEditors.TextEdit();
            this.txtDataType = new DevExpress.XtraEditors.TextEdit();
            this.txtSheet = new DevExpress.XtraEditors.TextEdit();
            this.txtDbName = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnReadExcell = new System.Windows.Forms.Button();
            this.btnImportExcell = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcellColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excell Column Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DB Column Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Excell Sheet Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DB Table Name";
            // 
            // txtExcellColumn
            // 
            this.txtExcellColumn.Location = new System.Drawing.Point(268, 61);
            this.txtExcellColumn.Name = "txtExcellColumn";
            this.txtExcellColumn.Size = new System.Drawing.Size(100, 20);
            this.txtExcellColumn.TabIndex = 5;
            // 
            // txtTableColumn
            // 
            this.txtTableColumn.Location = new System.Drawing.Point(268, 88);
            this.txtTableColumn.Name = "txtTableColumn";
            this.txtTableColumn.Size = new System.Drawing.Size(100, 20);
            this.txtTableColumn.TabIndex = 6;
            // 
            // txtDataType
            // 
            this.txtDataType.Location = new System.Drawing.Point(268, 115);
            this.txtDataType.Name = "txtDataType";
            this.txtDataType.Size = new System.Drawing.Size(100, 20);
            this.txtDataType.TabIndex = 7;
            // 
            // txtSheet
            // 
            this.txtSheet.Location = new System.Drawing.Point(164, 235);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(100, 20);
            this.txtSheet.TabIndex = 8;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(393, 235);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(100, 20);
            this.txtDbName.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 184);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 294);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1043, 163);
            this.dataGridView2.TabIndex = 11;
            // 
            // BtnReadExcell
            // 
            this.BtnReadExcell.Location = new System.Drawing.Point(164, 265);
            this.BtnReadExcell.Name = "BtnReadExcell";
            this.BtnReadExcell.Size = new System.Drawing.Size(75, 23);
            this.BtnReadExcell.TabIndex = 12;
            this.BtnReadExcell.Text = "Read Excell";
            this.BtnReadExcell.UseVisualStyleBackColor = true;
            this.BtnReadExcell.Click += new System.EventHandler(this.BtnReadExcell_Click);
            // 
            // btnImportExcell
            // 
            this.btnImportExcell.Location = new System.Drawing.Point(393, 261);
            this.btnImportExcell.Name = "btnImportExcell";
            this.btnImportExcell.Size = new System.Drawing.Size(100, 23);
            this.btnImportExcell.TabIndex = 13;
            this.btnImportExcell.Text = "İmport Excell";
            this.btnImportExcell.UseVisualStyleBackColor = true;
            this.btnImportExcell.Click += new System.EventHandler(this.btnImportExcell_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(328, 141);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ImportExcell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 457);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImportExcell);
            this.Controls.Add(this.BtnReadExcell);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.txtSheet);
            this.Controls.Add(this.txtDataType);
            this.Controls.Add(this.txtTableColumn);
            this.Controls.Add(this.txtExcellColumn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImportExcell";
            this.Text = "ImportExcell";
            this.Load += new System.EventHandler(this.ImportExcell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExcellColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtExcellColumn;
        private DevExpress.XtraEditors.TextEdit txtTableColumn;
        private DevExpress.XtraEditors.TextEdit txtDataType;
        private DevExpress.XtraEditors.TextEdit txtSheet;
        private DevExpress.XtraEditors.TextEdit txtDbName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnReadExcell;
        private System.Windows.Forms.Button btnImportExcell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}