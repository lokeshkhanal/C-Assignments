using System;

namespace L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Fletcher fletcher = new Fletcher("William Tell", 1000);
            Arrow arrow = fletcher.BuyArrow();
            Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");
        }
    }

    class Fletcher
    {
        public string _name;
        public int _startingGold;

        public Fletcher(string name, int startingGold)
		{
            _name = name;
            _startingGold = startingGold;
		}

        public Arrow BuyArrow()
        {
            Arrowhead arrowhead = GetArrowheadType();
            Fletching fletching = GetFletchingType();
            float length = GetLength();

            return new Arrow(arrowhead, fletching, length);
        }

        public Arrowhead GetArrowheadType()
        {
            Console.Write("Arrowhead type (steel, wood, obsidian): ");
            string input = Console.ReadLine();
            return input switch
            {
                "steel" => Arrowhead.Steel,
                "wood" => Arrowhead.Wood,
                "obsidian" => Arrowhead.Obsidian
            };
        }

        public Fletching GetFletchingType()
        {
            Console.Write("Fletching type (raven, turkey, goose): ");
            string input = Console.ReadLine();
            return input switch
            {
                "raven" => Fletching.RavenFeathers,
                "turkey" => Fletching.TurkeyFeathers,
                "goose" => Fletching.GooseFeathers
            };
        }

        public float GetLength()
        {
            float length = 0;
            while (length < 60 || length > 100)
            {
                Console.Write("Arrow length (between 60 and 100): ");
                length = Convert.ToSingle(Console.ReadLine());
            }
            return length;
        }
    }

    class Arrow
    {
        public const float lengthCostMultiplier = 0.05f;

        public Arrowhead _arrowhead;
        public Fletching _fletching;
        public float _length;

        public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }

        public float GetCost()
        {
            float arrowheadCost = _arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            float fletchingCost = _fletching switch
            {
                Fletching.RavenFeathers => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            float shaftCost = 0.05f * _length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

    enum Arrowhead { Steel, Wood, Obsidian }
    enum Fletching { RavenFeathers, TurkeyFeathers, GooseFeathers }
}
