namespace RecipeApp
{
    partial class RecipeEditorForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblPortions = new System.Windows.Forms.Label();
            this.numDefaultPortions = new System.Windows.Forms.NumericUpDown();
            this.groupBoxIngredients = new System.Windows.Forms.GroupBox();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.txtIngUnit = new System.Windows.Forms.TextBox();
            this.lblIngUnit = new System.Windows.Forms.Label();
            this.numIngQty = new System.Windows.Forms.NumericUpDown();
            this.lblIngQty = new System.Windows.Forms.Label();
            this.txtIngName = new System.Windows.Forms.TextBox();
            this.lblIngName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPortions)).BeginInit();
            this.groupBoxIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Location = new System.Drawing.Point(12, 15);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(100, 23);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Назва рецепта:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(118, 12);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(254, 23);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lblPortions
            // 
            this.lblPortions.Location = new System.Drawing.Point(12, 45);
            this.lblPortions.Name = "lblPortions";
            this.lblPortions.Size = new System.Drawing.Size(100, 23);
            this.lblPortions.TabIndex = 2;
            this.lblPortions.Text = "Стандарт. порцій:";
            // 
            // numDefaultPortions
            // 
            this.numDefaultPortions.Location = new System.Drawing.Point(118, 43);
            this.numDefaultPortions.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDefaultPortions.Name = "numDefaultPortions";
            this.numDefaultPortions.Size = new System.Drawing.Size(120, 23);
            this.numDefaultPortions.TabIndex = 3;
            this.numDefaultPortions.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBoxIngredients
            // 
            this.groupBoxIngredients.Controls.Add(this.btnRemoveIngredient);
            this.groupBoxIngredients.Controls.Add(this.lstIngredients);
            this.groupBoxIngredients.Controls.Add(this.btnAddIngredient);
            this.groupBoxIngredients.Controls.Add(this.txtIngUnit);
            this.groupBoxIngredients.Controls.Add(this.lblIngUnit);
            this.groupBoxIngredients.Controls.Add(this.numIngQty);
            this.groupBoxIngredients.Controls.Add(this.lblIngQty);
            this.groupBoxIngredients.Controls.Add(this.txtIngName);
            this.groupBoxIngredients.Controls.Add(this.lblIngName);
            this.groupBoxIngredients.Location = new System.Drawing.Point(12, 80);
            this.groupBoxIngredients.Name = "groupBoxIngredients";
            this.groupBoxIngredients.Size = new System.Drawing.Size(360, 220);
            this.groupBoxIngredients.TabIndex = 4;
            this.groupBoxIngredients.TabStop = false;
            this.groupBoxIngredients.Text = "Інгредієнти";
            // 
            // lblIngName
            // 
            this.lblIngName.Location = new System.Drawing.Point(6, 25);
            this.lblIngName.Name = "lblIngName";
            this.lblIngName.Size = new System.Drawing.Size(100, 15);
            this.lblIngName.TabIndex = 0;
            this.lblIngName.Text = "Назва (напр. Сіль)";
            // 
            // txtIngName
            // 
            this.txtIngName.Location = new System.Drawing.Point(6, 43);
            this.txtIngName.Name = "txtIngName";
            this.txtIngName.Size = new System.Drawing.Size(110, 23);
            this.txtIngName.TabIndex = 1;
            // 
            // lblIngQty
            // 
            this.lblIngQty.Location = new System.Drawing.Point(122, 25);
            this.lblIngQty.Name = "lblIngQty";
            this.lblIngQty.Size = new System.Drawing.Size(70, 15);
            this.lblIngQty.TabIndex = 2;
            this.lblIngQty.Text = "Кількість";
            // 
            // numIngQty
            // 
            this.numIngQty.DecimalPlaces = 2;
            this.numIngQty.Location = new System.Drawing.Point(122, 43);
            this.numIngQty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numIngQty.Name = "numIngQty";
            this.numIngQty.Size = new System.Drawing.Size(70, 23);
            this.numIngQty.TabIndex = 3;
            // 
            // lblIngUnit
            // 
            this.lblIngUnit.Location = new System.Drawing.Point(198, 25);
            this.lblIngUnit.Name = "lblIngUnit";
            this.lblIngUnit.Size = new System.Drawing.Size(70, 15);
            this.lblIngUnit.TabIndex = 4;
            this.lblIngUnit.Text = "Од. виміру";
            // 
            // txtIngUnit
            // 
            this.txtIngUnit.Location = new System.Drawing.Point(198, 43);
            this.txtIngUnit.Name = "txtIngUnit";
            this.txtIngUnit.Size = new System.Drawing.Size(70, 23);
            this.txtIngUnit.TabIndex = 5;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(274, 42);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(80, 25);
            this.btnAddIngredient.TabIndex = 6;
            this.btnAddIngredient.Text = "Додати";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 15;
            this.lstIngredients.Location = new System.Drawing.Point(6, 75);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(262, 139);
            this.lstIngredients.TabIndex = 7;
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.Location = new System.Drawing.Point(274, 75);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(80, 25);
            this.btnRemoveIngredient.TabIndex = 8;
            this.btnRemoveIngredient.Text = "Видалити";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RecipeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxIngredients);
            this.Controls.Add(this.numDefaultPortions);
            this.Controls.Add(this.lblPortions);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.lblRecipeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RecipeEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор рецепту";
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPortions)).EndInit();
            this.groupBoxIngredients.ResumeLayout(false);
            this.groupBoxIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIngQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblPortions;
        private System.Windows.Forms.NumericUpDown numDefaultPortions;
        private System.Windows.Forms.GroupBox groupBoxIngredients;
        private System.Windows.Forms.Button btnRemoveIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.TextBox txtIngUnit;
        private System.Windows.Forms.Label lblIngUnit;
        private System.Windows.Forms.NumericUpDown numIngQty;
        private System.Windows.Forms.Label lblIngQty;
        private System.Windows.Forms.TextBox txtIngName;
        private System.Windows.Forms.Label lblIngName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}