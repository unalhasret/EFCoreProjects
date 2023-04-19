namespace Books
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.btnAuthorUpdate = new System.Windows.Forms.Button();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(68, 32);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(101, 20);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(68, 71);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(309, 27);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(665, 71);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(345, 27);
            this.txtBook.TabIndex = 3;
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.Location = new System.Drawing.Point(226, 131);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAuthorAdd.TabIndex = 4;
            this.btnAuthorAdd.Text = "ADD";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // btnAuthorUpdate
            // 
            this.btnAuthorUpdate.Location = new System.Drawing.Point(68, 131);
            this.btnAuthorUpdate.Name = "btnAuthorUpdate";
            this.btnAuthorUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnAuthorUpdate.TabIndex = 5;
            this.btnAuthorUpdate.Text = "UPDATE";
            this.btnAuthorUpdate.UseVisualStyleBackColor = true;
            this.btnAuthorUpdate.Click += new System.EventHandler(this.btnAuthorUpdate_Click);
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.Location = new System.Drawing.Point(469, 422);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(94, 29);
            this.btnAuthorDelete.TabIndex = 6;
            this.btnAuthorDelete.Text = "DELETE";
            this.btnAuthorDelete.UseVisualStyleBackColor = true;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(813, 131);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(94, 29);
            this.btnBookAdd.TabIndex = 7;
            this.btnBookAdd.Text = "ADD";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(665, 131);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnBookUpdate.TabIndex = 8;
            this.btnBookUpdate.Text = "UPDATE";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(1044, 422);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(94, 29);
            this.btnBookDelete.TabIndex = 9;
            this.btnBookDelete.Text = "DELETE";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Location = new System.Drawing.Point(68, 201);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.RowHeadersWidth = 51;
            this.dgvAuthor.RowTemplate.Height = 29;
            this.dgvAuthor.Size = new System.Drawing.Size(495, 188);
            this.dgvAuthor.TabIndex = 10;
            this.dgvAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellClick);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(665, 201);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 29;
            this.dgvBook.Size = new System.Drawing.Size(473, 188);
            this.dgvBook.TabIndex = 11;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 509);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.dgvAuthor);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.btnBookUpdate);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.btnAuthorDelete);
            this.Controls.Add(this.btnAuthorUpdate);
            this.Controls.Add(this.btnAuthorAdd);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAuthor;
        private Label label2;
        private TextBox txtAuthor;
        private TextBox txtBook;
        private Button btnAuthorAdd;
        private Button btnAuthorUpdate;
        private Button btnAuthorDelete;
        private Button btnBookAdd;
        private Button btnBookUpdate;
        private Button btnBookDelete;
        private DataGridView dgvAuthor;
        private DataGridView dgvBook;
    }
}