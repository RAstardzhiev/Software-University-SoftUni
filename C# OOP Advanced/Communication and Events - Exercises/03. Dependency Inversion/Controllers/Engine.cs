namespace _03.Dependency_Inversion.Controllers
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Strategies;

    public class Engine
    {
        private IReader reader;
        private IWriter writer;
        private IDictionary<char, IStrategy> symbolicStrategyMapper;
        private IPrimitiveCalculator calculator;

        public Engine(IPrimitiveCalculator calculator, IReader reader, IWriter writer) 
            : this(calculator, reader, writer, new Dictionary<char, IStrategy>())
        {
            this.SetDefaultSymbolicStrategyMapper();
        }

        public Engine(IPrimitiveCalculator calculator, IReader reader, IWriter writer, IDictionary<char, IStrategy> symbolicStrategyMapper)
        {
            this.calculator = calculator;
            this.reader = reader;
            this.writer = writer;
            this.symbolicStrategyMapper = symbolicStrategyMapper;
        }


        public void Run()
        {
            this.ExecuteCommands();
        }

        private void ExecuteCommands()
        {
            var command = this.reader.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0].Equals("mode", StringComparison.OrdinalIgnoreCase))
                {
                    var newStrategy = this.symbolicStrategyMapper[command[1][0]];
                    this.calculator.ChangeStrategy(newStrategy);
                }
                else
                {
                    var firstOperand = int.Parse(command[0]);
                    var secondOperand = int.Parse(command[1]);
                    var result = this.calculator.PerformCalculation(firstOperand, secondOperand);
                    this.writer.WriteLine(result.ToString());
                }

                command = this.reader.ReadLine().Split();
            }
        }

        private void SetDefaultSymbolicStrategyMapper()
        {
            this.symbolicStrategyMapper['+'] = new AdditionStrategy();
            this.symbolicStrategyMapper['-'] = new SubtractionStrategy();
            this.symbolicStrategyMapper['*'] = new MultiplicationStrategy();
            this.symbolicStrategyMapper['/'] = new DivisionStrategy();
        }
    }
}
