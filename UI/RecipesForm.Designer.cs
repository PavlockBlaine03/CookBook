namespace CookBook.UI
{
    partial class RecipesForm
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
            RecipesGrid = new DataGridView();
            RecipeFilterCbx = new ComboBox();
            NameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RecipeTypeCbx = new ComboBox();
            AddRecipeTypeBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            AddRecipeBtn = new Button();
            ClearAllFieldsBtn = new Button();
            RecipeIngredientBtn = new Button();
            EditRecipeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            SuspendLayout();
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(12, 75);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.Size = new Size(935, 561);
            RecipesGrid.TabIndex = 0;
            RecipesGrid.CellContentClick += RecipesGrid_CellContentClick;
            // 
            // RecipeFilterCbx
            // 
            RecipeFilterCbx.FormattingEnabled = true;
            RecipeFilterCbx.Location = new Point(12, 21);
            RecipeFilterCbx.Name = "RecipeFilterCbx";
            RecipeFilterCbx.Size = new Size(935, 38);
            RecipeFilterCbx.TabIndex = 1;
            RecipeFilterCbx.SelectedIndexChanged += RecipeFilterCbx_SelectedIndexChanged;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1119, 20);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(273, 36);
            NameTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(964, 26);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(964, 105);
            label2.Name = "label2";
            label2.Size = new Size(65, 30);
            label2.TabIndex = 4;
            label2.Text = "Type:";
            // 
            // RecipeTypeCbx
            // 
            RecipeTypeCbx.FormattingEnabled = true;
            RecipeTypeCbx.Location = new Point(1119, 97);
            RecipeTypeCbx.Name = "RecipeTypeCbx";
            RecipeTypeCbx.Size = new Size(150, 38);
            RecipeTypeCbx.TabIndex = 5;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(1291, 97);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(101, 38);
            AddRecipeTypeBtn.TabIndex = 6;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(964, 200);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 7;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(964, 346);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 8;
            label4.Text = "Image:";
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(1119, 161);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(273, 96);
            DescriptionTxt.TabIndex = 9;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(1119, 283);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(273, 174);
            RecipePictureBox.TabIndex = 10;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(991, 481);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(401, 47);
            AddRecipeBtn.TabIndex = 11;
            AddRecipeBtn.Text = "Add Recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(991, 587);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(401, 47);
            ClearAllFieldsBtn.TabIndex = 12;
            ClearAllFieldsBtn.Text = "Clear All Fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // RecipeIngredientBtn
            // 
            RecipeIngredientBtn.Location = new Point(991, 534);
            RecipeIngredientBtn.Name = "RecipeIngredientBtn";
            RecipeIngredientBtn.Size = new Size(401, 47);
            RecipeIngredientBtn.TabIndex = 13;
            RecipeIngredientBtn.Text = "Recipe Ingredients";
            RecipeIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // EditRecipeBtn
            // 
            EditRecipeBtn.Location = new Point(991, 481);
            EditRecipeBtn.Name = "EditRecipeBtn";
            EditRecipeBtn.Size = new Size(401, 47);
            EditRecipeBtn.TabIndex = 14;
            EditRecipeBtn.Text = "Edit Recipe";
            EditRecipeBtn.UseVisualStyleBackColor = true;
            EditRecipeBtn.Click += EditRecipeBtn_Click;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1429, 648);
            Controls.Add(EditRecipeBtn);
            Controls.Add(RecipeIngredientBtn);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypeCbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NameTxt);
            Controls.Add(RecipeFilterCbx);
            Controls.Add(RecipesGrid);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipesForm";
            Text = "Recipes";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RecipesGrid;
        private ComboBox RecipeFilterCbx;
        private TextBox NameTxt;
        private Label label1;
        private Label label2;
        private ComboBox RecipeTypeCbx;
        private Button AddRecipeTypeBtn;
        private Label label3;
        private Label label4;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private Button AddRecipeBtn;
        private Button ClearAllFieldsBtn;
        private Button RecipeIngredientBtn;
        private Button EditRecipeBtn;
    }
}