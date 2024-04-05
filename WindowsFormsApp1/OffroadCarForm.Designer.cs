using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipApp
{
    partial class OffroadCarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblFourWheelDrive = new System.Windows.Forms.Label();
            this.chkFourWheelDrive = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(13, 13);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(100, 10);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(121, 20);
            this.txtBrand.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 39);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(100, 36);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 65);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 62);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 20);
            this.txtYear.TabIndex = 5;
            // 
            // lblFourWheelDrive
            // 
            this.lblFourWheelDrive.AutoSize = true;
            this.lblFourWheelDrive.Location = new System.Drawing.Point(13, 92);
            this.lblFourWheelDrive.Name = "lblFourWheelDrive";
            this.lblFourWheelDrive.Size = new System.Drawing.Size(81, 13);
            this.lblFourWheelDrive.TabIndex = 6;
            this.lblFourWheelDrive.Text = "Four Wheel Drive";
            // 
            // chkFourWheelDrive
            // 
            this.chkFourWheelDrive.AutoSize = true;
            this.chkFourWheelDrive.Location = new System.Drawing.Point(100, 92);
            this.chkFourWheelDrive.Name = "chkFourWheelDrive";
            this.chkFourWheelDrive.Size = new System.Drawing.Size(15, 14);
            this.chkFourWheelDrive.TabIndex = 7;
            this.chkFourWheelDrive.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OffroadCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkFourWheelDrive);
            this.Controls.Add(this.lblFourWheelDrive);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Name = "OffroadCarForm";
            this.Text = "Off-road Car Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblFourWheelDrive;
        private System.Windows.Forms.CheckBox chkFourWheelDrive;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}