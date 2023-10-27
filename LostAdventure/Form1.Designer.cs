
namespace LostAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.feddy = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.PictureBox();
            this.option1Button = new System.Windows.Forms.PictureBox();
            this.lighterbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).BeginInit();
            this.SuspendLayout();
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(67, 359);
            this.option2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(225, 23);
            this.option2Label.TabIndex = 10;
            this.option2Label.Text = "stop";
            this.option2Label.Click += new System.EventHandler(this.option2Label_Click);
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(67, 323);
            this.option1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(225, 23);
            this.option1Label.TabIndex = 9;
            this.option1Label.Text = "start";
            this.option1Label.Click += new System.EventHandler(this.option1Label_Click);
            // 
            // feddy
            // 
            this.feddy.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feddy.ForeColor = System.Drawing.Color.White;
            this.feddy.Location = new System.Drawing.Point(8, 9);
            this.feddy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feddy.Name = "feddy";
            this.feddy.Size = new System.Drawing.Size(313, 143);
            this.feddy.TabIndex = 8;
            this.feddy.Text = "escape the forest";
            this.feddy.Click += new System.EventHandler(this.feddy_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Image = global::LostAdventure.Properties.Resources.feddy;
            this.imageBox.Location = new System.Drawing.Point(11, 175);
            this.imageBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(281, 135);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 11;
            this.imageBox.TabStop = false;
            this.imageBox.Click += new System.EventHandler(this.imageBox_Click);
            // 
            // option2Button
            // 
            this.option2Button.Image = global::LostAdventure.Properties.Resources.arrowRight;
            this.option2Button.Location = new System.Drawing.Point(24, 350);
            this.option2Button.Margin = new System.Windows.Forms.Padding(2);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(39, 32);
            this.option2Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option2Button.TabIndex = 7;
            this.option2Button.TabStop = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.Image = global::LostAdventure.Properties.Resources.arrowRight;
            this.option1Button.Location = new System.Drawing.Point(24, 314);
            this.option1Button.Margin = new System.Windows.Forms.Padding(2);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(39, 32);
            this.option1Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.option1Button.TabIndex = 6;
            this.option1Button.TabStop = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // lighterbutton
            // 
            this.lighterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lighterbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lighterbutton.Location = new System.Drawing.Point(24, 387);
            this.lighterbutton.Name = "lighterbutton";
            this.lighterbutton.Size = new System.Drawing.Size(75, 23);
            this.lighterbutton.TabIndex = 12;
            this.lighterbutton.UseVisualStyleBackColor = true;
            this.lighterbutton.Click += new System.EventHandler(this.lighterbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(314, 422);
            this.Controls.Add(this.lighterbutton);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.feddy);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost in a Forest";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label feddy;
        private System.Windows.Forms.PictureBox option2Button;
        private System.Windows.Forms.PictureBox option1Button;
        private System.Windows.Forms.Button lighterbutton;
    }
}

