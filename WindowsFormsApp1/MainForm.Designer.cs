namespace CarDealershipApp
{
    partial class MainForm
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
            this.btnAddSportCar = new System.Windows.Forms.Button();
            this.btnAddFamilyCar = new System.Windows.Forms.Button();
            this.btnAddOffroadCar = new System.Windows.Forms.Button();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAddSportCar
            // 
            this.btnAddSportCar.Location = new System.Drawing.Point(12, 12);
            this.btnAddSportCar.Name = "btnAddSportCar";
            this.btnAddSportCar.Size = new System.Drawing.Size(130, 23);
            this.btnAddSportCar.TabIndex = 0;
            this.btnAddSportCar.Text = "Add Sport Car";
            this.btnAddSportCar.UseVisualStyleBackColor = true;
            this.btnAddSportCar.Click += new System.EventHandler(this.btnAddSportCar_Click);
            // 
            // btnAddFamilyCar
            // 
            this.btnAddFamilyCar.Location = new System.Drawing.Point(148, 12);
            this.btnAddFamilyCar.Name = "btnAddFamilyCar";
            this.btnAddFamilyCar.Size = new System.Drawing.Size(130, 23);
            this.btnAddFamilyCar.TabIndex = 1;
            this.btnAddFamilyCar.Text = "Add Family Car";
            this.btnAddFamilyCar.UseVisualStyleBackColor = true;
            this.btnAddFamilyCar.Click += new System.EventHandler(this.btnAddFamilyCar_Click);
            // 
            // btnAddOffroadCar
            // 
            this.btnAddOffroadCar.Location = new System.Drawing.Point(284, 12);
            this.btnAddOffroadCar.Name = "btnAddOffroadCar";
            this.btnAddOffroadCar.Size = new System.Drawing.Size(130, 23);
            this.btnAddOffroadCar.TabIndex = 2;
            this.btnAddOffroadCar.Text = "Add Offroad Car";
            this.btnAddOffroadCar.UseVisualStyleBackColor = true;
            this.btnAddOffroadCar.Click += new System.EventHandler(this.btnAddOffroadCar_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(420, 12);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveCar.TabIndex = 3;
            this.btnRemoveCar.Text = "Remove Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.Location = new System.Drawing.Point(12, 41);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(776, 397);
            this.listViewCars.TabIndex = 4;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnAddOffroadCar);
            this.Controls.Add(this.btnAddFamilyCar);
            this.Controls.Add(this.btnAddSportCar);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSportCar;
        private System.Windows.Forms.Button btnAddFamilyCar;
        private System.Windows.Forms.Button btnAddOffroadCar;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.ListView listViewCars;
    }
}