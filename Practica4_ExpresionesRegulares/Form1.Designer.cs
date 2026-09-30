namespace Practica4_ExpresionesRegulares;

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
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        btn_Validar = new System.Windows.Forms.Button();
        txt_Name = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        txt_Correo = new System.Windows.Forms.TextBox();
        txt_RFC = new System.Windows.Forms.TextBox();
        txt_Salario = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txt_Num = new System.Windows.Forms.TextBox();
        txt_Edad = new System.Windows.Forms.TextBox();
        groupBox2 = new System.Windows.Forms.GroupBox();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // btn_Validar
        // 
        btn_Validar.BackColor = System.Drawing.Color.GhostWhite;
        btn_Validar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        btn_Validar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_Validar.ForeColor = System.Drawing.Color.SteelBlue;
        btn_Validar.Location = new System.Drawing.Point(320, 377);
        btn_Validar.Name = "btn_Validar";
        btn_Validar.Size = new System.Drawing.Size(127, 35);
        btn_Validar.TabIndex = 0;
        btn_Validar.Text = "VALIDAR";
        btn_Validar.UseVisualStyleBackColor = false;
        btn_Validar.Click += btn_Validar_Click;
        // 
        // txt_Name
        // 
        txt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txt_Name.Location = new System.Drawing.Point(15, 54);
        txt_Name.Name = "txt_Name";
        txt_Name.Size = new System.Drawing.Size(216, 25);
        txt_Name.TabIndex = 1;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.Info;
        label1.Location = new System.Drawing.Point(9, 19);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(186, 30);
        label1.TabIndex = 2;
        label1.Text = "Cadena a validar:";
        // 
        // groupBox1
        // 
        groupBox1.BackColor = System.Drawing.Color.LightBlue;
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(btn_Validar);
        groupBox1.Location = new System.Drawing.Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(776, 426);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        // 
        // groupBox3
        // 
        groupBox3.BackColor = System.Drawing.Color.Ivory;
        groupBox3.Controls.Add(label5);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(txt_Correo);
        groupBox3.Controls.Add(txt_RFC);
        groupBox3.Controls.Add(txt_Salario);
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(label2);
        groupBox3.Controls.Add(txt_Num);
        groupBox3.Controls.Add(txt_Edad);
        groupBox3.Controls.Add(txt_Name);
        groupBox3.Location = new System.Drawing.Point(101, 105);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(566, 247);
        groupBox3.TabIndex = 4;
        groupBox3.TabStop = false;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(326, 166);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(156, 23);
        label5.TabIndex = 12;
        label5.Text = "Correo Electrónico";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(326, 94);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(156, 23);
        label6.TabIndex = 11;
        label6.Text = "RFC";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(326, 28);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(156, 23);
        label7.TabIndex = 10;
        label7.Text = "Salario";
        // 
        // txt_Correo
        // 
        txt_Correo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txt_Correo.Location = new System.Drawing.Point(326, 192);
        txt_Correo.Name = "txt_Correo";
        txt_Correo.Size = new System.Drawing.Size(216, 25);
        txt_Correo.TabIndex = 9;
        txt_Correo.TextChanged += txt_Correo_TextChanged;
        // 
        // txt_RFC
        // 
        txt_RFC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txt_RFC.Location = new System.Drawing.Point(326, 120);
        txt_RFC.Name = "txt_RFC";
        txt_RFC.Size = new System.Drawing.Size(216, 25);
        txt_RFC.TabIndex = 8;
        txt_RFC.TextChanged += txt_RFC_TextChanged;
        // 
        // txt_Salario
        // 
        txt_Salario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txt_Salario.Location = new System.Drawing.Point(326, 54);
        txt_Salario.Name = "txt_Salario";
        txt_Salario.Size = new System.Drawing.Size(216, 25);
        txt_Salario.TabIndex = 7;
        txt_Salario.TextChanged += txt_Salario_TextChanged;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(15, 166);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(156, 23);
        label4.TabIndex = 6;
        label4.Text = "Número Telefónico";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(15, 94);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(156, 23);
        label3.TabIndex = 5;
        label3.Text = "Edad";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(15, 28);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(156, 23);
        label2.TabIndex = 4;
        label2.Text = "Nombre y Apellido";
        // 
        // txt_Num
        // 
        txt_Num.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txt_Num.Location = new System.Drawing.Point(15, 192);
        txt_Num.Name = "txt_Num";
        txt_Num.Size = new System.Drawing.Size(216, 25);
        txt_Num.TabIndex = 3;
        txt_Num.TextChanged += txt_Num_TextChanged;
        // 
        // txt_Edad
        // 
        txt_Edad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txt_Edad.Location = new System.Drawing.Point(15, 120);
        txt_Edad.Name = "txt_Edad";
        txt_Edad.Size = new System.Drawing.Size(216, 25);
        txt_Edad.TabIndex = 2;
        txt_Edad.TextChanged += txt_Edad_TextChanged;
        // 
        // groupBox2
        // 
        groupBox2.BackColor = System.Drawing.Color.SteelBlue;
        groupBox2.Controls.Add(label1);
        groupBox2.Location = new System.Drawing.Point(284, 22);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(197, 61);
        groupBox2.TabIndex = 3;
        groupBox2.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.AliceBlue;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(groupBox1);
        Text = "Form1";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txt_Correo;
    private System.Windows.Forms.TextBox txt_RFC;
    private System.Windows.Forms.TextBox txt_Salario;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox txt_Name;
    private System.Windows.Forms.TextBox txt_Num;

    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Button btn_Validar;
    private System.Windows.Forms.TextBox txt_Edad;
    private System.Windows.Forms.Label label1;

    #endregion
}