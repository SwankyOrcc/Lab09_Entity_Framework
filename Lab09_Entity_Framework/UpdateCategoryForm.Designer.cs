
namespace Lab09_Entity_Framework
{
	partial class UpdateCategoryForm
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
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.cbbCategoryType = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhóm thức ăn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Loại";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(135, 30);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.ReadOnly = true;
			this.txtCategoryId.Size = new System.Drawing.Size(96, 20);
			this.txtCategoryId.TabIndex = 2;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(135, 72);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(247, 20);
			this.txtCategoryName.TabIndex = 2;
			// 
			// cbbCategoryType
			// 
			this.cbbCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbCategoryType.FormattingEnabled = true;
			this.cbbCategoryType.Items.AddRange(new object[] {
            "Đồ uống",
            "Thức ăn"});
			this.cbbCategoryType.Location = new System.Drawing.Point(135, 112);
			this.cbbCategoryType.Name = "cbbCategoryType";
			this.cbbCategoryType.Size = new System.Drawing.Size(247, 21);
			this.cbbCategoryType.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(226, 153);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "&Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(307, 153);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Thoát";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// UpdateCategoryForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(399, 188);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cbbCategoryType);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdateCategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm/ Cập nhật nhóm món ăn";
			this.Load += new System.EventHandler(this.UpdateCategoryForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.ComboBox cbbCategoryType;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}