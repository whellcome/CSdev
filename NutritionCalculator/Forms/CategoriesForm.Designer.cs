
namespace NutritionCalculator.Forms
{
    partial class CategoriesForm
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
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.categoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesControllerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesControllerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.categoriesControllerBindingSource;
            // 
            // categoriesControllerBindingSource
            // 
            this.categoriesControllerBindingSource.DataSource = typeof(NutritionCalculator.Controllers.CategoriesController);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSave.Location = new System.Drawing.Point(12, 481);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(313, 38);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.categoriesControllerBindingSource;
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(12, 59);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(312, 386);
            this.dgvCategories.TabIndex = 2;
            this.dgvCategories.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellValueChanged);
            // 
            // categoriesBindingSource2
            // 
            this.categoriesBindingSource2.DataMember = "Categories";
            this.categoriesBindingSource2.DataSource = this.categoriesControllerBindingSource;
            // 
            // categoriesControllerBindingSource1
            // 
            this.categoriesControllerBindingSource1.DataSource = typeof(NutritionCalculator.Controllers.CategoriesController);
            // 
            // categoriesControllerBindingSource2
            // 
            this.categoriesControllerBindingSource2.DataSource = typeof(NutritionCalculator.Controllers.CategoriesController);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 524);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesControllerBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource categoriesControllerBindingSource;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.BindingSource categoriesBindingSource2;
        private System.Windows.Forms.BindingSource categoriesControllerBindingSource1;
        private System.Windows.Forms.BindingSource categoriesControllerBindingSource2;
    }
}