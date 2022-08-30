namespace Ejercicio1_parcial
{
    public partial class Form1 : Form
    {
        Empresa empresa;
        public Form1()
        {
            InitializeComponent();
            empresa = new Empresa(5);
            empresa.CrearLista();
            for (int i = 0; i < 5; i++)
            {
                comboBox1.Items.Add(empresa.VerNombreVendedor(i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta fn = new Venta();
            if(fn.ShowDialog() == DialogResult.OK)
            {
                empresa.AgregarVenta(comboBox1.SelectedIndex, Convert.ToDouble(fn.textBox1.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(empresa.VerDatoVendedor(i));
            }
        }
    }
}