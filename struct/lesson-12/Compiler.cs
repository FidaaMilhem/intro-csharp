using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12
{
    public class Compiler
    {
        public Dictionary<string, int> CompilerD;

        public List<Command> CommandList = new List<Command>();

        public Compiler()
        {
            CompilerD = new Dictionary<string, int>();
        }

        private void AddFunction()
        {
            CompilerD.Add("NOP", 0);
            CompilerD.Add("PUSH", 1);
            CompilerD.Add("DROP", 2);
            CompilerD.Add("ADD", 3);
            CompilerD.Add("SUB", 4);
            CompilerD.Add("MUL", 5);
            CompilerD.Add("DIV", 6);
            CompilerD.Add("MOD", 7);
            CompilerD.Add("INC", 8);
            CompilerD.Add("DEC", 9);
            CompilerD.Add("NEG", 10);
            CompilerD.Add("DUP", 11);
            CompilerD.Add("CMP", 12);
            CompilerD.Add("SWAP", 13);
            CompilerD.Add("ROL3", 14);
            CompilerD.Add("HLT", 15);
            CompilerD.Add("JZ", 16);
            CompilerD.Add("JNZ", 17);

        }
        public Command Decode(int n,string words)
        {
            String[] space = words.Split(' ');
            int code = int.Parse(space[0].Trim());
            string value = "";
            if (space.Length > 1)
            {
                value = space[1].Trim();
            }
            return new Command(n, code,value);
        }
        
    }
}
