using System;
using System.Windows.Forms;

namespace Emulator
{
    public partial class Form_MachineEmulator : Form
    {        
        private ProgramExecuter _executor;        
        
        public Form_MachineEmulator()
        {
            InitializeComponent();
            _executor = new ProgramExecuter();
            _executor.AttachDataStack(
                        (data) => listBox_StackViewer.Items.Add(data),
                        () => listBox_StackViewer.Items.RemoveAt(listBox_StackViewer.Items.Count - 1)
                    );


            _executor.AttachIpStack(
                        (data) => listBox_IpStack.Items.Add(data),
                        () => listBox_IpStack.Items.RemoveAt(listBox_IpStack.Items.Count - 1)
                    );
            
            _executor.OnPcChange = (pc) => label_PC.Text = $"PC: {pc}";

            textBox_ProgramCode.Text = DemoPrograms.SimpleWithJumpsIP;
        }

        private void BuildCode_Click(object sender, EventArgs e)
        {           
            var compiler = new Compiler();
            string sourceCode = textBox_ProgramCode.Text.Trim();
            var opcodes = compiler.BuildCode(sourceCode);

            listBox_ExeCode.Items.Clear();
            int label = 0;
            foreach (var opcode in opcodes)
            {
                listBox_ExeCode.Items.Add($"{label++}: {opcode.ToString()}");
            }

            _executor.Load(opcodes);
        }

        
        private void ExecuteStep_Click(object sender, EventArgs e)
        {
            if (_executor.IsHalted)
            {
                textBox_ExecutingMessage.Text = "STOPED";                
            }
            else
            {
                
                if (_executor.ExecuteStep())
                {
                    textBox_ExecutingMessage.Text = "Executing";
                }
                else
                {
                    textBox_ExecutingMessage.Text = "Halting on Error";
                }                                
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_ProgramCode.Clear();
            listBox_StackViewer.Items.Clear();
            listBox_ExeCode.Items.Clear();
            listBox_IpStack.Items.Clear();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            while(!_executor.IsHalted)
            {
                btn_ExecuteStep.PerformClick();
            }
            textBox_ExecutingMessage.Text = "STOPED";
        }

        private void listBox_StackViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_IpStack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
