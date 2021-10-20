namespace Part_7___Lists_in_Windows_Forms
{
    partial class frmUsingLists
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
            this.IstNumbers = new System.Windows.Forms.ListBox();
            this.IstHeroes = new System.Windows.Forms.ListBox();
            this.btnNewList1 = new System.Windows.Forms.Button();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.btnNewList2 = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumber = new System.Windows.Forms.Button();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IstNumbers
            // 
            this.IstNumbers.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstNumbers.FormattingEnabled = true;
            this.IstNumbers.ItemHeight = 23;
            this.IstNumbers.Location = new System.Drawing.Point(13, 65);
            this.IstNumbers.Name = "IstNumbers";
            this.IstNumbers.Size = new System.Drawing.Size(186, 142);
            this.IstNumbers.TabIndex = 0;
            // 
            // IstHeroes
            // 
            this.IstHeroes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstHeroes.FormattingEnabled = true;
            this.IstHeroes.ItemHeight = 23;
            this.IstHeroes.Location = new System.Drawing.Point(242, 65);
            this.IstHeroes.Name = "IstHeroes";
            this.IstHeroes.Size = new System.Drawing.Size(186, 142);
            this.IstHeroes.TabIndex = 1;
            // 
            // btnNewList1
            // 
            this.btnNewList1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewList1.Location = new System.Drawing.Point(11, 36);
            this.btnNewList1.Name = "btnNewList1";
            this.btnNewList1.Size = new System.Drawing.Size(87, 29);
            this.btnNewList1.TabIndex = 2;
            this.btnNewList1.Text = "New List";
            this.btnNewList1.UseVisualStyleBackColor = true;
            this.btnNewList1.Click += new System.EventHandler(this.btnNewList1_Click);
            // 
            // btnSort1
            // 
            this.btnSort1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort1.Location = new System.Drawing.Point(112, 36);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(87, 29);
            this.btnSort1.TabIndex = 3;
            this.btnSort1.Text = "Sort";
            this.btnSort1.UseVisualStyleBackColor = true;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // btnSort2
            // 
            this.btnSort2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort2.Location = new System.Drawing.Point(341, 36);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(87, 29);
            this.btnSort2.TabIndex = 5;
            this.btnSort2.Text = "Sort";
            this.btnSort2.UseVisualStyleBackColor = true;
            this.btnSort2.Click += new System.EventHandler(this.btnSort2_Click);
            // 
            // btnNewList2
            // 
            this.btnNewList2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewList2.Location = new System.Drawing.Point(240, 36);
            this.btnNewList2.Name = "btnNewList2";
            this.btnNewList2.Size = new System.Drawing.Size(87, 29);
            this.btnNewList2.TabIndex = 4;
            this.btnNewList2.Text = "New List";
            this.btnNewList2.UseVisualStyleBackColor = true;
            this.btnNewList2.Click += new System.EventHandler(this.btnNewList2_Click);
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(12, 13);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(82, 23);
            this.lblNumbers.TabIndex = 6;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(241, 13);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(64, 23);
            this.lblHeroes.TabIndex = 7;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(8, 216);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(219, 23);
            this.lblInstruction.TabIndex = 8;
            this.lblInstruction.Text = "Select a Number to Remove";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(239, 216);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(215, 23);
            this.lblInstruction2.TabIndex = 9;
            this.lblInstruction2.Text = "Enter a Hero Name to Add:";
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNumber.Location = new System.Drawing.Point(66, 242);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(92, 30);
            this.btnRemoveNumber.TabIndex = 10;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumber
            // 
            this.btnRemoveAllNumber.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllNumber.Location = new System.Drawing.Point(36, 277);
            this.btnRemoveAllNumber.Name = "btnRemoveAllNumber";
            this.btnRemoveAllNumber.Size = new System.Drawing.Size(153, 30);
            this.btnRemoveAllNumber.TabIndex = 11;
            this.btnRemoveAllNumber.Text = "Remove All";
            this.btnRemoveAllNumber.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumber.Click += new System.EventHandler(this.btnRemoveAllNumber_Click);
            // 
            // txtAddHero
            // 
            this.txtAddHero.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddHero.Location = new System.Drawing.Point(242, 240);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(112, 30);
            this.txtAddHero.TabIndex = 12;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.Location = new System.Drawing.Point(360, 241);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(80, 29);
            this.btnAddHero.TabIndex = 13;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction3.Location = new System.Drawing.Point(238, 273);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(243, 23);
            this.lblInstruction3.TabIndex = 14;
            this.lblInstruction3.Text = "Enter a Hero Name to Remove:";
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveHero.Location = new System.Drawing.Point(242, 299);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(99, 30);
            this.txtRemoveHero.TabIndex = 15;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHero.Location = new System.Drawing.Point(355, 300);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(95, 29);
            this.btnRemoveHero.TabIndex = 16;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 332);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 23);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // frmUsingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(486, 364);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.lblInstruction3);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.btnRemoveAllNumber);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnNewList2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.btnNewList1);
            this.Controls.Add(this.IstHeroes);
            this.Controls.Add(this.IstNumbers);
            this.Name = "frmUsingLists";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.frmUsingLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IstNumbers;
        private System.Windows.Forms.ListBox IstHeroes;
        private System.Windows.Forms.Button btnNewList1;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.Button btnNewList2;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumber;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Label lblStatus;
    }
}

