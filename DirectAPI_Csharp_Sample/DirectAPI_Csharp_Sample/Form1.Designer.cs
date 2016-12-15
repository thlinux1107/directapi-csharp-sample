namespace DirectAPI_Csharp_Sample
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
            this.btProcess = new System.Windows.Forms.Button();
            this.txtJSONRequest = new System.Windows.Forms.TextBox();
            this.txtJSONResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLoadVaultRequest = new System.Windows.Forms.Button();
            this.btLoadSaleRequest = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btLoadGetDetail = new System.Windows.Forms.Button();
            this.txtVerb = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProcess
            // 
            this.btProcess.Location = new System.Drawing.Point(11, 330);
            this.btProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(116, 28);
            this.btProcess.TabIndex = 3;
            this.btProcess.Text = "Process Request";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // txtJSONRequest
            // 
            this.txtJSONRequest.Location = new System.Drawing.Point(216, 146);
            this.txtJSONRequest.Margin = new System.Windows.Forms.Padding(2);
            this.txtJSONRequest.Multiline = true;
            this.txtJSONRequest.Name = "txtJSONRequest";
            this.txtJSONRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJSONRequest.Size = new System.Drawing.Size(227, 245);
            this.txtJSONRequest.TabIndex = 5;
            // 
            // txtJSONResponse
            // 
            this.txtJSONResponse.Location = new System.Drawing.Point(447, 146);
            this.txtJSONResponse.Margin = new System.Windows.Forms.Padding(2);
            this.txtJSONResponse.Multiline = true;
            this.txtJSONResponse.Name = "txtJSONResponse";
            this.txtJSONResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJSONResponse.Size = new System.Drawing.Size(227, 245);
            this.txtJSONResponse.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Response";
            // 
            // btLoadVaultRequest
            // 
            this.btLoadVaultRequest.Location = new System.Drawing.Point(11, 72);
            this.btLoadVaultRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadVaultRequest.Name = "btLoadVaultRequest";
            this.btLoadVaultRequest.Size = new System.Drawing.Size(139, 28);
            this.btLoadVaultRequest.TabIndex = 2;
            this.btLoadVaultRequest.Text = "Load Vault Request";
            this.btLoadVaultRequest.UseVisualStyleBackColor = true;
            this.btLoadVaultRequest.Click += new System.EventHandler(this.btLoadVaultRequest_Click);
            // 
            // btLoadSaleRequest
            // 
            this.btLoadSaleRequest.Location = new System.Drawing.Point(11, 23);
            this.btLoadSaleRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadSaleRequest.Name = "btLoadSaleRequest";
            this.btLoadSaleRequest.Size = new System.Drawing.Size(139, 28);
            this.btLoadSaleRequest.TabIndex = 1;
            this.btLoadSaleRequest.Text = "Load Sale Request";
            this.btLoadSaleRequest.UseVisualStyleBackColor = true;
            this.btLoadSaleRequest.Click += new System.EventHandler(this.btLoadSaleRequest_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(216, 23);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(458, 45);
            this.txtURL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Note: Request may be edited prior to selecting \"Process Request\" button.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "- OR -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "- OR -";
            // 
            // btLoadGetDetail
            // 
            this.btLoadGetDetail.Location = new System.Drawing.Point(11, 123);
            this.btLoadGetDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadGetDetail.Name = "btLoadGetDetail";
            this.btLoadGetDetail.Size = new System.Drawing.Size(139, 28);
            this.btLoadGetDetail.TabIndex = 3;
            this.btLoadGetDetail.Text = "Load Get Charges Detail";
            this.btLoadGetDetail.UseVisualStyleBackColor = true;
            this.btLoadGetDetail.Click += new System.EventHandler(this.btLoadGetDetail_Click);
            // 
            // txtVerb
            // 
            this.txtVerb.Location = new System.Drawing.Point(216, 99);
            this.txtVerb.Name = "txtVerb";
            this.txtVerb.Size = new System.Drawing.Size(227, 20);
            this.txtVerb.TabIndex = 14;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(447, 99);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(227, 20);
            this.txtReference.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Verb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Reference";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(11, 363);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(116, 28);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "Clear Form";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 428);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtVerb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLoadGetDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btLoadSaleRequest);
            this.Controls.Add(this.btLoadVaultRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJSONResponse);
            this.Controls.Add(this.txtJSONRequest);
            this.Controls.Add(this.btProcess);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Direct API C# Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.TextBox txtJSONRequest;
        private System.Windows.Forms.TextBox txtJSONResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLoadVaultRequest;
        private System.Windows.Forms.Button btLoadSaleRequest;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLoadGetDetail;
        private System.Windows.Forms.TextBox txtVerb;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btClear;
    }
}

