using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewGis.Maps
{
    class MapStyles
    {
        public const string Dark1 = "b88a380bfaee4f03db5232e15a67b4a5";
        public const string Dark2 = "a582dc063677b3ba322e3fa5a0b3f0a2";
        public const string Light1 = "70749a9cacc162baa7176e163892ced1";
        public const string Light2 = "a11c2898b5196a4e0121470308be420c";
        public const string Clear = "cdda9f963e1f40a7965295ed0c223e2f";
    }
    public class MapStyle
    {
        public static List<MapStyle> All = new List<MapStyle>
        {
            new MapStyle{Name="Dark1",StyleId="b88a380bfaee4f03db5232e15a67b4a5"},
            new MapStyle{Name="Dark2",StyleId="a582dc063677b3ba322e3fa5a0b3f0a2"},
            new MapStyle{Name="Light1",StyleId="70749a9cacc162baa7176e163892ced1"},
            new MapStyle{Name="Light2",StyleId="a11c2898b5196a4e0121470308be420c"},
            new MapStyle{Name="Clear",StyleId="cdda9f963e1f40a7965295ed0c223e2f"},
        };
        public string Name { get; set; }
        public string StyleId { get; set; }

    }
}
