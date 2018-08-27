namespace BootCDNAPIDemo
{
    partial class FrmLibraries
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
            this.lstLibrarie = new System.Windows.Forms.ListBox();
            this.grpLst = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblStarts = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtStarts = new System.Windows.Forms.TextBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnDetailed = new System.Windows.Forms.Button();
            this.grpLst.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLibrarie
            // 
            this.lstLibrarie.FormattingEnabled = true;
            this.lstLibrarie.ItemHeight = 20;
            this.lstLibrarie.Location = new System.Drawing.Point(10, 65);
            this.lstLibrarie.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstLibrarie.Name = "lstLibrarie";
            this.lstLibrarie.Size = new System.Drawing.Size(318, 464);
            this.lstLibrarie.TabIndex = 0;
            this.lstLibrarie.SelectedIndexChanged += new System.EventHandler(this.lstLibrarie_SelectedIndexChanged);
            // 
            // grpLst
            // 
            this.grpLst.Controls.Add(this.txtQuery);
            this.grpLst.Controls.Add(this.lblQuery);
            this.grpLst.Controls.Add(this.lstLibrarie);
            this.grpLst.Location = new System.Drawing.Point(10, 15);
            this.grpLst.Name = "grpLst";
            this.grpLst.Size = new System.Drawing.Size(344, 537);
            this.grpLst.TabIndex = 1;
            this.grpLst.TabStop = false;
            this.grpLst.Text = "开源库列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDetailed);
            this.groupBox2.Controls.Add(this.txtStarts);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblStarts);
            this.groupBox2.Controls.Add(this.lblDesc);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(363, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 537);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名称:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(10, 142);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(59, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "描述:";
            // 
            // lblStarts
            // 
            this.lblStarts.AutoSize = true;
            this.lblStarts.Location = new System.Drawing.Point(10, 82);
            this.lblStarts.Name = "lblStarts";
            this.lblStarts.Size = new System.Drawing.Size(79, 20);
            this.lblStarts.TabIndex = 2;
            this.lblStarts.Text = "星标数:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(248, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(95, 142);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(248, 336);
            this.txtDesc.TabIndex = 4;
            // 
            // txtStarts
            // 
            this.txtStarts.Location = new System.Drawing.Point(95, 77);
            this.txtStarts.Name = "txtStarts";
            this.txtStarts.ReadOnly = true;
            this.txtStarts.Size = new System.Drawing.Size(248, 30);
            this.txtStarts.TabIndex = 5;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(10, 30);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(59, 20);
            this.lblQuery.TabIndex = 1;
            this.lblQuery.Text = "查询:";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(83, 25);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(245, 30);
            this.txtQuery.TabIndex = 2;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // btnDetailed
            // 
            this.btnDetailed.Location = new System.Drawing.Point(95, 484);
            this.btnDetailed.Name = "btnDetailed";
            this.btnDetailed.Size = new System.Drawing.Size(248, 47);
            this.btnDetailed.TabIndex = 6;
            this.btnDetailed.Text = "详细信息";
            this.btnDetailed.UseVisualStyleBackColor = true;
            this.btnDetailed.Click += new System.EventHandler(this.btnDetailed_Click);
            // 
            // FrmLibraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpLst);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmLibraries";
            this.Text = "开源库简要信息列表";
            this.Load += new System.EventHandler(this.FrmLibraries_Load);
            this.grpLst.ResumeLayout(false);
            this.grpLst.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLibrarie;
        private System.Windows.Forms.GroupBox grpLst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStarts;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStarts;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Button btnDetailed;
    }
}