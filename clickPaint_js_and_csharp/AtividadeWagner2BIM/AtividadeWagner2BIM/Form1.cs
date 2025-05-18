/** Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: DD/MM/2020
 * Autores do Projeto: Rodrigo Roda Oliveto Alves
 *                     Thiago César Carvalho
 *                     Thiago Alexander Moreira Mancilla
 *                     Natan Soares Telles
 *   
 * Turma: 3H
 * Atividade Proposta em aula
 * ******************************************************************/

namespace AtividadeWagner2BIM
{
    public partial class Form1 : Form
    {
        bool click = false;
        bool retangulo_bool = false;
        Pen caneta = new Pen(Color.FromArgb(0, 0, 0));
        int[] point = new int[4];
        int altura, largura;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            iniciarCbBox();

        }

        void iniciarCbBox()
        {
            comboBox1.Items.Add("Nenhuma");
            comboBox1.Items.Add("Linha Sólida");
            comboBox1.Items.Add("Linha Tracejada");
            comboBox1.Items.Add("Linha Traço Ponto");
            comboBox1.Items.Add("Linha Traço Dois Pontos");
            comboBox1.Items.Add("Linha Pontilhada");

            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
        }

        public Color cor(int r, int g, int b)
        {
            return Color.FromArgb(r, g, b);
        }
        public Pen caneta_estilo(int espessura, Color cor, float[] estilo = null)
        {
            Pen caneta = new Pen(cor, espessura);
            if (estilo != null) caneta.DashPattern = estilo;
            return caneta;
        }

        public void reta(int x0, int y0, int x1, int y1, Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }

        public void retangulo(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen caneta)
        {
            reta(x0, y0, x1, y0, caneta, e);
            reta(x1, y0, x1, y1, caneta, e);
            reta(x1, y1, x0, y1, caneta, e);
            reta(x0, y1, x0, y0, caneta, e);
        }

        string EquacaoDaReta(int[] point)
        {
            if (point[0] == point[2])
            {
                return $"x = {point[0]}";
            }

            double m = (double)(point[3] - point[1]) / (point[2] - point[0]);
            double b = point[1] - m * point[0];

            string mStr = m.ToString("0.##");  // Formatar com até 2 casas decimais
            string bStr = b >= 0 ? $"+ {b:0.##}" : $"- {Math.Abs(b):0.##}";

            return $"f(x) = {mStr}x {bStr}";
        }

        double ComprimentoReta(int[] point)
        {
            return Math.Sqrt(Math.Pow((point[2] - point[0]), 2) + Math.Pow((point[3] - point[1]), 2));
        }

        float[] setStyle()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                return null;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                return null;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                return new float[] { 4f, 2f };
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                return new float[] { 4f, 2f, 1f, 2f };
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                return new float[] { 4f, 2f, 1f, 2f, 1f, 2f };
            }
            else
            {
                return new float[] { 1f, 2f };
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float[] estilo = setStyle();
            Pen caneta = caneta_estilo((int)numericUpDown1.Value, cor(255, 0, 0), estilo);
            if (!retangulo_bool)
            {
                reta(point[0], point[1], point[2], point[3], caneta, e);
                label1.Text = $"Função Afim: {EquacaoDaReta(point)}";
                label2.Text = $"Comprimento da Reta: {ComprimentoReta(point).ToString("F2")}px";
            }
            else
            {
                retangulo_bool = false;
                retangulo(e, point[0], point[1], point[0] + largura, point[1] + altura, caneta);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!click)
            {
                click = true;
                point[0] = e.X; point[1] = e.Y;

                if(txtBox_altura.Text != "" && txtBox_largura.Text != "")
                {
                    if(int.TryParse(txtBox_altura.Text, out altura) && int.TryParse(txtBox_largura.Text, out largura)){
                        retangulo_bool = true;
                        Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("Valores inválidos para altura e/ou largura");
                    }
                }
            }
            else if (click)
            {
                click = false;
                point[2] = e.X; point[3] = e.Y;
                Invalidate();
            }
        }
    }
}
