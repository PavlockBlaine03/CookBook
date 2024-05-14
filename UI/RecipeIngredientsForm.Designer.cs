namespace CookBook.UI
{
    partial class RecipeIngredientsForm
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
            label1 = new Label();
            label2 = new Label();
            AllIngredientsLbx = new ListBox();
            RecipeIngredientsLbx = new ListBox();
            AddIngredientBtn = new Button();
            RemoveIngredientBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 48);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "All Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 48);
            label2.Name = "label2";
            label2.Size = new Size(184, 30);
            label2.TabIndex = 1;
            label2.Text = "Recipe Ingredients";
            // 
            // AllIngredientsLbx
            // 
            AllIngredientsLbx.FormattingEnabled = true;
            AllIngredientsLbx.ItemHeight = 30;
            AllIngredientsLbx.Location = new Point(46, 131);
            AllIngredientsLbx.Name = "AllIngredientsLbx";
            AllIngredientsLbx.Size = new Size(250, 274);
            AllIngredientsLbx.TabIndex = 2;
            // 
            // RecipeIngredientsLbx
            // 
            RecipeIngredientsLbx.FormattingEnabled = true;
            RecipeIngredientsLbx.ItemHeight = 30;
            RecipeIngredientsLbx.Location = new Point(366, 131);
            RecipeIngredientsLbx.Name = "RecipeIngredientsLbx";
            RecipeIngredientsLbx.Size = new Size(250, 274);
            RecipeIngredientsLbx.TabIndex = 3;
            // 
            // AddIngredientBtn
            // 
            AddIngredientBtn.Location = new Point(46, 444);
            AddIngredientBtn.Name = "AddIngredientBtn";
            AddIngredientBtn.Size = new Size(250, 50);
            AddIngredientBtn.TabIndex = 4;
            AddIngredientBtn.Text = "Add Ingredient";
            AddIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveIngredientBtn
            // 
            RemoveIngredientBtn.Location = new Point(366, 444);
            RemoveIngredientBtn.Name = "RemoveIngredientBtn";
            RemoveIngredientBtn.Size = new Size(250, 50);
            RemoveIngredientBtn.TabIndex = 5;
            RemoveIngredientBtn.Text = "Remove Ingredient";
            RemoveIngredientBtn.UseVisualStyleBackColor = true;
            // 
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 531);
            Controls.Add(RemoveIngredientBtn);
            Controls.Add(AddIngredientBtn);
            Controls.Add(RecipeIngredientsLbx);
            Controls.Add(AllIngredientsLbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeIngredientsForm";
            Text = "RecipeIngredientsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox AllIngredientsLbx;
        private ListBox RecipeIngredientsLbx;
        private Button AddIngredientBtn;
        private Button RemoveIngredientBtn;
    }
}