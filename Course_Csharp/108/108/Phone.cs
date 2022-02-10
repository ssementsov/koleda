using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108
{
    class Phone
    {
        private string number;
        private string model;
        private int weight;


        public string Number { get; set; }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public void PrintConsole() => Console.WriteLine($"Model is {Model}\n" +
             $"Number is {Number}\nWeight is {Weight}\n");
        public void ReceiveCall(string name) => Console.WriteLine($"Call {name}");

        public string GetNumber(string number)
        {
            return Number;
        }

        public Phone(string number, string model, int weight)
            : this(number, model)
        {
            this.weight = weight;
        }
        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone()
        {
        }

        public void ReceiveCall(string name, string namber)
        {
            Console.WriteLine($"Call {name}, Phone: {number}");

        }
    }
}
