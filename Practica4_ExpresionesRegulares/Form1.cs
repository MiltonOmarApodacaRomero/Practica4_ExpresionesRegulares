namespace Practica4_ExpresionesRegulares;

public partial class Form1 : Form
{
    public Form1() {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }
    
    private void txt_Edad_TextChanged(object sender, EventArgs e)
    {

    }

    private void txt_Num_TextChanged(object sender, EventArgs e)
    {

    }

    private void txt_Salario_TextChanged(object sender, EventArgs e)
    {

    }

    private void txt_RFC_TextChanged(object sender, EventArgs e)
    {

    }

    private void txt_Correo_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_Validar_Click(object sender, EventArgs e)
    {
        bool n = ExpresorRegular.Evaluar(txt_Name.Text, TiposValidos.Nombre);
        bool ed = ExpresorRegular.Evaluar(txt_Edad.Text, TiposValidos.Edad);
        bool t = ExpresorRegular.Evaluar(txt_Num.Text, TiposValidos.Telefono);
        bool s = ExpresorRegular.Evaluar(txt_Salario.Text, TiposValidos.Salario);
        bool rfc = ExpresorRegular.Evaluar(txt_RFC.Text, TiposValidos.RFC);
        bool c = ExpresorRegular.Evaluar(txt_Correo.Text, TiposValidos.Correo);
        if(txt_Name.Text == "" && txt_Edad.Text == "" && txt_Num.Text == "" && txt_Salario.Text == "" && txt_RFC.Text == "" && txt_Correo.Text == "")
        {
            MessageBox.Show("Por favor, ingrese datos en los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (n && ed && t && s && rfc && c)
        {
            MessageBox.Show("Las campos ingresados son validos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}