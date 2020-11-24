using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Donut
    {
        //1    //2        //3    //4
        Donut dougDonut = new Donut();
        Donut chrisDonut = new Donut();
        Donut nickDonut = new Donut();

        //Properties
        public string Type { get; set; }
        public string Filling { get; set; }
        public decimal Price { get; set; }
        public int IsSpecial { get; set; }
    }
}
