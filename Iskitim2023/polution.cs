using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskitim2023
{
    class polution
    {
        public int polution_id {  get; set; }

        private string polution_name, amount;

        private int point_id;

        public string Polution_name
        {
            get {return polution_name; }
            set {polution_name = value; } 
        }

        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Point_id
        {
            get { return point_id; }
            set { point_id = value; }
        }


        public polution() { }
        public polution (string polution_name, string amount, int point_id)
        {
            this.polution_name = polution_name;
            this.amount = amount;
            this.point_id = point_id;
        }
    }
}
