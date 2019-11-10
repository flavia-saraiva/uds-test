using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uds.test.Models
{
    public class Pizza
    {
        public long Id { get; set; }
        public int Flavor { get; set; }
        public int Size { get; set; }
        public int Extras { get; set; }

        public enum PizzaFlavor
        {
            CALABRESA = 1,
            MARGUERITA = 2,
            PORTUGUESA = 3
        }

        public enum PizzaSize
        {
            SMALL = 1,
            MEDIUM = 2,
            LARGE = 3
        }

        public enum PizzaExtras
        {
            BACON = 1,
            NO_ONIONS = 2,
            STUFFED_CRUST = 3
        }

        public int GetTotalPrice()
        {
            var price = AddExtraPrice();

            switch (Size)
            {
                case (int)Pizza.PizzaSize.SMALL:
                    return (price + 20);
                case (int)Pizza.PizzaSize.MEDIUM:
                    return (price + 30);
                case (int)Pizza.PizzaSize.LARGE:
                    return (price + 40);
                default:
                    return 0;
            }
        }
        
        public int GetPreparationTime()
        {
            var time = AddExtraTime();

            switch (Size)
            {
                case (int)Pizza.PizzaSize.SMALL:
                    return (time + 15);
                case (int)Pizza.PizzaSize.MEDIUM:
                    return (time + 20);
                case (int)Pizza.PizzaSize.LARGE:
                    return (time + 25);
                default:
                    return 0;
            }
        }

        private int AddExtraTime()
        {

            var time = 0;

            if (Extras == (int)PizzaExtras.STUFFED_CRUST)
            {
                time += 5;
            }

            if (Flavor == (int)PizzaFlavor.PORTUGUESA)
            {
                time += 5;
            }

            return time;
        }

        private int AddExtraPrice()
        {
            if (Extras == (int)PizzaExtras.BACON)
            {
                return 3;
            }
            else if (Extras == (int)PizzaExtras.STUFFED_CRUST)
            {
                return 5;
            }

            return 0;
        }

    }
}
