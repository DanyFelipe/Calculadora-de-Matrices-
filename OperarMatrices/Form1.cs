using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OperarMatrices
{
    public partial class Form1 : Form
    {
        int[,] matriz_A;
        int[,] matriz_B;
        int[,] matrizT_A;
        int[,] matrizT_B;
        int[,] matrizT_C;
        bool m_a = false;
        bool m_b = false;
        public Form1()
        {
            InitializeComponent();
            comboBox_opc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_A.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_B.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public String Determinante(int[,] matriz)
        {
            int determ;

            if (matriz.GetLength(0) == 2 && matriz.GetLength(1) == 2)
            {
                determ = (matriz[0, 0] * matriz[1, 1]) - (matriz[1, 0] * matriz[0, 1]);
            }
            else if (matriz.GetLength(0) == 3 && matriz.GetLength(1) == 3)
            {
                determ = (matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) + (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) + (matriz[1, 0] * matriz[2, 1] * matriz[0, 2])
                   - (matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) - (matriz[1, 0] * matriz[0, 1] * matriz[2, 2]) - (matriz[1, 2] * matriz[2, 1] * matriz[0, 0]);
            }
            else
            {
                return "Determinante: No aplica";
            }
            return "Determiante: " + determ;
        }

        public String Transpuesta_A(int[,] matriz, int n_filas, int n_columnas)
        {
            matrizT_A = new int[n_columnas, n_filas];
            String print_matrizT = "";

            for (int i = 0; i < n_filas; i++)
            {
                for (int j = 0; j < n_columnas; j++)
                {
                    matrizT_A[j, i] = matriz[i, j];
                }
            }

            for (int i = 0; i < n_columnas; i++)
            {
                print_matrizT += " | ";
                for (int j = 0; j < n_filas; j++)
                {
                    print_matrizT += matriz[j, i];
                    print_matrizT += " | ";
                }
                print_matrizT += "\n";
            }

            return print_matrizT;
        }

        public String Transpuesta_B(int[,] matriz, int n_filas, int n_columnas)
        {
            matrizT_B = new int[n_columnas, n_filas];
            String print_matrizT = "";

            for (int i = 0; i < n_filas; i++)
            {
                for (int j = 0; j < n_columnas; j++)
                {
                    matrizT_B[j, i] = matriz[i, j];
                }
            }

            for (int i = 0; i < n_columnas; i++)
            {
                print_matrizT += " | ";
                for (int j = 0; j < n_filas; j++)
                {
                    print_matrizT += matriz[j, i];
                    print_matrizT += " | ";
                }
                print_matrizT += "\n";
            }

            return print_matrizT;
        }

        public String Transpuesta_C(int[,] matriz)
        {
            matrizT_C = new int[matriz.GetLength(1), matriz.GetLength(0)];
            String print_matrizT = "";

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizT_C[j, i] = matriz[i, j];
                }
            }

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                print_matrizT += " | ";
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    print_matrizT += matriz[j, i];
                    print_matrizT += " | ";
                }
                print_matrizT += "\n";
            }
            return print_matrizT;
        }
        public void button_manual_Click(object sender, EventArgs e)
        {
            String matriz = "";
            int num_columnas;
            int num_filas;

            try
            {
                num_columnas = int.Parse(txt_columnas.Text);
                num_filas = int.Parse(txt_filas.Text);
                matriz_A = new int[num_filas, num_columnas];

                //---------------- MATRIZ NORMAL --------------------------
                try
                {
                    for (int i = 0; i < num_filas; i++)
                    {
                        matriz += " | ";
                        for (int j = 0; j < num_columnas; j++)
                        {
                            matriz_A[i, j] = int.Parse(Interaction.InputBox("Fila " + i + " Columna " + j + "", "Ingrese los datos", ""));
                            matriz += matriz_A[i, j];
                            matriz += " | ";
                        }
                        matriz += "\n";
                    }
                    print_labelMatriz.Text = matriz;
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite todos los números", "Error");
                }
                //--------------- MATRIZ TRANSPUESTA -----------------------	

                print_labelMatrizT.Text = Transpuesta_A(matriz_A, num_filas, num_columnas);

                //------------------------ DETERMINANTES -------------------

                label_det1.Text = Determinante(matriz_A);

                m_b = true;

                if (m_b == true && m_a == true)
                {
                    comboBox_opc.Enabled = true;
                }
                m_a = true;

                if (m_b == true && m_a == true)
                {
                    comboBox_opc.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }
        private void txt_filas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_filas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txt_columnas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void button_azar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String matrizR = "";
            String matrizRT = "";
            int num_columnas;
            int num_filas;
            try
            {
                num_columnas = int.Parse(txt_columnas.Text);
                num_filas = int.Parse(txt_filas.Text);
                matriz_A = new int[num_filas, num_columnas];

                //------------------- MATRIZ NORMAL -------------------------
                for (int i = 0; i < num_filas; i++)
                {
                    matrizR += " | ";
                    for (int j = 0; j < num_columnas; j++)
                    {
                        matriz_A[i, j] = rnd.Next(0, 100);
                        matrizR += matriz_A[i, j];
                        matrizR += " | ";
                    }
                    matrizR += "\n";
                }
                print_labelMatriz.Text = matrizR;

                //--------------- MATRIZ TRANSPUESTA -----------------------

                print_labelMatrizT.Text = Transpuesta_A(matriz_A, num_filas, num_columnas);

                //------------------------ DETERMINANTES -------------------

                label_det1.Text = Determinante(matriz_A);

                m_b = true;

                if (m_b == true && m_a == true)
                {
                    comboBox_opc.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }

        private void button_manual2_Click(object sender, EventArgs e)
        {
            String matriz = "";
            int num_columnas;
            int num_filas;

            try
            {
                num_columnas = int.Parse(txt_columnas2.Text);
                num_filas = int.Parse(txt_filas2.Text);
                matriz_B = new int[num_filas, num_columnas];

                //---------------- MATRIZ NORMAL --------------------------
                try
                {
                    for (int i = 0; i < num_filas; i++)
                    {
                        matriz += " | ";
                        for (int j = 0; j < num_columnas; j++)
                        {
                            matriz_B[i, j] = int.Parse(Interaction.InputBox("Fila " + i + " Columna " + j + "", "Ingrese los datos", ""));
                            matriz += matriz_B[i, j];
                            matriz += " | ";
                        }
                        matriz += "\n";
                    }
                    print_labelMatriz2.Text = matriz;
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite todos los números", "Error");
                }
                //--------------- MATRIZ TRANSPUESTA -----------------------	

                print_labelMatrizT2.Text = Transpuesta_B(matriz_B, num_filas, num_columnas);

                //------------------------ DETERMINANTES -------------------

                label_det2.Text = Determinante(matriz_B);

                m_b = true;

                if (m_a = true && m_b == true)
                {
                    comboBox_opc.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }

        private void button_azar2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String matrizR = "";
            int num_columnas;
            int num_filas;

            try
            {
                num_columnas = int.Parse(txt_columnas2.Text);
                num_filas = int.Parse(txt_filas2.Text);
                matriz_B = new int[num_filas, num_columnas];

                //---------------- MATRIZ NORMAL --------------------------
                for (int i = 0; i < num_filas; i++)
                {
                    matrizR += " | ";
                    for (int j = 0; j < num_columnas; j++)
                    {
                        matriz_B[i, j] = rnd.Next(0, 100);
                        matrizR += matriz_B[i, j];
                        matrizR += " | ";
                    }
                    matrizR += "\n";
                }
                print_labelMatriz2.Text = matrizR;

                //--------------- MATRIZ TRANSPUESTA -----------------------

                print_labelMatrizT2.Text = Transpuesta_B(matriz_B, num_filas, num_columnas);

                //------------------------ DETERMINANTES -------------------

                label_det2.Text = Determinante(matriz_B);

                m_b = true;

                if (m_a = true && m_b == true)
                {
                    comboBox_opc.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }

        private void comboBox_opc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_opc.SelectedIndex >= 0)
            {
                radioButton_matriz.Enabled = true;
                radioButton_cons.Enabled = true;
            }
        }

        private void comboBox_A_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_A.SelectedIndex >= 0)
            {
                if (radioButton_cons.Checked)
                {
                    comboBox_B.Enabled = false;
                    button_calcular.Enabled = true;
                }
                else if (radioButton_matriz.Checked)
                {
                    comboBox_B.Enabled = true;
                }
            }
        }

        private void comboBox_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_B.SelectedIndex >= 0)
            {
                if (radioButton_cons.Checked)
                {
                    comboBox_A.Enabled = false;
                    button_calcular.Enabled = true;
                }
                else if (radioButton_matriz.Checked)
                {
                    button_calcular.Enabled = true;
                }
            }
        }

        private void txt_filas2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_filas2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_columnas2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            //--------------------------------------- SUMA
            if (comboBox_opc.SelectedIndex == 0)
            {
                if (radioButton_A.Checked) //-------SUMA CONSTANTE A
                {
                    print_labelMatriz3.Text = Suma_cons(matriz_A);
                }
                else if (radioButton_B.Checked) //-------SUMA CONSTANTE B
                {
                    print_labelMatriz3.Text = Suma_cons(matriz_B);
                }
                if (matriz_A.GetLength(0) == matriz_B.GetLength(0) && matriz_A.GetLength(1) == matriz_B.GetLength(1))
                {
                    if (comboBox_A.SelectedIndex == 1 && comboBox_B.SelectedIndex == 1)
                    {
                        print_labelMatriz3.Text = Suma(matrizT_A, matrizT_B);
                    }
                    else if (comboBox_A.SelectedIndex == 0 && comboBox_B.SelectedIndex == 1)
                    {
                        print_labelMatriz3.Text = Suma(matriz_A, matrizT_B);
                    }
                    else if (comboBox_A.SelectedIndex == 1 && comboBox_B.SelectedIndex == 0)
                    {
                        print_labelMatriz3.Text = Suma(matrizT_A, matriz_B);
                    }
                    else if (comboBox_A.SelectedIndex == 0 && comboBox_B.SelectedIndex == 0)
                    {
                        print_labelMatriz3.Text = Suma(matriz_A, matriz_B);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede Sumar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //---------------------------------------- RESTA
            else if (comboBox_opc.SelectedIndex == 1)
            {
                if (radioButton_A.Checked) //-------RESTA CONSTANTE A
                {
                    print_labelMatriz3.Text = Resta_cons(matriz_A);
                }
                else if (radioButton_B.Checked) //-------RESTA CONSTANTE B
                {
                    print_labelMatriz3.Text = Resta_cons(matriz_B);
                }
                if (matriz_A.GetLength(0) == matriz_B.GetLength(0) && matriz_A.GetLength(1) == matriz_B.GetLength(1))
                {
                    if (comboBox_A.SelectedIndex == 1 && comboBox_B.SelectedIndex == 1)
                    {
                        print_labelMatriz3.Text = Resta(matrizT_A, matrizT_B);
                    }
                    else if (comboBox_A.SelectedIndex == 0 && comboBox_B.SelectedIndex == 1)
                    {
                        print_labelMatriz3.Text = Resta(matriz_A, matrizT_B);
                    }
                    else if (comboBox_A.SelectedIndex == 1 && comboBox_B.SelectedIndex == 0)
                    {
                        print_labelMatriz3.Text = Resta(matrizT_A, matriz_B);
                    }
                    else if (comboBox_A.SelectedIndex == 0 && comboBox_B.SelectedIndex == 0)
                    {
                        print_labelMatriz3.Text = Resta(matriz_A, matriz_B);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede Restar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //---------------------------------------- MULTIPLICACIÓN
            else if (comboBox_opc.SelectedIndex == 2)
            {
                if (matriz_A.GetLength(1) == matriz_B.GetLength(0) && matrizT_A.GetLength(1) == matrizT_B.GetLength(0))
                {
                    if (radioButton_A.Checked) //-------MULTIPLICAR CONSTANTE A
                    {
                        print_labelMatriz3.Text = Multiplicacion_cons(matriz_A);
                    }
                    else if (radioButton_B.Checked) //-------MULTIPLICAR CONSTANTE B
                    {
                        print_labelMatriz3.Text = Multiplicacion_cons(matriz_B);
                    }
                    if (comboBox_A.SelectedIndex == 1 && comboBox_B.SelectedIndex == 1)
                    {
                        print_labelMatriz3.Text = Multiplicacion(matrizT_A, matrizT_B);
                    }
                    else if (comboBox_A.SelectedIndex == 0 && comboBox_B.SelectedIndex == 1)
                    {
                        print_labelMatriz3.Text = Multiplicacion(matriz_A, matrizT_B);
                    }
                    else if (comboBox_A.SelectedIndex == 1 && comboBox_B.SelectedIndex == 0)
                    {
                        print_labelMatriz3.Text = Multiplicacion(matrizT_A, matriz_B);
                    }
                    else if (comboBox_A.SelectedIndex == 0 && comboBox_B.SelectedIndex == 0)
                    {
                        print_labelMatriz3.Text = Multiplicacion(matriz_A, matriz_B);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede multiplicar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            comboBox_A.SelectedIndex = -1;
            comboBox_B.SelectedIndex = -1;
        }

        public String Suma(int[,] matrizA, int[,] matrizB)
        {
            int[,] matriz_suma;
            matriz_suma = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
            String matrizR = "";

            if (matrizA.GetLength(0) == matrizB.GetLength(0))
            {
                for (int i = 0; i < matriz_suma.GetLength(0); i++)
                {
                    matrizR += " | ";
                    for (int j = 0; j < matriz_suma.GetLength(1); j++)
                    {
                        matriz_suma[i, j] = matrizA[i, j] + matrizB[i, j];
                        matrizR += matriz_suma[i, j];
                        matrizR += " | ";
                    }
                    matrizR += "\n";
                }
                label_det3.Text = Determinante(matriz_suma);
                print_labelMatrizT3.Text = Transpuesta_C(matriz_suma);
            }
            else
            {
                MessageBox.Show("No se puede Sumar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            return matrizR;
        }
        public String Suma_cons(int[,] matriz)
        {
            int[,] matriz_sumaCons;
            String matrizR = "";
            int cons;
            cons = int.Parse(Interaction.InputBox("Constante que Sumará la matríz", "Ingrese los datos", ""));
            matriz_sumaCons = new int[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matrizR += " | ";
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz_sumaCons[i, j] += matriz[i, j] + cons;
                    matrizR += matriz_sumaCons[i, j];
                    matrizR += " | ";
                }
                matrizR += "\n";
            }
            label_det3.Text = Determinante(matriz_sumaCons);
            print_labelMatrizT3.Text = Transpuesta_C(matriz_sumaCons);
            return matrizR;
        }

        public String Resta(int[,] matrizA, int[,] matrizB)
        {
            int[,] matriz_resta;
            matriz_resta = new int[matrizA.GetLength(0), matrizA.GetLength(1)];
            String matrizR = "";

            for (int i = 0; i < matriz_resta.GetLength(0); i++)
            {
                matrizR += " | ";
                for (int j = 0; j < matriz_resta.GetLength(1); j++)
                {
                    matriz_resta[i, j] = matrizA[i, j] - matrizB[i, j];
                    matrizR += matriz_resta[i, j];
                    matrizR += " | ";
                }
                matrizR += "\n";
            }
            label_det3.Text = Determinante(matriz_resta);
            print_labelMatrizT3.Text = Transpuesta_C(matriz_resta);
            return matrizR;
        }
        public String Resta_cons(int[,] matriz)
        {
            int[,] matriz_restaCons;
            String matrizR = "";
            int cons;
            cons = int.Parse(Interaction.InputBox("Constante que Restará la matríz", "Ingrese los datos", ""));
            matriz_restaCons = new int[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matrizR += " | ";
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz_restaCons[i, j] += matriz[i, j] - cons;
                    matrizR += matriz_restaCons[i, j];
                    matrizR += " | ";
                }
                matrizR += "\n";
            }
            label_det3.Text = Determinante(matriz_restaCons);
            print_labelMatrizT3.Text = Transpuesta_C(matriz_restaCons);
            return matrizR;
        }

        public String Multiplicacion(int[,] matrizA, int[,] matrizB)
        {
            int[,] matriz_multi;
            matriz_multi = new int[matrizA.GetLength(0), matrizB.GetLength(1)];
            String matrizR = "";

            try
            {
                for (int i = 0; i < matrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizB.GetLength(1); j++)
                    {
                        for (int h = 0; h < matrizB.GetLength(0); h++)
                        {
                            matriz_multi[i, j] += matrizA[i, h] * matriz_B[h, j];
                        }
                    }
                }

                for (int i = 0; i < matriz_multi.GetLength(0); i++)
                {
                    matrizR += " | ";
                    for (int j = 0; j < matriz_multi.GetLength(1); j++)
                    {
                        matrizR += matriz_multi[i, j];
                        matrizR += " | ";
                    }
                    matrizR += "\n";
                }
                label_det3.Text = Determinante(matriz_multi);
                print_labelMatrizT3.Text = Transpuesta_C(matriz_multi);
                return matrizR;
            }
            catch(Exception)
            {
                MessageBox.Show("Acción aún no implementada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
        }
        public String Multiplicacion_cons(int[,] matriz)
        {
            int[,] matriz_multiCons;
            String matrizR = "";
            int cons;
            cons = int.Parse(Interaction.InputBox("Constante que multiplicará la matríz", "Ingrese los datos", ""));
            matriz_multiCons = new int[matriz.GetLength(0), matriz.GetLength(1)];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matrizR += " | ";
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz_multiCons[i, j] += matriz[i, j] * cons;
                    matrizR += matriz_multiCons[i, j];
                    matrizR += " | ";
                }
                matrizR += "\n";
            }
            label_det3.Text = Determinante(matriz_multiCons);
            print_labelMatrizT3.Text = Transpuesta_C(matriz_multiCons);
            return matrizR;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void radioButton_matriz_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_A.Enabled = true;
            comboBox_B.Enabled = true;
            radioButton_A.Enabled = false;
            radioButton_B.Enabled = false;
        }

        private void radioButton_cons_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_A.Enabled = true;
            radioButton_B.Enabled = true;
            comboBox_A.Enabled = false;
            comboBox_B.Enabled = false;
        }

        private void radioButton_A_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_A.Checked)
            {
                button_calcular.Enabled = true;
            }
        }

        private void radioButton_B_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_B.Checked)
            {
                button_calcular.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
