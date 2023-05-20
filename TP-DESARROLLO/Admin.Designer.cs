namespace TP_DESARROLLO
{
    partial class Admin
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 48);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "SECCION ADMINISTRADOR";
            // 
            // button1
            // 
            button1.Location = new Point(78, 110);
            button1.Name = "button1";
            button1.Size = new Size(170, 32);
            button1.TabIndex = 1;
            button1.Text = "Administrar Usuarios ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 179);
            button2.Name = "button2";
            button2.Size = new Size(170, 32);
            button2.TabIndex = 2;
            button2.Text = "Administrar Peliculas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(78, 256);
            button3.Name = "button3";
            button3.Size = new Size(170, 32);
            button3.TabIndex = 3;
            button3.Text = "Administrar Salas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(78, 331);
            button4.Name = "button4";
            button4.Size = new Size(170, 32);
            button4.TabIndex = 4;
            button4.Text = "Administrar Funciones";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(831, 410);
            button5.Name = "button5";
            button5.Size = new Size(105, 32);
            button5.TabIndex = 5;
            button5.Text = "Cerrar Sesion";
            button5.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(984, 483);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}