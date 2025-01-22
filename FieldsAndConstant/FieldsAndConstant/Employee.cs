using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndConstant
{
    internal class Employee
    {
        // <Access Modifier> -> public, private, protected
        // Constant  --> <Access Modifier> <DataType> <ConstantName> = <Value>

        public const double TAX = 0.03;

        // <Access Modifier> -> public, private, protected
        // Fields  --> <Access Modifier> <DataType> <FieldName> = <IntialValue>

        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;
    }
}
