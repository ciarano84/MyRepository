namespace Resiliance_Tracker
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNumberInput = new System.Windows.Forms.TextBox();
            this.resultsOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.feedbackOutput = new System.Windows.Forms.RichTextBox();
            this.weekInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InventoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Client1Test = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client to Update";
            // 
            // clientNumberInput
            // 
            this.clientNumberInput.Location = new System.Drawing.Point(318, 52);
            this.clientNumberInput.Name = "clientNumberInput";
            this.clientNumberInput.Size = new System.Drawing.Size(112, 26);
            this.clientNumberInput.TabIndex = 1;
            // 
            // resultsOutput
            // 
            this.resultsOutput.Location = new System.Drawing.Point(597, 96);
            this.resultsOutput.Name = "resultsOutput";
            this.resultsOutput.Size = new System.Drawing.Size(182, 323);
            this.resultsOutput.TabIndex = 4;
            this.resultsOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results to Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Feedback";
            // 
            // feedbackOutput
            // 
            this.feedbackOutput.Location = new System.Drawing.Point(785, 96);
            this.feedbackOutput.Name = "feedbackOutput";
            this.feedbackOutput.Size = new System.Drawing.Size(331, 323);
            this.feedbackOutput.TabIndex = 6;
            this.feedbackOutput.Text = "";
            // 
            // weekInput
            // 
            this.weekInput.Location = new System.Drawing.Point(318, 92);
            this.weekInput.Name = "weekInput";
            this.weekInput.Size = new System.Drawing.Size(112, 26);
            this.weekInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Week Number";
            // 
            // InventoryInput
            // 
            this.InventoryInput.Location = new System.Drawing.Point(318, 134);
            this.InventoryInput.Name = "InventoryInput";
            this.InventoryInput.Size = new System.Drawing.Size(112, 26);
            this.InventoryInput.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trauma Inventory Score";
            // 
            // Client1Test
            // 
            this.Client1Test.Location = new System.Drawing.Point(25, 308);
            this.Client1Test.Name = "Client1Test";
            this.Client1Test.Size = new System.Drawing.Size(124, 78);
            this.Client1Test.TabIndex = 12;
            this.Client1Test.Text = "Test Client 1";
            this.Client1Test.UseVisualStyleBackColor = true;
            this.Client1Test.Click += new System.EventHandler(this.Client1Test_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Client Number";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Client Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 922);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Client1Test);
            this.Controls.Add(this.InventoryInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weekInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feedbackOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultsOutput);
            this.Controls.Add(this.clientNumberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientNumberInput;
        private System.Windows.Forms.RichTextBox resultsOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox feedbackOutput;
        private System.Windows.Forms.TextBox weekInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InventoryInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Client1Test;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

