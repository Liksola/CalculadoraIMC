namespace CalculadoraIMC
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
            textPeso = new TextBox();
            textAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            butSair = new Button();
            butCalcular = new Button();
            SuspendLayout();
            // 
            // textPeso
            // 
            textPeso.BackColor = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(textPeso, "textPeso");
            textPeso.Name = "textPeso";
            // 
            // textAltura
            // 
            textAltura.BackColor = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(textAltura, "textAltura");
            textAltura.Name = "textAltura";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // butSair
            // 
            butSair.BackColor = Color.FromArgb(255, 128, 128);
            resources.ApplyResources(butSair, "butSair");
            butSair.ForeColor = Color.White;
            butSair.Name = "butSair";
            butSair.UseVisualStyleBackColor = false;
            butSair.Click += butSair_Click;
            // 
            // butCalcular
            // 
            butCalcular.BackColor = Color.FromArgb(255, 128, 128);
            resources.ApplyResources(butCalcular, "butCalcular");
            butCalcular.ForeColor = Color.White;
            butCalcular.Name = "butCalcular";
            butCalcular.UseVisualStyleBackColor = false;
            butCalcular.Click += butCalcular_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(butCalcular);
            Controls.Add(butSair);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textAltura);
            Controls.Add(textPeso);
            Name = "Form1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPeso;
        private TextBox textAltura;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button butSair;
        private Button butCalcular;
    }
}
