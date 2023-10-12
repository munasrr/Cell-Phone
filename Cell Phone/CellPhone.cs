using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone
{
    internal class CellPhone
    {
        private string _brand; // The phone's brand
        private string _model; 
        private decimal _price; 

        // Constructor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        // Brand property
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // Model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // Price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
