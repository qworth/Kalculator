using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator
{
    public partial class Window : Form
    {
        private MemoryOperations memoryOperations;
        private ClearOperations clearOperations;
        private EnterButtons enterButtons;
        private ArithmeticOperations arithmeticOperations;

        private bool isNewNum = false;
        public Window()
        {
            InitializeComponent();
            memoryOperations = new MemoryOperations(textBox1, textBox2, textBox3, this);
            arithmeticOperations = new ArithmeticOperations(textBox1, textBox2, textBox3, this);
            clearOperations = new ClearOperations(textBox1, textBox2, textBox3, this, arithmeticOperations);
            enterButtons = new EnterButtons(textBox1, textBox2, textBox3, this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            memoryOperations.memoryClear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            enterButtons.numbers(button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearOperations.clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearOperations.clearEntry();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            arithmeticOperations.basicOperations(button);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            arithmeticOperations.equals();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            arithmeticOperations.squareRoot();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            arithmeticOperations.reciproc();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            arithmeticOperations.negate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearOperations.backSpace();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            arithmeticOperations.percent();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            enterButtons.floatingPoint();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            memoryOperations.memorySave();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            memoryOperations.memoryRead();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            memoryOperations.memoryPlus();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            memoryOperations.memoryMinus();
        }

        public bool getIsNewNum() {
            return isNewNum;
        }
        public void setIsNewNum(bool isNewNum) {
            this.isNewNum = isNewNum;
        }

        private void Window_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0)
            {
                button25_Click(button28, null);
            }
            if (e.KeyChar == (char)Keys.D1)
            {
                button25_Click(button25, null);
            }
            if (e.KeyChar == (char)Keys.D2)
            {
                button25_Click(button24, null);
            }
            if (e.KeyChar == (char)Keys.D3)
            {
                button25_Click(button23, null);
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                button25_Click(button20, null);
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                button25_Click(button19, null);
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                button25_Click(button18, null);
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                button25_Click(button15, null);
            }
            if (e.KeyChar == (char)Keys.D8)
            {
                button25_Click(button14, null);
            }
            if (e.KeyChar == (char)Keys.D9)
            {
                button25_Click(button13, null);
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                button10_Click(button10, null);
            }
            /*if (e.KeyChar == (char)0x7F)
            {
                button9_Click(button9, null);
            }*/

            if (e.KeyChar == (char)0x2C || e.KeyChar == (char)0x2E)
            {
                button27_Click(button27, null);
            }

            if (e.KeyChar == (char)0x2B)
            {
                button26_Click_1(button26, null);
            }
            if (e.KeyChar == (char)0x2D)
            {
                button26_Click_1(button22, null);
            }
            if (e.KeyChar == (char)0x2A)
            {
                button26_Click_1(button17, null);
            }
            if (e.KeyChar == (char)0x2F)
            {
                button26_Click_1(button12, null);
            }
            if (e.KeyChar == (char)0x25)
            {
                button11_Click(button11, null);
            }


            if (e.KeyChar == (char)0x3D)
            {
                button21_Click(button21, null);
            }
        }
    }
}
