using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Builder
{
    class Shop
    {
        public void Construct(ShipBuilder shipBuilder)
        {
            shipBuilder.BuildbodyPart();
            shipBuilder.BuildFrontPart();
            shipBuilder.BuildMissilePart();
            shipBuilder.BuildReactorPart();
        }

    }
}
