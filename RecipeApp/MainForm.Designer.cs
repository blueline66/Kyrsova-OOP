namespace RecipeApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.numPortions = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lstShoppingList = new System.Windows.Forms.ListBox();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lblPortions = new System.Windows.Forms.Label();
            this.lblShoppingList = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPortions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(225, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Шукати";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 15;
            this.lstRecipes.Location = new System.Drawing.Point(15, 90);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRecipes.Size = new System.Drawing.Size(295, 184);
            this.lstRecipes.TabIndex = 2;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(15, 280);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(95, 25);
            this.btnAddRecipe.TabIndex = 12;
            this.btnAddRecipe.Text = "Створити";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Location = new System.Drawing.Point(115, 280);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(95, 25);
            this.btnEditRecipe.TabIndex = 13;
            this.btnEditRecipe.Text = "Редагувати";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(215, 280);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(95, 25);
            this.btnDeleteRecipe.TabIndex = 14;
            this.btnDeleteRecipe.Text = "Видалити";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // numPortions
            // 
            this.numPortions.Location = new System.Drawing.Point(180, 320);
            this.numPortions.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPortions.Name = "numPortions";
            this.numPortions.Size = new System.Drawing.Size(130, 23);
            this.numPortions.TabIndex = 3;
            this.numPortions.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 355);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(295, 35);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Сформувати список покупок ->";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lstShoppingList
            // 
            this.lstShoppingList.FormattingEnabled = true;
            this.lstShoppingList.ItemHeight = 15;
            this.lstShoppingList.Location = new System.Drawing.Point(340, 35);
            this.lstShoppingList.Name = "lstShoppingList";
            this.lstShoppingList.Size = new System.Drawing.Size(300, 304);
            this.lstShoppingList.TabIndex = 5;
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(340, 355);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(140, 35);
            this.btnExportTxt.TabIndex = 6;
            this.btnExportTxt.Text = "Експорт у TXT";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(500, 355);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(140, 35);
            this.btnExportCsv.TabIndex = 7;
            this.btnExportCsv.Text = "Експорт у CSV";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(176, 15);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Пошук (за назвою/складовим):";
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(15, 70);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(110, 15);
            this.lblRecipes.TabIndex = 9;
            this.lblRecipes.Text = "Знайдені рецепти:";
            // 
            // lblPortions
            // 
            this.lblPortions.AutoSize = true;
            this.lblPortions.Location = new System.Drawing.Point(15, 322);
            this.lblPortions.Name = "lblPortions";
            this.lblPortions.Size = new System.Drawing.Size(155, 15);
            this.lblPortions.TabIndex = 10;
            this.lblPortions.Text = "Бажана кількість порцій:";
            // 
            // lblShoppingList
            // 
            this.lblShoppingList.AutoSize = true;
            this.lblShoppingList.Location = new System.Drawing.Point(340, 15);
            this.lblShoppingList.Name = "lblShoppingList";
            this.lblShoppingList.Size = new System.Drawing.Size(126, 15);
            this.lblShoppingList.TabIndex = 11;
            this.lblShoppingList.Text = "Ваш список покупок:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 410);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lblShoppingList);
            this.Controls.Add(this.lblPortions);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.lstShoppingList);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numPortions);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "MainForm";
            this.Text = "Облік рецептів та Список покупок";
            ((System.ComponentModel.ISupportInitialize)(this.numPortions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.NumericUpDown numPortions;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstShoppingList;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.Label lblPortions;
        private System.Windows.Forms.Label lblShoppingList;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
    }
}