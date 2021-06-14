using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14ThJuneOopsPractice.ExpressionTree;

namespace _14ThJuneOopsPractice.ExpressionTree.Operator
{
    public class MultiplicationNode : operatorNode
    {
        public override double Evaluate()
        {
            return leftNode.Evaluate() * rightNode.Evaluate();
        }
    }
}
