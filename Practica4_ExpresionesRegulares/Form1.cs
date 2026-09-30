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
}