using System.Text.RegularExpressions;

namespace Ex2
{
    public partial class MainForm : Form
    {
        private List<string> calculationResult = new();
        private bool scopeOpened = false;
        private List<ApplicationState> states = new();
        private readonly string filePath = "saves.bin";
        public MainForm()
        {
            InitializeComponent();
            UpdateUploadList();
        }

        private static int Compare(int first, int second)
        {
            if (first == -1 && second == -1) { return -1; }
            if (first == -1 || second == -1)
            {
                return first == -1 ? second : first;
            }
            return first < second ? first : second;
        }

        private string GetFirstOperationIndex(List<string> question)
        {
            string[] operations = { "^ ^", "* /", "+ -" };

            if (question.IndexOf("(") != -1)
            {
                return $"{question.IndexOf("(")} " +
                    $"{question.FindIndex(question.IndexOf("("), item => item == ")")}";
            }
            foreach (string operation in operations)
            {
                int compareResult = Compare(question.IndexOf(operation.Split(' ')[0]),
                        question.IndexOf(operation.Split(' ')[1]));
                if (compareResult != -1) { return compareResult.ToString(); }
            }
            return "";
        }

        private List<string> Calculate(List<string> question)
        {
            if (question.Count == 1) { return question; }
            if (question.Count == 3)
            {
                List<string> result = new();
                switch (question[1])
                {
                    case "*":
                        result.Add($"{float.Parse(question[0]) * float.Parse(question[2])}");
                        return result;
                    case "/":
                        result.Add($"{float.Parse(question[0]) / float.Parse(question[2])}");
                        return result;
                    case "+":
                        result.Add($"{float.Parse(question[0]) + float.Parse(question[2])}");
                        return result;
                    case "-":
                        result.Add($"{float.Parse(question[0]) - float.Parse(question[2])}");
                        return result;
                    case "^":
                        result.Add($"{Math.Pow(float.Parse(question[0]), float.Parse(question[2]))}");
                        return result;
                    default:
                        return result;
                }
            }
            else
            {
                string[] calculationIndexResult = GetFirstOperationIndex(question).Split(" ");
                if (calculationIndexResult.Length == 2)
                {
                    int startIndex = int.Parse(calculationIndexResult[0]) + 1;
                    int count = int.Parse(calculationIndexResult[1]) - startIndex;
                    List<string> operationResult = Calculate(question.GetRange(startIndex, count));
                    question.RemoveRange(startIndex - 1, count + 2);
                    question.InsertRange(startIndex - 1, operationResult);
                    if (question.Count != 1)
                        return Calculate(question);
                    else return calculationResult;
                }
                else
                {
                    int operationIndex = int.Parse(calculationIndexResult[0]);
                    List<string> operationResult = Calculate(question.GetRange(operationIndex - 1, 3));
                    question.RemoveRange(operationIndex - 1, 3);
                    question.InsertRange(operationIndex - 1, operationResult);
                    if (question.Count != 1)
                    {
                        calculationResult = Calculate(question);
                        return calculationResult;
                    }
                    else
                    {
                        return calculationResult;
                    }
                }
            }
        }

        private List<string> CreateListFromString(string input)
        {
            List<string> outputList = new();
            string number = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) || input[i] == ',' || input[i] == '-' && (i == 0 || !char.IsDigit(input[i - 1])))
                {
                    number += input[i];
                }
                else
                {
                    if (number != "")
                    {
                        outputList.Add(number);
                        number = "";
                    }
                    outputList.Add($"{input[i]}");
                }
            }
            if (number != "") outputList.Add(number);
            return outputList;
        }

        private static string ParseInput(string input)
        {
            Dictionary<string, string> verbalOperators = new() {
                {"плюс", "+"},
                {"додати", "+"},
                {"мінус", "-"},
                {"відняти", "-"},
                {"\u2212", "-"},
                {"помножити на", "*"},
                {"\u00d7", "*"},
                {"поділити на", "/"},
                {"\u00f7", "/"},
                {"в степені", "^" },
                {"точка", ","},
                {"кома", ","},
                {" ", "" },
                {".", ","}
            };
            foreach (string key in verbalOperators.Keys)
            {
                input = input.Replace(key, verbalOperators[key]);
            }
            input = Regex.Replace(input, @"(\d|\))\s*\(", "$1*(");
            return input;
        }

        private void CalculateInput(string input)
        {
            if (double.TryParse(input, out double num)
                || input.Trim() == "") return;
            string textToCalculate = ParseInput(input);
            try
            {
                inputField.Text = Math.Round(float.Parse(Calculate(CreateListFromString(textToCalculate))[0]), 2).ToString();
                inputField.SelectionStart = inputField.TextLength;
            }
            catch
            {
                MessageBox.Show($"Помилка при обчисленні", "Увага", MessageBoxButtons.OK);
            }
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateInput(inputField.Text);
        }

        private void numAndOperationButtons_Click(object sender, EventArgs e)
        {
            int cursorPosition = inputField.SelectionStart;
            if (sender is Button clickedButton)
            {
                inputField.Text = inputField.Text.Insert(cursorPosition, clickedButton.Text);
                inputField.SelectionStart = cursorPosition + 1;
            }

        }

        private void bracketsButton_Click(object sender, EventArgs e)
        {
            int cursorPosition = inputField.SelectionStart;
            if (!scopeOpened)
            {
                inputField.Text = inputField.Text.Insert(cursorPosition, "(");
                inputField.SelectionStart = cursorPosition + 1;
            }
            else
            {
                inputField.Text = inputField.Text.Insert(cursorPosition, ")");
                inputField.SelectionStart = cursorPosition + 1;
            }
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            int selLength = inputField.SelectionLength;
            int selStart = inputField.SelectionStart;
            inputField.Focus();
            inputField.SelectionLength = selLength;
            inputField.SelectionStart = selStart;
            SendKeys.Send("{BACKSPACE}");
            inputField.Text = inputField.Text.TrimEnd();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputField.Text = "";
        }

        private void degreeButton_Click(object sender, EventArgs e)
        {
            int cursorPosition = inputField.SelectionStart;
            if (inputField.Text.Trim() != "" &&
                char.IsDigit(inputField.Text.TrimEnd()[^1]) || inputField.Text.TrimEnd()[^1] == ')')
            {
                inputField.Text = inputField.Text.Insert(cursorPosition, "^");
                inputField.SelectionStart = cursorPosition + 1;
            }
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {
            if (inputField.Text.Count(c => c == '(') == inputField.Text.Count(c => c == ')'))
                scopeOpened = false;
            else
                scopeOpened = true;
        }

        private void inputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CalculateInput(inputField.Text);
            }
        }

        private void UpdateUploadList()
        {
            if (File.Exists(filePath))
            {
                states.Clear();
                using (BinaryReader reader = new(File.Open(filePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        ApplicationState state = new(reader.ReadInt32(), reader.ReadString(), reader.ReadString());
                        states.Add(state);
                    }
                }
            }
            uploadMenuButton.DropDownItems.Clear();

            foreach (var state in states)
            {
                ToolStripMenuItem item = new(state.date);
                item.Click += UpdateState!;
                uploadMenuButton.DropDownItems.Add(item);
            }

        }

        private void SaveState()
        {
            if (inputField.Text.Trim() == "") return;
            ApplicationState state = new(inputField.SelectionStart, DateTime.Now.ToString(), inputField.Text);

            if (states.Any(v => v.inputFieldData == state.inputFieldData))
            {
                states.RemoveAll(v => v.inputFieldData == state.inputFieldData);
            }

            states.Insert(0, state);

            using (BinaryWriter writer = new(File.OpenWrite(filePath)))
            {
                foreach (var s in states)
                {
                    writer.Write(s.cursorPos);
                    writer.Write(s.date);
                    writer.Write(s.inputFieldData);
                }
            }
        }

        private void UpdateState(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            inputField.Text = states.Find(s => s.date == item.Text)!.inputFieldData;
            inputField.SelectionStart = states.Find(s => s.date == item.Text)!.cursorPos;
        }

        private void saveMenuButton_Click(object sender, EventArgs e)
        {
            SaveState();
            UpdateUploadList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveState();
        }
    }
}