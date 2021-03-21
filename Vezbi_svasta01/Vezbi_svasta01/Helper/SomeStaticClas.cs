using System;
using System.Collections.Generic;
using System.Text;
using Vezbi_svasta01.Enum;

namespace Vezbi_svasta01.Helper
{
    class SomeStaticClas
    {
        public static EnumSome Something(int num)
        {
            switch (num)
            {
                case 1:
                    return EnumSome.good;
                    
                case 2:
                    return EnumSome.bad;
                                    
                case 3:
                    return EnumSome.ugly;
                default:
                    return EnumSome.nothing;
            }

        }
         
    }
}
