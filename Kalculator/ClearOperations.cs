using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator
{
    internal class ClearOperations
    {
        private TextBox enterBox;
        private TextBox historyBox;
        private TextBox memoryBox;
        private Window window;
        private ArithmeticOperations arithmetic;
        public ClearOperations(TextBox enterBox, TextBox historyBox, TextBox memoryBox, Window window, ArithmeticOperations arithmetic) {
            this.enterBox = enterBox;
            this.historyBox = historyBox;
            this.memoryBox = memoryBox;
            this.window = window;
            this.arithmetic = arithmetic;
        }

        public void backSpace() {
            if (!window.getIsNewNum()) {
                enterBox.Text = enterBox.Text.Remove(enterBox.Text.Length-1);
                if (enterBox.Text == "") {
                    enterBox.Text = "0";
                }
            }
        }
        public void clearEntry() {
            enterBox.Text = "0";
        }
        public void clear() {
            arithmetic.setAction("");
            arithmetic.setSavedResult("0");
            window.setIsNewNum(false);
            enterBox.Text ="0";
            historyBox.Text = "";
        }
    }
}
