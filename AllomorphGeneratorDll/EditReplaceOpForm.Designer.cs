namespace SIL.AllomorphGenerator
{
    partial class EditReplaceOpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReplaceOpForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbReplace = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.cbRegEx = new System.Windows.Forms.CheckBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lbVarieties = new System.Windows.Forms.Label();
            this.cbAch = new System.Windows.Forms.CheckBox();
            this.cbAcl = new System.Windows.Forms.CheckBox();
            this.cbAkh = new System.Windows.Forms.CheckBox();
            this.cbAkl = new System.Windows.Forms.CheckBox();
            this.cbAme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(693, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(561, 403);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 34);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbReplace
            // 
            this.lbReplace.AutoSize = true;
            this.lbReplace.Location = new System.Drawing.Point(51, 36);
            this.lbReplace.Name = "lbReplace";
            this.lbReplace.Size = new System.Drawing.Size(68, 20);
            this.lbReplace.TabIndex = 2;
            this.lbReplace.Text = "Replace";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(125, 36);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(352, 26);
            this.tbFrom.TabIndex = 3;
            // 
            // cbRegEx
            // 
            this.cbRegEx.AutoSize = true;
            this.cbRegEx.Location = new System.Drawing.Point(509, 38);
            this.cbRegEx.Name = "cbRegEx";
            this.cbRegEx.Size = new System.Drawing.Size(171, 24);
            this.cbRegEx.TabIndex = 14;
            this.cbRegEx.Text = "Regular expression";
            this.cbRegEx.UseVisualStyleBackColor = true;
            this.cbRegEx.CheckedChanged += new System.EventHandler(this.cbRegEx_CheckedChanged);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(55, 90);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(27, 20);
            this.lbTo.TabIndex = 15;
            this.lbTo.Text = "To";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(125, 83);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(352, 26);
            this.tbTo.TabIndex = 16;
            // 
            // lbVarieties
            // 
            this.lbVarieties.AutoSize = true;
            this.lbVarieties.Location = new System.Drawing.Point(55, 148);
            this.lbVarieties.Name = "lbVarieties";
            this.lbVarieties.Size = new System.Drawing.Size(75, 20);
            this.lbVarieties.TabIndex = 17;
            this.lbVarieties.Text = "Varieties:";
            // 
            // cbAch
            // 
            this.cbAch.AutoSize = true;
            this.cbAch.Location = new System.Drawing.Point(189, 148);
            this.cbAch.Name = "cbAch";
            this.cbAch.Size = new System.Drawing.Size(61, 24);
            this.cbAch.TabIndex = 18;
            this.cbAch.Text = "ach";
            this.cbAch.UseVisualStyleBackColor = true;
            this.cbAch.CheckedChanged += new System.EventHandler(this.cbAch_CheckedChanged);
            // 
            // cbAcl
            // 
            this.cbAcl.AutoSize = true;
            this.cbAcl.Location = new System.Drawing.Point(189, 195);
            this.cbAcl.Name = "cbAcl";
            this.cbAcl.Size = new System.Drawing.Size(55, 24);
            this.cbAcl.TabIndex = 19;
            this.cbAcl.Text = "acl";
            this.cbAcl.UseVisualStyleBackColor = true;
            this.cbAcl.CheckedChanged += new System.EventHandler(this.cbAcl_CheckedChanged);
            // 
            // cbAkh
            // 
            this.cbAkh.AutoSize = true;
            this.cbAkh.Location = new System.Drawing.Point(189, 242);
            this.cbAkh.Name = "cbAkh";
            this.cbAkh.Size = new System.Drawing.Size(61, 24);
            this.cbAkh.TabIndex = 20;
            this.cbAkh.Text = "akh";
            this.cbAkh.UseVisualStyleBackColor = true;
            this.cbAkh.CheckedChanged += new System.EventHandler(this.cbAkh_CheckedChanged);
            // 
            // cbAkl
            // 
            this.cbAkl.AutoSize = true;
            this.cbAkl.Location = new System.Drawing.Point(189, 289);
            this.cbAkl.Name = "cbAkl";
            this.cbAkl.Size = new System.Drawing.Size(55, 24);
            this.cbAkl.TabIndex = 21;
            this.cbAkl.Text = "akl";
            this.cbAkl.UseVisualStyleBackColor = true;
            this.cbAkl.CheckedChanged += new System.EventHandler(this.cbAkl_CheckedChanged);
            // 
            // cbAme
            // 
            this.cbAme.AutoSize = true;
            this.cbAme.Location = new System.Drawing.Point(189, 336);
            this.cbAme.Name = "cbAme";
            this.cbAme.Size = new System.Drawing.Size(66, 24);
            this.cbAme.TabIndex = 22;
            this.cbAme.Text = "ame";
            this.cbAme.UseVisualStyleBackColor = true;
            this.cbAme.CheckedChanged += new System.EventHandler(this.cbAme_CheckedChanged);
            // 
            // EditReplaceOpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbAme);
            this.Controls.Add(this.cbAkl);
            this.Controls.Add(this.cbAkh);
            this.Controls.Add(this.cbAcl);
            this.Controls.Add(this.cbAch);
            this.Controls.Add(this.lbVarieties);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.cbRegEx);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lbReplace);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditReplaceOpForm";
            this.Text = "Edit Replace Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbReplace;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.CheckBox cbRegEx;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lbVarieties;
        private System.Windows.Forms.CheckBox cbAch;
        private System.Windows.Forms.CheckBox cbAcl;
        private System.Windows.Forms.CheckBox cbAkh;
        private System.Windows.Forms.CheckBox cbAkl;
        private System.Windows.Forms.CheckBox cbAme;
    }
}