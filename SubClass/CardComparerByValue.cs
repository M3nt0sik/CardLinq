using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLinq
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            Enum.TryParse(x.Suit, out ESuit xsuit);
            Enum.TryParse(y.Suit, out ESuit ysuit);
            Enum.TryParse(x.Value, out EValue xValue);
            Enum.TryParse(y.Value, out EValue yValue);

            if (xsuit > ysuit) return 1;
            else if (xsuit < ysuit) return -1;
            else
            {
                if (xValue > yValue) return 1;
                else if (xValue < yValue) return -1;
                else return 0;
            }

        }
    }
}
