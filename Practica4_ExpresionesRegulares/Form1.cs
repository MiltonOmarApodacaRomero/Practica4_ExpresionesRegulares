namespace Practica4_ExpresionesRegulares;

public partial class Form1 : Form
{
    public Form1() {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
       // ExpresorRegular.Evaluar("4,206,967", TiposValidos.Salario);
       // ExpresorRegular.Evaluar("asde-123345", TiposValidos.RFC);
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
        if(!ExpresorRegular.Evaluar(txt_Name.Text, TiposValidos.Nombre)){
            return;
        } else if (!ExpresorRegular.Evaluar(txt_Edad.Text, TiposValidos.Edad))
        {
            return;
        }
        else if (!ExpresorRegular.Evaluar(txt_Num.Text, TiposValidos.Telefono))
        {
            return;
        }
        else if (!ExpresorRegular.Evaluar(txt_Salario.Text, TiposValidos.Salario))
        {
            return;
        }
        else if (!ExpresorRegular.Evaluar(txt_RFC.Text, TiposValidos.RFC))
        {
            return;
        }
        else if (!ExpresorRegular.Evaluar(txt_Correo.Text, TiposValidos.Correo))
        {
            return;
        }
        MessageBox.Show("Todos los campos son válidos.", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}