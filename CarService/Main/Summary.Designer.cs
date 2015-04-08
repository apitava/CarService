namespace Main
{
    partial class Summary
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
            this.NewOrder = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(40, 49);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(75, 23);
            this.NewOrder.TabIndex = 0;
            this.NewOrder.Text = "New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(317, 49);
            this.Debug.Multiline = true;
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(456, 434);
            this.Debug.TabIndex = 1;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 512);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.NewOrder);
            this.Name = "Summary";
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.TextBox Debug;
    }
}

