using ColorHelper;
using NUnit.Framework;

namespace ConsoleHelper.Tests
{
    public class ColorComparerTests
    {
        [Test]
        public void Equals_RgbRgb_Correct()
        {
            var source = new RGB(30, 20, 50);
            var target = new RGB(30, 20, 50);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbRgb_Incorrect()
        {
            var source = new RGB(30, 20, 50);
            var target = new RGB(100, 150, 200);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHex_Correct()
        {
            var source = new RGB(10, 20, 25);
            var target = new HEX("#0A1419");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHex_Incorrect()
        {
            var source = new RGB(100, 101, 102);
            var target = new HEX("#FFFFFF");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbCmyk_Correct()
        {
            var source = new RGB(53, 53, 59);
            var target = new CMYK(9, 9, 0, 77);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbCmyk_Incorrect()
        {
            var source = new RGB(0, 255, 0);
            var target = new CMYK(50, 50, 50, 50);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHsv_Correct()
        {
            var source = new RGB(10, 10, 20);
            var target = new HSV(240, 50, 8);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHsv_Incorrect()
        {
            var source = new RGB(10, 10, 20);
            var target = new HSV(100, 100, 100);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHsl_Correct()
        {
            var source = new RGB(158, 0, 92);
            var target = new HSL(325, 100, 31);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbHsl_Incorrect()
        {
            var source = new RGB(10, 10, 20);
            var target = new CMYK(50, 50, 50, 50);

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_RgbXyz_Correct()
        {
            var source = new RGB(10, 20, 10);
            var target = new XYZ(0.43011701684271597, 0.5867562215079294, 0.37774575807786603);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_RgbXyz_Incorrect()
        {
            var source = new RGB(10, 20, 30);
            var target = new XYZ(0, 100, 20);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexRgb_Correct()
        {
            var source = new HEX("#1C1CD9");
            var target = new RGB(28, 28, 217);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexRgb_Incorrect()
        {
            var source = new HEX("#000028");
            var target = new RGB(100, 100, 100);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHex_Correct()
        {
            var source = new HEX("#00FFFF");
            var target = new HEX("00FFFF");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHex_Incorrect()
        {
            var source = new HEX("#000000");
            var target = new HEX("#FFFFFF");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexCmyk_Correct()
        {
            var source = new CMYK(75, 0, 19, 9);
            var target = new HEX("#3AE8BD");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexCmyk_Incorrect()
        {
            var source = new CMYK(100, 0, 100, 0);
            var target = new HEX("#121212");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHsv_Correct()
        {
            var source = new HSV(120, 100, 10);
            var target = new HEX("#001A00");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHsv_Incorrect()
        {   
            var source = new HSV(120, 100, 10);
            var target = new HEX("#ffffff");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHsl_Correct()
        {
            var source = new HSL(120, 100, 10);
            var target = new HEX("#003300");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HexHsl_Incorrect()
        {
            var source = new HSL(200, 200, 200);
            var target = new HEX("#121212");

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_HexXyz_Correct()
        {
            var source = new XYZ(5.699791412405596, 9.958316792578774, 3.135110923508634);
            var target = new HEX("#226622");

            Assert.True(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_HexXyz_Incorrect()
        {   
            var source = new XYZ(120, 100, 10);
            var target = new HEX("#ffffff");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykRgb_Correct()
        {
            var source = new CMYK(60, 0, 60, 18);
            var target = new RGB(84, 209, 84);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykRgb_Incorrect()
        {
            var source = new CMYK(0, 5, 0, 10);
            var target = new RGB(2, 10, 30);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHex_Correct()
        {
            var source = new CMYK(0, 82, 4, 30);
            var target = new HEX("#B320AB");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHex_Incorrect()
        {
            var source = new CMYK(0, 100, 0, 20);
            var target = new HEX("#BABABA");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykCmyk_Correct()
        {
            var source = new CMYK(10, 50, 90, 100);
            var target = new CMYK(10, 50, 90, 100);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykCmyk_Incorrect()
        {
            var source = new CMYK(10, 10, 10, 100);
            var target = new CMYK(0, 0, 0, 0);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHsv_Correct()
        {
            var source = new CMYK(0, 0, 100, 60);
            var target = new HSV(60, 100, 40);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHsv_Incorrect()
        {
            var source = new CMYK(10, 10, 10, 100);
            var target = new HSV(30, 30, 30);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHsl_Correct()
        {
            var source = new CMYK(0, 0, 100, 60);
            var target = new HSL(60, 100, 20);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykHsl_Incorrect()
        {
            var source = new CMYK(10, 10, 10, 100);
            var target = new HSL(0, 0, 20);

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_CmykXyz_Correct()
        {
            var source = new CMYK(0, 10, 12, 36);
            var target = new XYZ(30, 30, 30);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_CmykXyz_Incorrect()
        {
            var source = new CMYK(10, 24, 36, 6);
            var target = new XYZ(10, 32, 12);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvRgb_Correct()
        {
            var source = new HSV(261, 61, 20);
            var target = new RGB(31, 20, 51);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvRgb_Incorrect()
        {
            var source = new HSV(261, 61, 20);
            var target = new RGB(0, 0, 0);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvHex_Correct()
        {
            var source = new HSV(261, 61, 20);
            var target = new HEX("1F1433");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvHex_Incorrect()
        {
            var source = new HSV(261, 61, 20);
            var target = new HEX("0000FF");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvCmyk_Correct()
        {
            var source = new HSV(261, 61, 20);
            var target = new CMYK(39, 61, 0, 80);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvCmyk_Incorrect()
        {
            var source = new HSV(261, 61, 20);
            var target = new CMYK(0, 100, 0, 100);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvHsl_Correct()
        {
            var source = new HSV(261, 61, 20);
            var target = new HSL(261, 44, 14);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvHsl_Incorrect()
        {
            var source = new HSV(261, 61, 20);
            var target = new HSL(0, 0, 0);

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_HsvXyz_Correct()
        {
            var source = new HSV(100, 20, 100);
            var target = new XYZ(76.47787698308086, 91.25178542741659, 70.70928495701926);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HsvXyz_Incorrect()
        {
            var source = new HSV(12, 12, 12);
            var target = new XYZ(10, 10, 10);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslRgb_Correct()
        {
            var source = new HSL(250, 92, 36);
            var target = new RGB(35, 7, 176);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslRgb_Incorrect()
        {
            var source = new HSL(0, 20, 0);
            var target = new RGB(100, 100, 100);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslHex_Correct()
        {
            var source = new HSL(20, 100, 20);
            var target = new HEX("662200");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslHex_Incorrect()
        {
            var source = new HSL(250, 48, 36);
            var target = new HEX("ffff66");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslCmyk_Correct()
        {
            var source = new HSL(100, 74, 18);
            var target = new CMYK(57, 0, 85, 68);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslCmyk_Incorrect()
        {
            var source = new HSL(20, 20, 80);
            var target = new CMYK(0, 10, 0, 10);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslHsv_Correct()
        {
            var source = new HSL(360, 100, 50);
            var target = new HSV(360, 100, 100);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslHsv_Incorrect()
        {
            var source = new HSL(360, 100, 50);
            var target = new HSV(0, 0, 0);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslHsl_Correct()
        {
            var source = new HSL(250, 63, 15);
            var target = new HSL(250, 63, 15);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslHsl_Incorrect()
        {
            var source = new HSL(100, 100, 100);
            var target = new HSL(0, 0, 0);

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_HslXyz_Correct()
        {
            var source = new HSL(344, 4, 50);
            var target = new XYZ(20, 20, 22);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_HslXyz_Incorrect()
        {
            var source = new HSL(1, 10, 100);
            var target = new XYZ(2, 20, 200);

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_XyzRgb_Correct()
        {
            var source = new XYZ(0.43011701684271597, 0.5867562215079294, 0.37774575807786603);
            var target = new RGB(10, 20, 10);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzRgb_Incorrect()
        {
            var source = new XYZ(0, 0, 0);
            var target = new RGB(100, 100, 100);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzHex_Correct()
        {
            var source = new XYZ(5.699791412405596, 9.958316792578774, 3.135110923508634);
            var target = new HEX("226622");

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzHex_Incorrect()
        {
            var source = new XYZ(100, 100, 100);
            var target = new HEX("ababab");

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzCmyk_Correct()
        {
            var source = new XYZ(43.51851344932272, 47.11567032831833, 41.45089374761614);
            var target = new CMYK(10, 10, 20, 20);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzCmyk_Incorrect()
        {
            var source = new XYZ(20, 36, 48);
            var target = new CMYK(0, 100, 20, 160);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzHsv_Correct()
        {
            var source = new XYZ(20.862806611491127, 19.133352252151763, 12.718731377483968);
            var target = new HSV(20, 40, 60);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzHsv_Incorrect()
        {
            var source = new XYZ(100, 0, 100);
            var target = new HSV(20, 0, 20);

            Assert.False(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzHsl_Correct()
        {
            var source = new XYZ(7.204152260786181, 6.508662463833722, 5.291475940262422);
            var target = new HSL(10, 20, 30);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzHsl_Incorrect()
        {
            var source = new XYZ(20, 20, 20);
            var target = new HSL(40, 40, 40);

            Assert.False(ColorComparer.Equals(source, target));
        }
        
        [Test]
        public void Equals_XyzXyz_Correct()
        {
            var source = new XYZ(10, 20, 32);
            var target = new XYZ(10, 20, 32);

            Assert.True(ColorComparer.Equals(source, target));
        }

        [Test]
        public void Equals_XyzXyz_Incorrect()
        {
            var source = new XYZ(20, 20, 20);
            var target = new XYZ(30, 30, 30);

            Assert.False(ColorComparer.Equals(source, target));
        }
    }
}