
namespace PFinal
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
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_LCD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_VOLTAGE = new System.Windows.Forms.Label();
            this.label_STATUS_PORT = new System.Windows.Forms.Label();
            this.button_OPEN_PORT = new System.Windows.Forms.Button();
            this.comboBox_PORT_NAME = new System.Windows.Forms.ComboBox();
            this.port_select_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(518, 162);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Area de texto para LCD:";
            // 
            // label_LCD
            // 
            this.label_LCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_LCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LCD.Location = new System.Drawing.Point(306, 250);
            this.label_LCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LCD.Name = "label_LCD";
            this.label_LCD.Size = new System.Drawing.Size(306, 95);
            this.label_LCD.TabIndex = 22;
            this.label_LCD.Text = "label";
            this.label_LCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(518, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(518, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(305, 153);
            this.button_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(141, 60);
            this.button_EXIT.TabIndex = 19;
            this.button_EXIT.Text = "Salida";
            this.button_EXIT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Volts";
            // 
            // label_VOLTAGE
            // 
            this.label_VOLTAGE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_VOLTAGE.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VOLTAGE.Location = new System.Drawing.Point(6, 165);
            this.label_VOLTAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_VOLTAGE.Name = "label_VOLTAGE";
            this.label_VOLTAGE.Size = new System.Drawing.Size(132, 68);
            this.label_VOLTAGE.TabIndex = 17;
            // 
            // label_STATUS_PORT
            // 
            this.label_STATUS_PORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_STATUS_PORT.Location = new System.Drawing.Point(6, 92);
            this.label_STATUS_PORT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_STATUS_PORT.Name = "label_STATUS_PORT";
            this.label_STATUS_PORT.Size = new System.Drawing.Size(266, 38);
            this.label_STATUS_PORT.TabIndex = 16;
            this.label_STATUS_PORT.Text = "label1";
            this.label_STATUS_PORT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_OPEN_PORT
            // 
            this.button_OPEN_PORT.Location = new System.Drawing.Point(305, 5);
            this.button_OPEN_PORT.Margin = new System.Windows.Forms.Padding(4);
            this.button_OPEN_PORT.Name = "button_OPEN_PORT";
            this.button_OPEN_PORT.Size = new System.Drawing.Size(144, 96);
            this.button_OPEN_PORT.TabIndex = 15;
            this.button_OPEN_PORT.Text = "Open PORT";
            this.button_OPEN_PORT.UseVisualStyleBackColor = true;
            // 
            // comboBox_PORT_NAME
            // 
            this.comboBox_PORT_NAME.FormattingEnabled = true;
            this.comboBox_PORT_NAME.Location = new System.Drawing.Point(6, 49);
            this.comboBox_PORT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_PORT_NAME.Name = "comboBox_PORT_NAME";
            this.comboBox_PORT_NAME.Size = new System.Drawing.Size(265, 24);
            this.comboBox_PORT_NAME.TabIndex = 14;
            // 
            // port_select_label
            // 
            this.port_select_label.AutoSize = true;
            this.port_select_label.Location = new System.Drawing.Point(10, 10);
            this.port_select_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port_select_label.Name = "port_select_label";
            this.port_select_label.Size = new System.Drawing.Size(126, 17);
            this.port_select_label.TabIndex = 13;
            this.port_select_label.Text = "Selecciona puerto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_LCD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_VOLTAGE);
            this.Controls.Add(this.label_STATUS_PORT);
            this.Controls.Add(this.button_OPEN_PORT);
            this.Controls.Add(this.comboBox_PORT_NAME);
            this.Controls.Add(this.port_select_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_LCD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_VOLTAGE;
        private System.Windows.Forms.Label label_STATUS_PORT;
        private System.Windows.Forms.Button button_OPEN_PORT;
        private System.Windows.Forms.ComboBox comboBox_PORT_NAME;
        private System.Windows.Forms.Label port_select_label;
    }
}

