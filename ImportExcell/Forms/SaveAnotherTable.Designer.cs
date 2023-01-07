namespace ImportExcell.Forms
{
    partial class SaveAnotherTable
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
            this.txtDataType = new DevExpress.XtraEditors.TextEdit();
            this.txtTableColumn = new DevExpress.XtraEditors.TextEdit();
            this.txtExcellColumn = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDbName = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcellColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataType
            // 
            this.txtDataType.Location = new System.Drawing.Point(172, 94);
            this.txtDataType.Name = "txtDataType";
            this.txtDataType.Size = new System.Drawing.Size(100, 20);
            this.txtDataType.TabIndex = 13;
            // 
            // txtTableColumn
            // 
            this.txtTableColumn.Location = new System.Drawing.Point(172, 67);
            this.txtTableColumn.Name = "txtTableColumn";
            this.txtTableColumn.Size = new System.Drawing.Size(100, 20);
            this.txtTableColumn.TabIndex = 12;
            // 
            // txtExcellColumn
            // 
            this.txtExcellColumn.Location = new System.Drawing.Point(172, 40);
            this.txtExcellColumn.Name = "txtExcellColumn";
            this.txtExcellColumn.Size = new System.Drawing.Size(100, 20);
            this.txtExcellColumn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DB Column Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Excell Column Name";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(172, 120);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(100, 20);
            this.txtDbName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DB Table Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SaveAnotherTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataType);
            this.Controls.Add(this.txtTableColumn);
            this.Controls.Add(this.txtExcellColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaveAnotherTable";
            this.Text = "Save Another Table";
            ((System.ComponentModel.ISupportInitialize)(this.txtDataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcellColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDataType;
        private DevExpress.XtraEditors.TextEdit txtTableColumn;
        private DevExpress.XtraEditors.TextEdit txtExcellColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}