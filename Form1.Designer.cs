namespace movieticketbooking
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
            this.ComboBoxMovies = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSeats = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxMovies
            // 
            this.ComboBoxMovies.FormattingEnabled = true;
            this.ComboBoxMovies.Location = new System.Drawing.Point(83, 170);
            this.ComboBoxMovies.Name = "ComboBoxMovies";
            this.ComboBoxMovies.Size = new System.Drawing.Size(200, 28);
            this.ComboBoxMovies.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Movie Ticket Booking System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Movie: ";
            // 
            // listBoxSeats
            // 
            this.listBoxSeats.FormattingEnabled = true;
            this.listBoxSeats.ItemHeight = 20;
            this.listBoxSeats.Location = new System.Drawing.Point(85, 367);
            this.listBoxSeats.Name = "listBoxSeats";
            this.listBoxSeats.Size = new System.Drawing.Size(120, 84);
            this.listBoxSeats.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Available Seats: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Name: ";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmation.Location = new System.Drawing.Point(175, 548);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(121, 30);
            this.lblConfirmation.TabIndex = 7;
            this.lblConfirmation.Text = "                  ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(83, 265);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(213, 26);
            this.txtCustomerName.TabIndex = 8;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(83, 483);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(120, 40);
            this.btnBook.TabIndex = 9;
            this.btnBook.Text = "Book Ticket";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(266, 483);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(120, 40);
            this.btnPrintInvoice.TabIndex = 10;
            this.btnPrintInvoice.Text = "Print Ticket";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ComboBoxMovies);
            this.Name = "Form1";
            this.Text = "Movie Ticket Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxMovies;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnPrintInvoice;
    }
}

