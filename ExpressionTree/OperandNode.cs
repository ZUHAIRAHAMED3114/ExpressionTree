using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ThJuneOopsPractice.ExpressionTree
{
    public class operandNode : ExpressionNode
    {
        public operandNode(int value) {
            this.value = value;
        }
        public int value { get; set; }
        public override double Evaluate()
        {
            return value;
        }
    }
}
