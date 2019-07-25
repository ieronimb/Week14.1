namespace UserForm
{
    partial class frmMain
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
            System.Windows.Forms.Label label_id;
            System.Windows.Forms.Label username;
            System.Windows.Forms.Label email;
            System.Windows.Forms.Label description;
            System.Windows.Forms.Label city;
            System.Windows.Forms.Label street;
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            label_id = new System.Windows.Forms.Label();
            username = new System.Windows.Forms.Label();
            email = new System.Windows.Forms.Label();
            description = new System.Windows.Forms.Label();
            city = new System.Windows.Forms.Label();
            street = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new System.Drawing.Point(12, 9);
            label_id.Name = "label_id";
            label_id.Size = new System.Drawing.Size(41, 13);
            label_id.TabIndex = 0;
            label_id.Text = "User Id";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(91, 2);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(262, 20);
            this.textBoxUserId.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new System.Drawing.Point(12, 38);
            username.Name = "username";
            username.Size = new System.Drawing.Size(60, 13);
            username.TabIndex = 2;
            username.Text = "User Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(91, 31);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(262, 20);
            this.textBoxUserName.TabIndex = 3;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new System.Drawing.Point(12, 65);
            email.Name = "email";
            email.Size = new System.Drawing.Size(32, 13);
            email.TabIndex = 4;
            email.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(91, 58);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(262, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(473, 6);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(262, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new System.Drawing.Point(394, 13);
            description.Name = "description";
            description.Size = new System.Drawing.Size(60, 13);
            description.TabIndex = 6;
            description.Text = "Description";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(473, 32);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(262, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new System.Drawing.Point(394, 39);
            city.Name = "city";
            city.Size = new System.Drawing.Size(24, 13);
            city.TabIndex = 8;
            city.Text = "City";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(473, 58);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(262, 20);
            this.textBoxStreet.TabIndex = 11;
            // 
            // street
            // 
            street.AutoSize = true;
            street.Location = new System.Drawing.Point(394, 65);
            street.Name = "street";
            street.Size = new System.Drawing.Size(35, 13);
            street.TabIndex = 10;
            street.Text = "Street";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 166);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(91, 109);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(278, 109);
            this.btn_Update.Name = "btn_Update";
            //this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(457, 109);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(744, 358);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(street);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(city);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(description);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(email);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(username);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(label_id);
            this.Name = "frmMain";
            this.Text = "User DB Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}

