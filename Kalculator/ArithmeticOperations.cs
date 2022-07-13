using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculator
{
    internal class ArithmeticOperations
    {
        private TextBox enterBox;
        private TextBox historyBox;
        private TextBox memoryBox;
        private Window window;

        private string action;
        private string savedResult = "0";
        private string equalsAction;
        private string equalsSavedResult = "0";
        public ArithmeticOperations(TextBox enterBox, TextBox historyBox, TextBox memoryBox, Window window) {
            this.enterBox = enterBox;
            this.historyBox = historyBox;
            this.memoryBox = memoryBox;
            this.window = window;
        }

        public void basicOperations(Button button) {
            if (window.getIsNewNum() && historyBox.Text != "") {

                char ch = historyBox.Text.Last();
                if (ch == '+' || ch == '-' || ch == '*' || ch == '/') {
                    //change sign
                    historyBox.Text = historyBox.Text.Remove(historyBox.Text.Length-1, 1) + button.Text;
                } else {
                    historyBox.Text = historyBox.Text + " " + button.Text;
                    calculateBasicOperations();
                }

            } else {
                historyBox.Text = historyBox.Text + " " + Convert.ToString(Convert.ToDouble(enterBox.Text)) + " " + button.Text;
                calculateBasicOperations();
            }

            action = button.Text;
            savedResult = enterBox.Text;
            window.setIsNewNum(true);
        }
        public void equals() {
            if (historyBox.Text != "") {
                equalsSavedResult = enterBox.Text;
                equalsAction = action;
            } else {
                savedResult = equalsSavedResult;
                action = equalsAction;
            }
            calculateBasicOperations();
            action = "";
            savedResult = "0";
            historyBox.Text = "";
            window.setIsNewNum(true);
        }
        public void squareRoot() {
            double num;
            num = Convert.ToDouble(enterBox.Text);

            del();

            recursiveFunction("sqrt");

            num = Math.Sqrt(num);
            enterBox.Text = Convert.ToString(num);
            window.setIsNewNum(true);
        }
        public void reciproc() {
            double num;
            num = Convert.ToDouble(enterBox.Text);

            del();

            recursiveFunction("reciproc");

            if (num == 0) {
                enterBox.Text = "Деление на ноль невозможно";
                return;
            }
            num = 1 / num;
            enterBox.Text = Convert.ToString(num);
        }
        public void negate() {
            double num;
            num = Convert.ToDouble(enterBox.Text);

            num *= -1;

            enterBox.Text = Convert.ToString(num);
            if (historyBox.Text != "" && historyBox.Text.Last() == ')') {
                recursiveFunction("negate");
            }
        }
        public void percent() {
            double num1, num2, result;
            num1 = Convert.ToDouble(savedResult);
            num2 = Convert.ToDouble(enterBox.Text);

            result = num1 / 100 * num2;

            enterBox.Text = Convert.ToString(result);
            del();
            historyBox.Text = historyBox.Text + " " + enterBox.Text;
            window.setIsNewNum(true);
        }

        private void calculateBasicOperations() {
            double num1, num2, result;
            num1 = Convert.ToDouble(savedResult);
            num2 = Convert.ToDouble(enterBox.Text);
            result = num2;

            if (action == "+") {
                result = num1 + num2;
            }
            if (action == "-") {
                result = num1 - num2;
            }
            if (action == "*") {
                result = num1 * num2;
            }
            if (action == "/") {
                if (num2 == 0) {
                    enterBox.Text = "Деление на ноль невозможно";
                    return;
                }
                result = num1 / num2;
            }
            enterBox.Text = Convert.ToString(result);
        }
        private void recursiveFunction(string function) {
            if (historyBox.Text != "" && historyBox.Text.Last() == ')') {
                historyBox.Text = historyBox.Text.Insert(historyBox.Text.LastIndexOf(" ")+1, function+"(") + ")";
            } else {
                historyBox.Text = historyBox.Text + " " + function + "(" + Convert.ToString(Convert.ToDouble(enterBox.Text)) + ")";
            }
        }
        private void del() {

            if (historyBox.Text != "") {
                char ch = historyBox.Text.Last();
                if (!(ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == ')'))  {
                    historyBox.Text = historyBox.Text.Remove(historyBox.Text.LastIndexOf(" "));
                }
            }
        }

        public string getAction() {
            return action;
        }
        public string getSavedResult() {
            return savedResult;
        }
        public void setAction(string action) {
            this.action = action;
        }
        public void setSavedResult(string savedResult) {
            this.savedResult = savedResult;
        }
    }
}
