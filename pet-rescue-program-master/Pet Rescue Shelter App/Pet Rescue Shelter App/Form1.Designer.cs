namespace Pet_Rescue_Shelter_App
{
    partial class Happy_Hounds
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.foundDogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petRescueDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pet_Rescue_Dataset = new Pet_Rescue_Shelter_App.Pet_Rescue_Dataset();
            this.rescueDogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Content_TC = new System.Windows.Forms.TabControl();
            this.TP_Lost_And_Found = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_add_lost = new System.Windows.Forms.GroupBox();
            this.btn_create_lost_rec = new System.Windows.Forms.Button();
            this.tb_age_lost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_breed_lost = new System.Windows.Forms.TextBox();
            this.lbl_breed_lost = new System.Windows.Forms.Label();
            this.tb_name_lost = new System.Windows.Forms.TextBox();
            this.lbl_name_lost = new System.Windows.Forms.Label();
            this.lbl_tag_id = new System.Windows.Forms.Label();
            this.tb_tag_id_lost = new System.Windows.Forms.TextBox();
            this.btn_read_lost = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TP_Rescue_Dogs = new System.Windows.Forms.TabPage();
            this.TP_Customers = new System.Windows.Forms.TabPage();
            this.foundDogsTableAdapter = new Pet_Rescue_Shelter_App.Pet_Rescue_DatasetTableAdapters.FoundDogsTableAdapter();
            this.rescueDogsTableAdapter = new Pet_Rescue_Shelter_App.Pet_Rescue_DatasetTableAdapters.RescueDogsTableAdapter();
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifiersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foundDogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petRescueDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_Rescue_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rescueDogsBindingSource)).BeginInit();
            this.Content_TC.SuspendLayout();
            this.TP_Lost_And_Found.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_add_lost.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.BackColor = System.Drawing.Color.DimGray;
            this.welcome_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.PaleGreen;
            this.welcome_label.Location = new System.Drawing.Point(0, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(1381, 226);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to the Happy Hounds Rescue Shelter Application";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foundDogsBindingSource
            // 
            this.foundDogsBindingSource.DataMember = "FoundDogs";
            this.foundDogsBindingSource.DataSource = this.petRescueDatasetBindingSource;
            // 
            // petRescueDatasetBindingSource
            // 
            this.petRescueDatasetBindingSource.DataSource = this.pet_Rescue_Dataset;
            this.petRescueDatasetBindingSource.Position = 0;
            // 
            // pet_Rescue_Dataset
            // 
            this.pet_Rescue_Dataset.DataSetName = "Pet_Rescue_Dataset";
            this.pet_Rescue_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rescueDogsBindingSource
            // 
            this.rescueDogsBindingSource.DataMember = "RescueDogs";
            this.rescueDogsBindingSource.DataSource = this.petRescueDatasetBindingSource;
            // 
            // Content_TC
            // 
            this.Content_TC.Controls.Add(this.TP_Lost_And_Found);
            this.Content_TC.Controls.Add(this.TP_Rescue_Dogs);
            this.Content_TC.Controls.Add(this.TP_Customers);
            this.Content_TC.Dock = System.Windows.Forms.DockStyle.Right;
            this.Content_TC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Content_TC.Location = new System.Drawing.Point(-1, 226);
            this.Content_TC.Name = "Content_TC";
            this.Content_TC.SelectedIndex = 0;
            this.Content_TC.Size = new System.Drawing.Size(1382, 829);
            this.Content_TC.TabIndex = 11;
            this.Content_TC.TabStop = false;
            // 
            // TP_Lost_And_Found
            // 
            this.TP_Lost_And_Found.BackColor = System.Drawing.Color.PaleGreen;
            this.TP_Lost_And_Found.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TP_Lost_And_Found.Controls.Add(this.dataGridView1);
            this.TP_Lost_And_Found.Controls.Add(this.gb_add_lost);
            this.TP_Lost_And_Found.Controls.Add(this.splitter1);
            this.TP_Lost_And_Found.ForeColor = System.Drawing.Color.DimGray;
            this.TP_Lost_And_Found.Location = new System.Drawing.Point(4, 41);
            this.TP_Lost_And_Found.Name = "TP_Lost_And_Found";
            this.TP_Lost_And_Found.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Lost_And_Found.Size = new System.Drawing.Size(1374, 784);
            this.TP_Lost_And_Found.TabIndex = 0;
            this.TP_Lost_And_Found.Text = "Lost And Found";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.identifiersDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foundDogsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(574, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 270);
            this.dataGridView1.TabIndex = 5;
            // 
            // gb_add_lost
            // 
            this.gb_add_lost.Controls.Add(this.btn_create_lost_rec);
            this.gb_add_lost.Controls.Add(this.tb_age_lost);
            this.gb_add_lost.Controls.Add(this.label1);
            this.gb_add_lost.Controls.Add(this.tb_breed_lost);
            this.gb_add_lost.Controls.Add(this.lbl_breed_lost);
            this.gb_add_lost.Controls.Add(this.tb_name_lost);
            this.gb_add_lost.Controls.Add(this.lbl_name_lost);
            this.gb_add_lost.Controls.Add(this.lbl_tag_id);
            this.gb_add_lost.Controls.Add(this.tb_tag_id_lost);
            this.gb_add_lost.Controls.Add(this.btn_read_lost);
            this.gb_add_lost.Location = new System.Drawing.Point(12, 15);
            this.gb_add_lost.Name = "gb_add_lost";
            this.gb_add_lost.Size = new System.Drawing.Size(555, 292);
            this.gb_add_lost.TabIndex = 4;
            this.gb_add_lost.TabStop = false;
            this.gb_add_lost.Text = "Add Record";
            // 
            // btn_create_lost_rec
            // 
            this.btn_create_lost_rec.Location = new System.Drawing.Point(426, 244);
            this.btn_create_lost_rec.Name = "btn_create_lost_rec";
            this.btn_create_lost_rec.Size = new System.Drawing.Size(119, 42);
            this.btn_create_lost_rec.TabIndex = 5;
            this.btn_create_lost_rec.Text = "Create";
            this.btn_create_lost_rec.UseVisualStyleBackColor = true;
            // 
            // tb_age_lost
            // 
            this.tb_age_lost.Location = new System.Drawing.Point(115, 181);
            this.tb_age_lost.Name = "tb_age_lost";
            this.tb_age_lost.Size = new System.Drawing.Size(305, 39);
            this.tb_age_lost.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Age:";
            // 
            // tb_breed_lost
            // 
            this.tb_breed_lost.Location = new System.Drawing.Point(115, 131);
            this.tb_breed_lost.Name = "tb_breed_lost";
            this.tb_breed_lost.Size = new System.Drawing.Size(305, 39);
            this.tb_breed_lost.TabIndex = 6;
            // 
            // lbl_breed_lost
            // 
            this.lbl_breed_lost.AutoSize = true;
            this.lbl_breed_lost.Location = new System.Drawing.Point(6, 135);
            this.lbl_breed_lost.Name = "lbl_breed_lost";
            this.lbl_breed_lost.Size = new System.Drawing.Size(97, 32);
            this.lbl_breed_lost.TabIndex = 5;
            this.lbl_breed_lost.Text = "Breed:";
            // 
            // tb_name_lost
            // 
            this.tb_name_lost.Location = new System.Drawing.Point(115, 82);
            this.tb_name_lost.Name = "tb_name_lost";
            this.tb_name_lost.Size = new System.Drawing.Size(305, 39);
            this.tb_name_lost.TabIndex = 4;
            // 
            // lbl_name_lost
            // 
            this.lbl_name_lost.AutoSize = true;
            this.lbl_name_lost.Location = new System.Drawing.Point(6, 83);
            this.lbl_name_lost.Name = "lbl_name_lost";
            this.lbl_name_lost.Size = new System.Drawing.Size(97, 32);
            this.lbl_name_lost.TabIndex = 3;
            this.lbl_name_lost.Text = "Name:";
            // 
            // lbl_tag_id
            // 
            this.lbl_tag_id.AutoSize = true;
            this.lbl_tag_id.Location = new System.Drawing.Point(6, 35);
            this.lbl_tag_id.Name = "lbl_tag_id";
            this.lbl_tag_id.Size = new System.Drawing.Size(103, 32);
            this.lbl_tag_id.TabIndex = 0;
            this.lbl_tag_id.Text = "Tag ID:";
            // 
            // tb_tag_id_lost
            // 
            this.tb_tag_id_lost.Location = new System.Drawing.Point(115, 32);
            this.tb_tag_id_lost.Name = "tb_tag_id_lost";
            this.tb_tag_id_lost.Size = new System.Drawing.Size(305, 39);
            this.tb_tag_id_lost.TabIndex = 1;
            // 
            // btn_read_lost
            // 
            this.btn_read_lost.Location = new System.Drawing.Point(426, 32);
            this.btn_read_lost.Name = "btn_read_lost";
            this.btn_read_lost.Size = new System.Drawing.Size(119, 39);
            this.btn_read_lost.TabIndex = 2;
            this.btn_read_lost.Text = "Read";
            this.btn_read_lost.UseVisualStyleBackColor = true;
            this.btn_read_lost.Click += new System.EventHandler(this.btn_read_lost_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 778);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // TP_Rescue_Dogs
            // 
            this.TP_Rescue_Dogs.BackColor = System.Drawing.Color.PaleGreen;
            this.TP_Rescue_Dogs.Location = new System.Drawing.Point(4, 41);
            this.TP_Rescue_Dogs.Name = "TP_Rescue_Dogs";
            this.TP_Rescue_Dogs.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Rescue_Dogs.Size = new System.Drawing.Size(1374, 784);
            this.TP_Rescue_Dogs.TabIndex = 1;
            this.TP_Rescue_Dogs.Text = "Rescue Dogs";
            // 
            // TP_Customers
            // 
            this.TP_Customers.BackColor = System.Drawing.Color.PaleGreen;
            this.TP_Customers.Location = new System.Drawing.Point(4, 41);
            this.TP_Customers.Name = "TP_Customers";
            this.TP_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Customers.Size = new System.Drawing.Size(1374, 784);
            this.TP_Customers.TabIndex = 2;
            this.TP_Customers.Text = "Customers";
            // 
            // foundDogsTableAdapter
            // 
            this.foundDogsTableAdapter.ClearBeforeFill = true;
            // 
            // rescueDogsTableAdapter
            // 
            this.rescueDogsTableAdapter.ClearBeforeFill = true;
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "Tag_ID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "Tag_ID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            // 
            // identifiersDataGridViewTextBoxColumn
            // 
            this.identifiersDataGridViewTextBoxColumn.DataPropertyName = "Identifiers";
            this.identifiersDataGridViewTextBoxColumn.HeaderText = "Identifiers";
            this.identifiersDataGridViewTextBoxColumn.Name = "identifiersDataGridViewTextBoxColumn";
            this.identifiersDataGridViewTextBoxColumn.Width = 250;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // Happy_Hounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1381, 1055);
            this.Controls.Add(this.Content_TC);
            this.Controls.Add(this.welcome_label);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Happy_Hounds";
            this.Text = "Happy Hounds App";
            ((System.ComponentModel.ISupportInitialize)(this.foundDogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petRescueDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_Rescue_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rescueDogsBindingSource)).EndInit();
            this.Content_TC.ResumeLayout(false);
            this.TP_Lost_And_Found.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_add_lost.ResumeLayout(false);
            this.gb_add_lost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.BindingSource petRescueDatasetBindingSource;
        private Pet_Rescue_Dataset pet_Rescue_Dataset;
        private System.Windows.Forms.BindingSource foundDogsBindingSource;
        private Pet_Rescue_DatasetTableAdapters.FoundDogsTableAdapter foundDogsTableAdapter;
        private System.Windows.Forms.BindingSource rescueDogsBindingSource;
        private Pet_Rescue_DatasetTableAdapters.RescueDogsTableAdapter rescueDogsTableAdapter;
        private System.Windows.Forms.TabControl Content_TC;
        private System.Windows.Forms.TabPage TP_Lost_And_Found;
        private System.Windows.Forms.TabPage TP_Rescue_Dogs;
        private System.Windows.Forms.TabPage TP_Customers;
        private System.Windows.Forms.TextBox tb_tag_id_lost;
        private System.Windows.Forms.Label lbl_tag_id;
        private System.Windows.Forms.Button btn_read_lost;
        private System.Windows.Forms.GroupBox gb_add_lost;
        private System.Windows.Forms.Label lbl_breed_lost;
        private System.Windows.Forms.TextBox tb_name_lost;
        private System.Windows.Forms.Label lbl_name_lost;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_create_lost_rec;
        private System.Windows.Forms.TextBox tb_age_lost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_breed_lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

