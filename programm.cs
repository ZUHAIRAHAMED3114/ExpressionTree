using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14ThJuneOopsPractice.ExpressionTree;
using _14ThJuneOopsPractice.ExpressionTree.Operator;

namespace _14ThJuneOopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           // problem => 2*3+4
            var additionNOde = new additionOperator();
            additionNOde.rightNode = new operandNode(4);
            additionNOde.leftNode = new MultiplicationNode();
            var multiplicationNode = additionNOde.leftNode as operatorNode;
            multiplicationNode.leftNode = new operandNode(2);
            multiplicationNode.rightNode = new operandNode(3);

            var result = additionNOde.Evaluate();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
