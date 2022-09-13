using System;
using System.Collections.Generic;

namespace Emulator
{
    public class Controller
    {
        private int _pc;
        public int PC {
            get
            {
                return _pc;
            }
            set {
                _pc = value;
                if(OnPcChange != null)
                {
                    OnPcChange(_pc);
                }
            }
        }

        public Action<int> OnPcChange;

        internal void Reset()
        {
            PC = 0;
        }
    }

    public class ProgramExecuter
    {
        private Controller _controller = new Controller();
              
        
        private List<Instruction> _instructions;
        private DataStack _stack = new DataStack();
        private DataStack _stackIP = new DataStack();

        public void AttachPC(Action<int> action)
        {
            _controller.OnPcChange = action;
        }

        public void AttachDataStack(Action<int> onPush, Action onPop)
        {
            _stack.OnPush = onPush;
            _stack.OnPop = onPop;
        }

        public void AttachIpStack(Action<int> onPush, Action onPop)
        {
            _stackIP.OnPush = onPush;
            _stackIP.OnPop = onPop;
        }
        public ProgramExecuter() { }


        public ProgramExecuter(List<Instruction> instructions)
        {
            _instructions = instructions;            
        }

        public bool IsHalted =>    _controller.PC >= _instructions.Count 
                                || CurrentInstruction()._opCode == OpCodeEnum.HLT;

        private Instruction CurrentInstruction() => _instructions[_controller.PC];

        internal void Load(List<Instruction> opcodes)
        {
            _instructions = opcodes;
            _controller.Reset();
            _stack.Clear();
            _stackIP.Clear();
        }

        private bool NotEnoughParameters(int n) => n > _stack.Count;
            
        public bool ExecuteStep()
        {
            if (IsHalted)
            {
                return false;
            }

            var instruction = CurrentInstruction();
            if (NotEnoughParameters(instruction._argc))
            {
                _controller.PC = _instructions.Count;
                return false;
            }

            return instruction.Execute(_stack, _controller,_stackIP);                                    
        }
    }
}
