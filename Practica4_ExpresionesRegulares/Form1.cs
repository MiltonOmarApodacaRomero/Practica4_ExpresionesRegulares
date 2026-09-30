namespace Practica4_ExpresionesRegulares;

public partial class Form1 : Form
{
    public Form1() {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
        ExpresorRegular.Evaluar("4,206,967", TiposValidos.Salario);
        ExpresorRegular.Evaluar("asde-123345", TiposValidos.RFC);
    }
    
    private void txt_Edad_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void txt_Num_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void txt_Salario_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void txt_RFC_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void txt_Correo_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btn_Validar_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}