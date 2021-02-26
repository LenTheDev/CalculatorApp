using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject;
using Calculator;

//Abstract Factory 
 namespace Calculator.Interfaces
{
    // The Abstract Factory interface declares a set of methods that return
    public interface IAbstractFactory
    {
        IAbstractCalc CalculatorObjectA(double a, double b, Func<double, double, double> _operation);

        IAbstractCalc CalculatorObjectB();
    }
    // Concrete Factories produce a family of products that belong to a single
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CalculatorObjectA()
        {
            return new ConcreteCalcA1();
        }

        public IAbstractProductB CalculatorObjectB()
        {
            return new ConcreteCalcB1();
        }
    }

    // Each Concrete Factory has a corresponding product variant.
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CalculatorObjectA()
        {
            return new ConcreteCalcA2();
        }

        public IAbstractProductB CalculatorObjectB()
        {
            return new ConcreteCalcB2();
        }
    }

    // Each distinct product of a product family should have a base interface.
    public interface IAbstractCalcA
    {
        string CalcResult();
    }

    