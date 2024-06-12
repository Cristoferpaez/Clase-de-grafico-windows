namespace Clase_de_grafico_windows
{
    public partial class Form1 : Form
    {
        Double valorResultado = 0;
        String operador = "";
        bool isOperador = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 1*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 4*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 7*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "7";
        }

        private void operador_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (valorResultado != 0)
            {
                btnIgual.PerformClick();
                operador = button.Text;
                label1.Text = valorResultado + " " + operador;
                isOperador = true;
            }
            else
            {

                operador = button.Text;
                valorResultado = Double.Parse(textBoxRESULTADO.Text);
                label1.Text = valorResultado + " " + operador;
                isOperador = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 2*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 3*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 5*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 6*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 8*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 9*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*corresponde al boton 0*/
            Button button = (Button)sender;
            textBoxRESULTADO.Text = textBoxRESULTADO.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operador)
            {

                case "+":
                    textBoxRESULTADO.Text = (valorResultado + Double.Parse(textBoxRESULTADO.Text)).ToString();
                    break;
                case "-":
                    textBoxRESULTADO.Text = (valorResultado - Double.Parse(textBoxRESULTADO.Text)).ToString();
                    break;
                case "*":
                    textBoxRESULTADO.Text = (valorResultado * Double.Parse(textBoxRESULTADO.Text)).ToString();
                    break;
                case "/":
                    textBoxRESULTADO.Text = (valorResultado / Double.Parse(textBoxRESULTADO.Text)).ToString();
                    break;
                default:
                    break;

            }

            valorResultado = Double.Parse(textBoxRESULTADO.Text);
            label1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
