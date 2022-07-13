using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator
{
    internal class EnterButtons
    {
        private TextBox enterBox;
        private TextBox historyBox;
        private TextBox memoryBox;
        private Window window;
        public EnterButtons(TextBox enterBox, TextBox historyBox, TextBox memoryBox, Window window)
        {
            this.enterBox = enterBox;
            this.historyBox = historyBox;
            this.memoryBox = memoryBox;
            this.window = window;
        }

        public void numbers(Button button) {
            if (window.getIsNewNum()) {

                if (historyBox.Text != "") {
                    char ch = historyBox.Text.Last();
                    if (!(ch == '+' || ch == '-' || ch == '*' || ch == '/')) {
                        historyBox.Text = historyBox.Text.Remove(historyBox.Text.LastIndexOf(" "));
                    }
                }

                enterBox.Text = "";
                window.setIsNewNum(false);
            }

            if (enterBox.Text == "0") {
                enterBox.Text = button.Text;
            } else {
                enterBox.Text = enterBox.Text + button.Text;
            }
        }
        public void floatingPoint() {
            if (!enterBox.Text.Contains(",")) {
                enterBox.Text = enterBox.Text + ",";
            }
        }
    }
}
