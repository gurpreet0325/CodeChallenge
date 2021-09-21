
namespace CodeChallenge
{
    partial class Form1
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
            this.btnUploadGrid = new System.Windows.Forms.Button();
            this.dgCSVData = new System.Windows.Forms.DataGridView();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepthToWaterLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReplace = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.btnShowValue = new System.Windows.Forms.Button();
            this.btnUploadCombo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadGrid
            // 
            this.btnUploadGrid.Location = new System.Drawing.Point(12, 12);
            this.btnUploadGrid.Name = "btnUploadGrid";
            this.btnUploadGrid.Size = new System.Drawing.Size(94, 29);
            this.btnUploadGrid.TabIndex = 0;
            this.btnUploadGrid.Text = "Upload";
            this.btnUploadGrid.UseVisualStyleBackColor = true;
            this.btnUploadGrid.Click += new System.EventHandler(this.btnUploadGrid_Click);
            // 
            // dgCSVData
            // 
            this.dgCSVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCSVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.ScreenID,
            this.Date,
            this.DepthToWaterLevel,
            this.Comment,
            this.btnDelete});
            this.dgCSVData.Location = new System.Drawing.Point(12, 47);
            this.dgCSVData.Name = "dgCSVData";
            this.dgCSVData.RowHeadersWidth = 51;
            this.dgCSVData.RowTemplate.Height = 29;
            this.dgCSVData.Size = new System.Drawing.Size(809, 330);
            this.dgCSVData.TabIndex = 1;
            this.dgCSVData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCSVData_CellContentClick);
            // 
            // StationName
            // 
            this.StationName.DataPropertyName = "StationName";
            this.StationName.HeaderText = "Station Name";
            this.StationName.MinimumWidth = 6;
            this.StationName.Name = "StationName";
            this.StationName.Width = 125;
            // 
            // ScreenID
            // 
            this.ScreenID.DataPropertyName = "ScreenID";
            this.ScreenID.HeaderText = "Screen ID";
            this.ScreenID.MinimumWidth = 6;
            this.ScreenID.Name = "ScreenID";
            this.ScreenID.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // DepthToWaterLevel
            // 
            this.DepthToWaterLevel.DataPropertyName = "DepthToWaterLevel";
            this.DepthToWaterLevel.HeaderText = "Depth To Water Level";
            this.DepthToWaterLevel.MinimumWidth = 6;
            this.DepthToWaterLevel.Name = "DepthToWaterLevel";
            this.DepthToWaterLevel.Width = 125;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 125;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(136, 12);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(175, 29);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace Character";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(27, 80);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(191, 28);
            this.cbItems.TabIndex = 3;
            // 
            // btnShowValue
            // 
            this.btnShowValue.Location = new System.Drawing.Point(224, 79);
            this.btnShowValue.Name = "btnShowValue";
            this.btnShowValue.Size = new System.Drawing.Size(94, 29);
            this.btnShowValue.TabIndex = 4;
            this.btnShowValue.Text = "Show Value";
            this.btnShowValue.UseVisualStyleBackColor = true;
            this.btnShowValue.Click += new System.EventHandler(this.btnShowValue_Click);
            // 
            // btnUploadCombo
            // 
            this.btnUploadCombo.Location = new System.Drawing.Point(27, 45);
            this.btnUploadCombo.Name = "btnUploadCombo";
            this.btnUploadCombo.Size = new System.Drawing.Size(94, 29);
            this.btnUploadCombo.TabIndex = 5;
            this.btnUploadCombo.Text = "Upload";
            this.btnUploadCombo.UseVisualStyleBackColor = true;
            this.btnUploadCombo.Click += new System.EventHandler(this.btnUploadCombo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUploadCombo);
            this.groupBox1.Controls.Add(this.cbItems);
            this.groupBox1.Controls.Add(this.btnShowValue);
            this.groupBox1.Location = new System.Drawing.Point(12, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.dgCSVData);
            this.Controls.Add(this.btnUploadGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Challenge";
            ((System.ComponentModel.ISupportInitialize)(this.dgCSVData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadGrid;
        private System.Windows.Forms.DataGridView dgCSVData;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Button btnShowValue;
        private System.Windows.Forms.Button btnUploadCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepthToWaterLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}

