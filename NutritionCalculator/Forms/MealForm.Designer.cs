
namespace NutritionCalculator.Forms
{
    partial class MealForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvMealItems = new System.Windows.Forms.DataGridView();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutrientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealsControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMealItems
            // 
            this.dgvMealItems.AutoGenerateColumns = false;
            this.dgvMealItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nutrientDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvMealItems.DataSource = this.mealItemsBindingSource;
            this.dgvMealItems.Location = new System.Drawing.Point(440, 65);
            this.dgvMealItems.Name = "dgvMealItems";
            this.dgvMealItems.Size = new System.Drawing.Size(348, 238);
            this.dgvMealItems.TabIndex = 0;
            this.dgvMealItems.Click += new System.EventHandler(this.dgvMealItems_Click);
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataMember = "Meals";
            this.mealsBindingSource.DataSource = this.mealsControllerBindingSource;
            // 
            // mealItemsBindingSource
            // 
            this.mealItemsBindingSource.DataMember = "MealItems";
            this.mealItemsBindingSource.DataSource = this.mealsBindingSource;
            // 
            // nutrientDataGridViewTextBoxColumn
            // 
            this.nutrientDataGridViewTextBoxColumn.DataPropertyName = "Nutrient";
            this.nutrientDataGridViewTextBoxColumn.HeaderText = "Nutrient";
            this.nutrientDataGridViewTextBoxColumn.Name = "nutrientDataGridViewTextBoxColumn";
            this.nutrientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nutrientDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // mealsControllerBindingSource
            // 
            this.mealsControllerBindingSource.DataSource = typeof(NutritionCalculator.Controllers.MealsController);
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMealItems);
            this.Name = "MealForm";
            this.Text = "MealForm";
            this.Load += new System.EventHandler(this.MealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsControllerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMealItems;
        private System.Windows.Forms.BindingSource mealItemsBindingSource;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private System.Windows.Forms.BindingSource mealsControllerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutrientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}