using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator
{
    internal class MemoryOperations
    {
        private TextBox enterBox;
        private TextBox historyBox;
        private TextBox memoryBox;
        private Window window;

        private string savedMemory = "0";
        public MemoryOperations(TextBox enterBox, TextBox historyBox, TextBox memoryBox, Window window) {
            this.enterBox = enterBox;
            this.historyBox = historyBox;
            this.memoryBox = memoryBox;
            this.window = window;
        }

        public void memorySave() {
            if (enterBox.Text == "Деление на ноль невозможно") {
                return;
            }
            window.setIsNewNum(true);
            savedMemory = Convert.ToString(Convert.ToDouble(enterBox.Text));
            memoryBox.Text = "M";
            checkZero();
        }
        public void memoryRead() {
            enterBox.Text = savedMemory;
        }
        public void memoryClear() {
            savedMemory = "0";
            memoryBox.Text = "";
        }
        public void memoryPlus() {
            savedMemory = Convert.ToString(Convert.ToDouble(savedMemory) + Convert.ToDouble(enterBox.Text));
            checkZero();
        }
        public void memoryMinus() {
            savedMemory = Convert.ToString(Convert.ToDouble(savedMemory) - Convert.ToDouble(enterBox.Text));
            checkZero();
        }

        private void checkZero() {
            if (savedMemory == "0") {
                memoryBox.Text = "";
            }
        }
    }
}
