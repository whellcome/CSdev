
namespace NutritionCalculator.Forms
{
    partial class FoodsForm
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
            this.lvFoods = new System.Windows.Forms.ListView();
            this.food = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFoods
            // 
            this.lvFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.food,
            this.edit});
            this.lvFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFoods.FullRowSelect = true;
            this.lvFoods.GridLines = true;
            this.lvFoods.HideSelection = false;
            this.lvFoods.Location = new System.Drawing.Point(0, 0);
            this.lvFoods.Name = "lvFoods";
            this.lvFoods.Size = new System.Drawing.Size(402, 585);
            this.lvFoods.TabIndex = 0;
            this.lvFoods.UseCompatibleStateImageBehavior = false;
            this.lvFoods.View = System.Windows.Forms.View.Details;
            // 
            // food
            // 
            this.food.DisplayIndex = 0;
            this.food.Text = "Food";
            this.food.Width = 280;
            // 
            // category
            // 
            this.category.Text = "Category";
            // 
            // edit
            // 
            this.edit.Text = "...";
            this.edit.Width = 20;
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 585);
            this.Controls.Add(this.lvFoods);
            this.Name = "FoodsForm";
            this.Text = "FoodsForm";
            this.Load += new System.EventHandler(this.FoodsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFoods;
        private System.Windows.Forms.ColumnHeader food;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader edit;
    }
}