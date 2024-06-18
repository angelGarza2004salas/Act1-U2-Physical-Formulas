namespace physical_formulas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCalculateVelocity = new System.Windows.Forms.Button();
            this.BtnCalculateAceleration = new System.Windows.Forms.Button();
            this.BtnCalculateKineticEnergy = new System.Windows.Forms.Button();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.TxtInitialVelocity = new System.Windows.Forms.TextBox();
            this.TxtFinalVelocity = new System.Windows.Forms.TextBox();
            this.TxtAccelerationTime = new System.Windows.Forms.TextBox();
            this.TxtMass = new System.Windows.Forms.TextBox();
            this.TxtVelocity = new System.Windows.Forms.TextBox();
            this.TxtDistance = new System.Windows.Forms.TextBox();
            this.LblResultVelocity = new System.Windows.Forms.Label();
            this.LblResultAceleration = new System.Windows.Forms.Label();
            this.LblResultKineticEnergy = new System.Windows.Forms.Label();
            this.LblDistancee = new System.Windows.Forms.Label();
            this.LblTimee = new System.Windows.Forms.Label();
            this.LblInitialVelocityy = new System.Windows.Forms.Label();
            this.LblFinalVelocityy = new System.Windows.Forms.Label();
            this.LblAcelerationTimee = new System.Windows.Forms.Label();
            this.LblMass = new System.Windows.Forms.Label();
            this.LblVelocityy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalculateVelocity
            // 
            this.BtnCalculateVelocity.Location = new System.Drawing.Point(100, 51);
            this.BtnCalculateVelocity.Name = "BtnCalculateVelocity";
            this.BtnCalculateVelocity.Size = new System.Drawing.Size(145, 41);
            this.BtnCalculateVelocity.TabIndex = 0;
            this.BtnCalculateVelocity.Text = "Calculate Velocity";
            this.BtnCalculateVelocity.UseVisualStyleBackColor = true;
            this.BtnCalculateVelocity.Click += new System.EventHandler(this.BtnCalculateVelocity_Click);
            // 
            // BtnCalculateAceleration
            // 
            this.BtnCalculateAceleration.Location = new System.Drawing.Point(265, 51);
            this.BtnCalculateAceleration.Name = "BtnCalculateAceleration";
            this.BtnCalculateAceleration.Size = new System.Drawing.Size(164, 41);
            this.BtnCalculateAceleration.TabIndex = 1;
            this.BtnCalculateAceleration.Text = "Calculate Aceleration";
            this.BtnCalculateAceleration.UseVisualStyleBackColor = true;
            this.BtnCalculateAceleration.Click += new System.EventHandler(this.BtnCalculateAceleration_Click);
            // 
            // BtnCalculateKineticEnergy
            // 
            this.BtnCalculateKineticEnergy.Location = new System.Drawing.Point(445, 51);
            this.BtnCalculateKineticEnergy.Name = "BtnCalculateKineticEnergy";
            this.BtnCalculateKineticEnergy.Size = new System.Drawing.Size(145, 41);
            this.BtnCalculateKineticEnergy.TabIndex = 2;
            this.BtnCalculateKineticEnergy.Text = "Calculate Kinetic Energy";
            this.BtnCalculateKineticEnergy.UseVisualStyleBackColor = true;
            this.BtnCalculateKineticEnergy.Click += new System.EventHandler(this.BtnCalculateKineticEnergy_Click);
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(202, 221);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(100, 22);
            this.TxtTime.TabIndex = 3;
            // 
            // TxtInitialVelocity
            // 
            this.TxtInitialVelocity.Location = new System.Drawing.Point(202, 274);
            this.TxtInitialVelocity.Name = "TxtInitialVelocity";
            this.TxtInitialVelocity.Size = new System.Drawing.Size(100, 22);
            this.TxtInitialVelocity.TabIndex = 4;
            // 
            // TxtFinalVelocity
            // 
            this.TxtFinalVelocity.Location = new System.Drawing.Point(202, 327);
            this.TxtFinalVelocity.Name = "TxtFinalVelocity";
            this.TxtFinalVelocity.Size = new System.Drawing.Size(100, 22);
            this.TxtFinalVelocity.TabIndex = 5;
            // 
            // TxtAccelerationTime
            // 
            this.TxtAccelerationTime.Location = new System.Drawing.Point(202, 380);
            this.TxtAccelerationTime.Name = "TxtAccelerationTime";
            this.TxtAccelerationTime.Size = new System.Drawing.Size(100, 22);
            this.TxtAccelerationTime.TabIndex = 6;
            // 
            // TxtMass
            // 
            this.TxtMass.Location = new System.Drawing.Point(202, 435);
            this.TxtMass.Name = "TxtMass";
            this.TxtMass.Size = new System.Drawing.Size(100, 22);
            this.TxtMass.TabIndex = 7;
            // 
            // TxtVelocity
            // 
            this.TxtVelocity.Location = new System.Drawing.Point(202, 493);
            this.TxtVelocity.Name = "TxtVelocity";
            this.TxtVelocity.Size = new System.Drawing.Size(100, 22);
            this.TxtVelocity.TabIndex = 8;
            // 
            // TxtDistance
            // 
            this.TxtDistance.Location = new System.Drawing.Point(202, 175);
            this.TxtDistance.Name = "TxtDistance";
            this.TxtDistance.Size = new System.Drawing.Size(100, 22);
            this.TxtDistance.TabIndex = 9;
            // 
            // LblResultVelocity
            // 
            this.LblResultVelocity.AutoSize = true;
            this.LblResultVelocity.Location = new System.Drawing.Point(405, 196);
            this.LblResultVelocity.Name = "LblResultVelocity";
            this.LblResultVelocity.Size = new System.Drawing.Size(96, 16);
            this.LblResultVelocity.TabIndex = 10;
            this.LblResultVelocity.Text = "Result Velocity";
            // 
            // LblResultAceleration
            // 
            this.LblResultAceleration.AutoSize = true;
            this.LblResultAceleration.Location = new System.Drawing.Point(405, 305);
            this.LblResultAceleration.Name = "LblResultAceleration";
            this.LblResultAceleration.Size = new System.Drawing.Size(116, 16);
            this.LblResultAceleration.TabIndex = 11;
            this.LblResultAceleration.Text = "Result Aceleration";
            // 
            // LblResultKineticEnergy
            // 
            this.LblResultKineticEnergy.AutoSize = true;
            this.LblResultKineticEnergy.Location = new System.Drawing.Point(405, 441);
            this.LblResultKineticEnergy.Name = "LblResultKineticEnergy";
            this.LblResultKineticEnergy.Size = new System.Drawing.Size(133, 16);
            this.LblResultKineticEnergy.TabIndex = 12;
            this.LblResultKineticEnergy.Text = "Result Kinetic Energy";
            // 
            // LblDistancee
            // 
            this.LblDistancee.AutoSize = true;
            this.LblDistancee.Location = new System.Drawing.Point(79, 175);
            this.LblDistancee.Name = "LblDistancee";
            this.LblDistancee.Size = new System.Drawing.Size(60, 16);
            this.LblDistancee.TabIndex = 13;
            this.LblDistancee.Text = "Distance";
            // 
            // LblTimee
            // 
            this.LblTimee.AutoSize = true;
            this.LblTimee.Location = new System.Drawing.Point(79, 227);
            this.LblTimee.Name = "LblTimee";
            this.LblTimee.Size = new System.Drawing.Size(38, 16);
            this.LblTimee.TabIndex = 14;
            this.LblTimee.Text = "Time";
            // 
            // LblInitialVelocityy
            // 
            this.LblInitialVelocityy.AutoSize = true;
            this.LblInitialVelocityy.Location = new System.Drawing.Point(79, 277);
            this.LblInitialVelocityy.Name = "LblInitialVelocityy";
            this.LblInitialVelocityy.Size = new System.Drawing.Size(88, 16);
            this.LblInitialVelocityy.TabIndex = 15;
            this.LblInitialVelocityy.Text = "Initial Velocity";
            // 
            // LblFinalVelocityy
            // 
            this.LblFinalVelocityy.AutoSize = true;
            this.LblFinalVelocityy.Location = new System.Drawing.Point(79, 333);
            this.LblFinalVelocityy.Name = "LblFinalVelocityy";
            this.LblFinalVelocityy.Size = new System.Drawing.Size(87, 16);
            this.LblFinalVelocityy.TabIndex = 16;
            this.LblFinalVelocityy.Text = "Final Velocity";
            // 
            // LblAcelerationTimee
            // 
            this.LblAcelerationTimee.AutoSize = true;
            this.LblAcelerationTimee.Location = new System.Drawing.Point(79, 386);
            this.LblAcelerationTimee.Name = "LblAcelerationTimee";
            this.LblAcelerationTimee.Size = new System.Drawing.Size(109, 16);
            this.LblAcelerationTimee.TabIndex = 17;
            this.LblAcelerationTimee.Text = "Aceleration Time";
            // 
            // LblMass
            // 
            this.LblMass.AutoSize = true;
            this.LblMass.Location = new System.Drawing.Point(79, 441);
            this.LblMass.Name = "LblMass";
            this.LblMass.Size = new System.Drawing.Size(40, 16);
            this.LblMass.TabIndex = 18;
            this.LblMass.Text = "Mass";
            // 
            // LblVelocityy
            // 
            this.LblVelocityy.AutoSize = true;
            this.LblVelocityy.Location = new System.Drawing.Point(79, 499);
            this.LblVelocityy.Name = "LblVelocityy";
            this.LblVelocityy.Size = new System.Drawing.Size(55, 16);
            this.LblVelocityy.TabIndex = 19;
            this.LblVelocityy.Text = "Velocity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 553);
            this.Controls.Add(this.LblVelocityy);
            this.Controls.Add(this.LblMass);
            this.Controls.Add(this.LblAcelerationTimee);
            this.Controls.Add(this.LblFinalVelocityy);
            this.Controls.Add(this.LblInitialVelocityy);
            this.Controls.Add(this.LblTimee);
            this.Controls.Add(this.LblDistancee);
            this.Controls.Add(this.LblResultKineticEnergy);
            this.Controls.Add(this.LblResultAceleration);
            this.Controls.Add(this.LblResultVelocity);
            this.Controls.Add(this.TxtDistance);
            this.Controls.Add(this.TxtVelocity);
            this.Controls.Add(this.TxtMass);
            this.Controls.Add(this.TxtAccelerationTime);
            this.Controls.Add(this.TxtFinalVelocity);
            this.Controls.Add(this.TxtInitialVelocity);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.BtnCalculateKineticEnergy);
            this.Controls.Add(this.BtnCalculateAceleration);
            this.Controls.Add(this.BtnCalculateVelocity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculateVelocity;
        private System.Windows.Forms.Button BtnCalculateAceleration;
        private System.Windows.Forms.Button BtnCalculateKineticEnergy;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.TextBox TxtInitialVelocity;
        private System.Windows.Forms.TextBox TxtFinalVelocity;
        private System.Windows.Forms.TextBox TxtAccelerationTime;
        private System.Windows.Forms.TextBox TxtMass;
        private System.Windows.Forms.TextBox TxtVelocity;
        private System.Windows.Forms.TextBox TxtDistance;
        private System.Windows.Forms.Label LblResultVelocity;
        private System.Windows.Forms.Label LblResultAceleration;
        private System.Windows.Forms.Label LblResultKineticEnergy;
        private System.Windows.Forms.Label LblDistancee;
        private System.Windows.Forms.Label LblTimee;
        private System.Windows.Forms.Label LblInitialVelocityy;
        private System.Windows.Forms.Label LblFinalVelocityy;
        private System.Windows.Forms.Label LblAcelerationTimee;
        private System.Windows.Forms.Label LblMass;
        private System.Windows.Forms.Label LblVelocityy;
    }
}

