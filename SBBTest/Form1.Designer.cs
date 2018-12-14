namespace SBBTest
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
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.btnFrom = new System.Windows.Forms.Button();
            this.chblFrom = new System.Windows.Forms.CheckedListBox();
            this.chblTo = new System.Windows.Forms.CheckedListBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chbStart = new System.Windows.Forms.CheckBox();
            this.chbEnd = new System.Windows.Forms.CheckBox();
            this.libConn = new System.Windows.Forms.ListBox();
            this.txtConn = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFromDel = new System.Windows.Forms.Button();
            this.btnToDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFrom
            // 
            this.tbxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxFrom.Location = new System.Drawing.Point(12, 383);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(216, 20);
            this.tbxFrom.TabIndex = 2;
            this.tbxFrom.Text = "Fétigny";
            this.tbxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFrom
            // 
            this.btnFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFrom.Location = new System.Drawing.Point(12, 409);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(105, 23);
            this.btnFrom.TabIndex = 3;
            this.btnFrom.Text = "Affichre";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // chblFrom
            // 
            this.chblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chblFrom.FormattingEnabled = true;
            this.chblFrom.Location = new System.Drawing.Point(12, 12);
            this.chblFrom.Name = "chblFrom";
            this.chblFrom.Size = new System.Drawing.Size(216, 364);
            this.chblFrom.Sorted = true;
            this.chblFrom.TabIndex = 4;
            this.chblFrom.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chblFrom_ItemCheck);
            // 
            // chblTo
            // 
            this.chblTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chblTo.FormattingEnabled = true;
            this.chblTo.Location = new System.Drawing.Point(234, 12);
            this.chblTo.Name = "chblTo";
            this.chblTo.Size = new System.Drawing.Size(216, 364);
            this.chblTo.Sorted = true;
            this.chblTo.TabIndex = 4;
            this.chblTo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chblTo_ItemCheck);
            // 
            // tbxTo
            // 
            this.tbxTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxTo.Location = new System.Drawing.Point(234, 383);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(216, 20);
            this.tbxTo.TabIndex = 2;
            this.tbxTo.Text = "Payerne";
            this.tbxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTo
            // 
            this.btnTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTo.Location = new System.Drawing.Point(234, 409);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(105, 23);
            this.btnTo.TabIndex = 3;
            this.btnTo.Text = "Afficher";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy  |  hh:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(456, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // chbStart
            // 
            this.chbStart.AutoSize = true;
            this.chbStart.Checked = true;
            this.chbStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStart.Location = new System.Drawing.Point(456, 38);
            this.chbStart.Name = "chbStart";
            this.chbStart.Size = new System.Drawing.Size(59, 17);
            this.chbStart.TabIndex = 6;
            this.chbStart.Text = "Arrivée";
            this.chbStart.UseVisualStyleBackColor = true;
            this.chbStart.CheckedChanged += new System.EventHandler(this.chbStart_CheckedChanged);
            // 
            // chbEnd
            // 
            this.chbEnd.AutoSize = true;
            this.chbEnd.Location = new System.Drawing.Point(598, 38);
            this.chbEnd.Name = "chbEnd";
            this.chbEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbEnd.Size = new System.Drawing.Size(58, 17);
            this.chbEnd.TabIndex = 6;
            this.chbEnd.Text = "Départ";
            this.chbEnd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbEnd.UseVisualStyleBackColor = true;
            this.chbEnd.CheckedChanged += new System.EventHandler(this.chbEnd_CheckedChanged);
            // 
            // libConn
            // 
            this.libConn.FormattingEnabled = true;
            this.libConn.Location = new System.Drawing.Point(456, 61);
            this.libConn.Name = "libConn";
            this.libConn.Size = new System.Drawing.Size(200, 316);
            this.libConn.TabIndex = 7;
            // 
            // txtConn
            // 
            this.txtConn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConn.Location = new System.Drawing.Point(662, 12);
            this.txtConn.Name = "txtConn";
            this.txtConn.ReadOnly = true;
            this.txtConn.Size = new System.Drawing.Size(338, 365);
            this.txtConn.TabIndex = 8;
            this.txtConn.Text = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(456, 409);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Rafraîchir";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFromDel
            // 
            this.btnFromDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFromDel.Location = new System.Drawing.Point(123, 409);
            this.btnFromDel.Name = "btnFromDel";
            this.btnFromDel.Size = new System.Drawing.Size(105, 23);
            this.btnFromDel.TabIndex = 3;
            this.btnFromDel.Text = "Effacer";
            this.btnFromDel.UseVisualStyleBackColor = true;
            this.btnFromDel.Click += new System.EventHandler(this.btnFromDel_Click);
            // 
            // btnToDel
            // 
            this.btnToDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToDel.Location = new System.Drawing.Point(345, 409);
            this.btnToDel.Name = "btnToDel";
            this.btnToDel.Size = new System.Drawing.Size(105, 23);
            this.btnToDel.TabIndex = 3;
            this.btnToDel.Text = "Effacer";
            this.btnToDel.UseVisualStyleBackColor = true;
            this.btnToDel.Click += new System.EventHandler(this.btnToDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtConn);
            this.Controls.Add(this.libConn);
            this.Controls.Add(this.chbEnd);
            this.Controls.Add(this.chbStart);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.chblTo);
            this.Controls.Add(this.chblFrom);
            this.Controls.Add(this.btnToDel);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnFromDel);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.tbxFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.CheckedListBox chblFrom;
        private System.Windows.Forms.CheckedListBox chblTo;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chbStart;
        private System.Windows.Forms.CheckBox chbEnd;
        private System.Windows.Forms.ListBox libConn;
        private System.Windows.Forms.RichTextBox txtConn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFromDel;
        private System.Windows.Forms.Button btnToDel;
    }
}

