namespace calculadoraMedi
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double nota1, nota2, nota3, nota4;

            nota1 = double.Parse(txtN1.Text);
            nota2 = double.Parse(txtN2.Text);
            nota3 = double.Parse(txtN3.Text);
            nota4 = double.Parse(txtN4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            txtMedia.Text = "a sua média é " + media;

            //////////////////////////////////

            if (media >= 0 && media < 4)
            {
                lblSituation.Text = "reprovado!";
                lblSituation.ForeColor = Color.Red;
            };


            if (media >= 4 && media < 6)
            {
                lblSituation.Text = "exame!";
                lblSituation.ForeColor = Color.Yellow;
            };

            if (media >= 6 && media <= 10)
            {
                lblSituation.Text = "Aprovado !";
                lblSituation.ForeColor = Color.Green;
            };

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblSituation.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
        }
    }
}