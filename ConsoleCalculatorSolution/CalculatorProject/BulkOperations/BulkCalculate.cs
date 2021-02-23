using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models
{
    class BulkCalculation
    {
      
        public List<double> ListOfValues { get; set; }
        //store a bulk operations function
        public Func<List<double>, double> BulkOperation { get; set; }
        public BulkCalculation(List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;

         
            BulkOperation = calculation;
        }
        public double GetResult() 
        {
            return BulkOperation(ListOfValues);
        }
    }
    
     
}
