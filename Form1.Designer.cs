
namespace Q4_ProgrammingLanguages_QA_InventorySystemUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstInventory = new ListBox();
            txtNewItem = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.Location = new Point(10, 11);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(176, 259);
            lstInventory.TabIndex = 0;
            lstInventory.SelectedIndexChanged += lstInventory_SelectedIndexChanged;
            // 
            // txtNewItem
            // 
            txtNewItem.Location = new Point(201, 11);
            txtNewItem.Name = "txtNewItem";
            txtNewItem.Size = new Size(132, 23);
            txtNewItem.TabIndex = 1;
            txtNewItem.TextChanged += txtNewItem_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(201, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(201, 84);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 28);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 281);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtNewItem);
            Controls.Add(lstInventory);
            Name = "Form1";
            Text = "Inventory System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
