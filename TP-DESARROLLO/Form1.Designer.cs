namespace TP_DESARROLLO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            iniciar_sesion = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Tomato;
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(iniciar_sesion);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Name = "label1";
            // 
            // iniciar_sesion
            // 
            iniciar_sesion.BackColor = Color.RosyBrown;
            resources.ApplyResources(iniciar_sesion, "iniciar_sesion");
            iniciar_sesion.Name = "iniciar_sesion";
            iniciar_sesion.UseVisualStyleBackColor = false;
            iniciar_sesion.Click += iniciar_sesion_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            HelpButton = true;
            IsMdiContainer = true;
            KeyPreview = true;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button iniciar_sesion;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
    }
}