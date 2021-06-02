
namespace lab4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Choose_Folder = new System.Windows.Forms.Button();
            this.Button_Choose_Open_File = new System.Windows.Forms.Button();
            this.Choose_Open_File = new System.Windows.Forms.TextBox();
            this.Choose_Folder = new System.Windows.Forms.TextBox();
            this.Button_Choose_Save_File = new System.Windows.Forms.Button();
            this.Choose_Save_File = new System.Windows.Forms.TextBox();
            this.U_Label = new System.Windows.Forms.Label();
            this.U_TextBox = new System.Windows.Forms.TextBox();
            this.Term_Amount = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.Term_Amount_Label = new System.Windows.Forms.Label();
            this.X_Label = new System.Windows.Forms.Label();
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Equation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Choose_Folder
            // 
            this.Button_Choose_Folder.Location = new System.Drawing.Point(26, 59);
            this.Button_Choose_Folder.Name = "Button_Choose_Folder";
            this.Button_Choose_Folder.Size = new System.Drawing.Size(179, 29);
            this.Button_Choose_Folder.TabIndex = 2;
            this.Button_Choose_Folder.Text = "Выбор каталога";
            this.Button_Choose_Folder.UseVisualStyleBackColor = true;
            this.Button_Choose_Folder.Click += new System.EventHandler(this.Button_Choose_Folder_Click);
            // 
            // Button_Choose_Open_File
            // 
            this.Button_Choose_Open_File.Location = new System.Drawing.Point(26, 109);
            this.Button_Choose_Open_File.Name = "Button_Choose_Open_File";
            this.Button_Choose_Open_File.Size = new System.Drawing.Size(179, 29);
            this.Button_Choose_Open_File.TabIndex = 3;
            this.Button_Choose_Open_File.Text = "Открыть файл";
            this.Button_Choose_Open_File.UseVisualStyleBackColor = true;
            this.Button_Choose_Open_File.Click += new System.EventHandler(this.Button_Choose_Open_File_Click);
            // 
            // Choose_Open_File
            // 
            this.Choose_Open_File.Location = new System.Drawing.Point(236, 110);
            this.Choose_Open_File.Name = "Choose_Open_File";
            this.Choose_Open_File.Size = new System.Drawing.Size(536, 27);
            this.Choose_Open_File.TabIndex = 4;
            this.Choose_Open_File.Click += new System.EventHandler(this.Button_Choose_Open_File_Click);
            // 
            // Choose_Folder
            // 
            this.Choose_Folder.Location = new System.Drawing.Point(236, 60);
            this.Choose_Folder.Name = "Choose_Folder";
            this.Choose_Folder.Size = new System.Drawing.Size(536, 27);
            this.Choose_Folder.TabIndex = 5;
            this.Choose_Folder.Text = "C:\\";
            this.Choose_Folder.Click += new System.EventHandler(this.Button_Choose_Folder_Click);
            // 
            // Button_Choose_Save_File
            // 
            this.Button_Choose_Save_File.Location = new System.Drawing.Point(26, 160);
            this.Button_Choose_Save_File.Name = "Button_Choose_Save_File";
            this.Button_Choose_Save_File.Size = new System.Drawing.Size(179, 29);
            this.Button_Choose_Save_File.TabIndex = 6;
            this.Button_Choose_Save_File.Text = "Сохранить файл";
            this.Button_Choose_Save_File.UseVisualStyleBackColor = true;
            this.Button_Choose_Save_File.Click += new System.EventHandler(this.Button_Choose_Save_File_Click);
            // 
            // Choose_Save_File
            // 
            this.Choose_Save_File.Location = new System.Drawing.Point(236, 161);
            this.Choose_Save_File.Name = "Choose_Save_File";
            this.Choose_Save_File.Size = new System.Drawing.Size(536, 27);
            this.Choose_Save_File.TabIndex = 7;
            // 
            // U_Label
            // 
            this.U_Label.AutoSize = true;
            this.U_Label.Location = new System.Drawing.Point(531, 388);
            this.U_Label.Name = "U_Label";
            this.U_Label.Size = new System.Drawing.Size(33, 20);
            this.U_Label.TabIndex = 8;
            this.U_Label.Text = "U =";
            // 
            // U_TextBox
            // 
            this.U_TextBox.Enabled = false;
            this.U_TextBox.Location = new System.Drawing.Point(570, 385);
            this.U_TextBox.Name = "U_TextBox";
            this.U_TextBox.Size = new System.Drawing.Size(216, 27);
            this.U_TextBox.TabIndex = 9;
            // 
            // Term_Amount
            // 
            this.Term_Amount.Location = new System.Drawing.Point(312, 326);
            this.Term_Amount.Name = "Term_Amount";
            this.Term_Amount.Size = new System.Drawing.Size(183, 27);
            this.Term_Amount.TabIndex = 10;
            // 
            // X
            // 
            this.X.Enabled = false;
            this.X.Location = new System.Drawing.Point(312, 385);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(183, 27);
            this.X.TabIndex = 11;
            // 
            // Term_Amount_Label
            // 
            this.Term_Amount_Label.AutoSize = true;
            this.Term_Amount_Label.Location = new System.Drawing.Point(28, 329);
            this.Term_Amount_Label.Name = "Term_Amount_Label";
            this.Term_Amount_Label.Size = new System.Drawing.Size(278, 20);
            this.Term_Amount_Label.TabIndex = 12;
            this.Term_Amount_Label.Text = "Количество слагаемых в правой части";
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Location = new System.Drawing.Point(288, 388);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(18, 20);
            this.X_Label.TabIndex = 13;
            this.X_Label.Text = "X";
            // 
            // Button_Calculate
            // 
            this.Button_Calculate.Image = ((System.Drawing.Image)(resources.GetObject("Button_Calculate.Image")));
            this.Button_Calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Calculate.Location = new System.Drawing.Point(570, 258);
            this.Button_Calculate.Name = "Button_Calculate";
            this.Button_Calculate.Size = new System.Drawing.Size(216, 82);
            this.Button_Calculate.TabIndex = 14;
            this.Button_Calculate.Text = "Вычислить";
            this.Button_Calculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Calculate.UseVisualStyleBackColor = true;
            this.Button_Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Файл уравнения";
            // 
            // Equation
            // 
            this.Equation.AutoSize = true;
            this.Equation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equation.Location = new System.Drawing.Point(328, 211);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(134, 31);
            this.Equation.TabIndex = 16;
            this.Equation.Text = " Уравнение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.Equation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Calculate);
            this.Controls.Add(this.X_Label);
            this.Controls.Add(this.Term_Amount_Label);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Term_Amount);
            this.Controls.Add(this.U_TextBox);
            this.Controls.Add(this.U_Label);
            this.Controls.Add(this.Choose_Save_File);
            this.Controls.Add(this.Button_Choose_Save_File);
            this.Controls.Add(this.Choose_Folder);
            this.Controls.Add(this.Choose_Open_File);
            this.Controls.Add(this.Button_Choose_Open_File);
            this.Controls.Add(this.Button_Choose_Folder);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Choose_Folder;
        private System.Windows.Forms.Button Button_Choose_Open_File;
        private System.Windows.Forms.TextBox Choose_Open_File;
        private System.Windows.Forms.TextBox Choose_Folder;
        private System.Windows.Forms.Button Button_Choose_Save_File;
        private System.Windows.Forms.TextBox Choose_Save_File;
        private System.Windows.Forms.Label U_Label;
        private System.Windows.Forms.TextBox U_TextBox;
        private System.Windows.Forms.TextBox Term_Amount;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label Term_Amount_Label;
        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.Button Button_Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Equation;
    }
}

