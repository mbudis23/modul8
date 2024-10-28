namespace Modul8
{
    partial class Form1
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
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_dataUsers = new System.Windows.Forms.Label();
            this.lbl_noHandphone = new System.Windows.Forms.Label();
            this.txtNo_handphone = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLoaddata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(43, 74);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(55, 20);
            this.lbl_nama.TabIndex = 0;
            this.lbl_nama.Text = "Nama";
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamat.Location = new System.Drawing.Point(44, 106);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(59, 18);
            this.lbl_alamat.TabIndex = 1;
            this.lbl_alamat.Text = "Alamat";
            // 
            // lbl_dataUsers
            // 
            this.lbl_dataUsers.AutoSize = true;
            this.lbl_dataUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataUsers.Location = new System.Drawing.Point(326, 29);
            this.lbl_dataUsers.Name = "lbl_dataUsers";
            this.lbl_dataUsers.Size = new System.Drawing.Size(161, 31);
            this.lbl_dataUsers.TabIndex = 2;
            this.lbl_dataUsers.Text = "Data Users";
            // 
            // lbl_noHandphone
            // 
            this.lbl_noHandphone.AutoSize = true;
            this.lbl_noHandphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noHandphone.Location = new System.Drawing.Point(44, 135);
            this.lbl_noHandphone.Name = "lbl_noHandphone";
            this.lbl_noHandphone.Size = new System.Drawing.Size(120, 18);
            this.lbl_noHandphone.TabIndex = 3;
            this.lbl_noHandphone.Text = "No Handphone";
            // 
            // txtNo_handphone
            // 
            this.txtNo_handphone.Location = new System.Drawing.Point(170, 133);
            this.txtNo_handphone.Name = "txtNo_handphone";
            this.txtNo_handphone.Size = new System.Drawing.Size(155, 20);
            this.txtNo_handphone.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(170, 104);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(155, 20);
            this.txtAlamat.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(516, 77);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 79);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(597, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 79);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(678, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 79);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(47, 162);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(706, 207);
            this.dgvData.TabIndex = 10;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnLoaddata
            // 
            this.btnLoaddata.Location = new System.Drawing.Point(678, 375);
            this.btnLoaddata.Name = "btnLoaddata";
            this.btnLoaddata.Size = new System.Drawing.Size(75, 23);
            this.btnLoaddata.TabIndex = 11;
            this.btnLoaddata.Text = "Load Data";
            this.btnLoaddata.UseVisualStyleBackColor = true;
            this.btnLoaddata.Click += new System.EventHandler(this.btnLoaddata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoaddata);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNo_handphone);
            this.Controls.Add(this.lbl_noHandphone);
            this.Controls.Add(this.lbl_dataUsers);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.lbl_nama);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.Label lbl_dataUsers;
        private System.Windows.Forms.Label lbl_noHandphone;
        private System.Windows.Forms.TextBox txtNo_handphone;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLoaddata;
    }
}

