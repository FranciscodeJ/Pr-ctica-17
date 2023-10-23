namespace Práctica_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;                                     //Se declaran las variables a usar.
            A=int.Parse(textBox1.Text);                    //Se declara que en las cajas 1, 2 y 3 escribiremos los valores A, B y C rescpectivamente.      
            B=int.Parse(textBox2.Text);
            C=int.Parse(textBox3.Text);                
            if(A>B)                                        //Se aplica un condicional que activará varios condicionales.
                if(B>C)                                   // Si se cumple se activará otro que pregunte si B > C, y si es verdad, activará otro que pregunte B > C y así sucesivamente.
                    if(B>C)
                    { textBox4.Text = A.ToString();
                        textBox5.Text = B.ToString();
                        textBox6.Text = C.ToString();
                    }
                    else 
                    { textBox4.Text = A.ToString();
                        textBox5.Text = C.ToString(); 
                        textBox6.Text = B.ToString(); }
                else 
                { textBox4.Text = C.ToString();
                    textBox5.Text = A.ToString();
                    textBox6.Text = B.ToString(); }
            else                                           //Si no se cumpliera el condicional anterior, entonces se activaría este.
            if (B > C)
                if (A > C) 
                { textBox4.Text = B.ToString();
                    textBox5.Text = A.ToString();
                    textBox6.Text = C.ToString();
                } 
                else 
                { textBox4.Text = B.ToString();
                    textBox5.Text = C.ToString();
                    textBox6.Text = A.ToString();
                } else 
            { textBox4.Text = C.ToString();
                textBox5.Text = B.ToString(); 
                textBox6.Text = A.ToString(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";      //Se declara que al apretar el botón se elimine lo aparecido en caja 1 y 2.
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}