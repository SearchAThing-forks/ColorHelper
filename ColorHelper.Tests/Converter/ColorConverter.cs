using ColorHelper;
using NUnit.Framework;

namespace ConsoleHelper.Tests
{
    public class ColorConverterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RgbToHex()
        {
            var result = ColorConverter.RgbToHex(new RGB(1, 10, 30));
            Assert.AreEqual(new HEX("#010A1E"), result);
        }

        [Test]
        public void RgbToCmyk()
        {
            var result = ColorConverter.RgbToCmyk(new RGB(38,150,38));
            Assert.AreEqual(new CMYK(75, 0, 75, 41), result);
        }

        [Test]
        public void RgbToHsv()
        {
            var result = ColorConverter.RgbToHsv(new RGB(137, 32, 179));
            Assert.AreEqual(new HSV(283, 82, 70), result);
        }

        [Test]
        public void RgbToHsl()
        {
            var result = ColorConverter.RgbToHsl(new RGB(20, 20, 80));
            Assert.AreEqual(new HSL(240, 60, 20), result);
        }
        
        [Test]
        public void RgbToXyz()
        {
            var result = ColorConverter.RgbToXyz(new RGB(10, 20, 10));
            Assert.AreEqual(new XYZ(0.43011701684271597, 0.5867562215079294, 0.37774575807786603), result);
        }

        [Test]
        public void HexToRgb()
        {
            var result = ColorConverter.HexToRgb(new HEX("#6E34BF"));
            Assert.AreEqual(new RGB(110, 52, 191), result);
        }

        [Test]
        public void HexToCmyk()
        {
            var result = ColorConverter.HexToCmyk(new HEX("#6984CF"));
            Assert.AreEqual(new CMYK(49, 36, 0, 19), result);
        }

        [Test]
        public void HexToHsv()
        {
            var result = ColorConverter.HexToHsv(new HEX("#3278C2"));
            Assert.AreEqual(new HSV(211, 74, 76), result);
        }

        [Test]
        public void HexToHsl()
        {
            var result = ColorConverter.HexToHsl(new HEX("#323264"));
            Assert.AreEqual(new HSL(240, 33, 29), result);
        }
        
        [Test]
        public void HexToXyz()
        {
            var result = ColorConverter.HexToXyz(new HEX("226622"));
            Assert.AreEqual(new XYZ(5.699791412405596, 9.958316792578774, 3.135110923508634), result);
        }

        [Test]
        public void CmykToRgb()
        {
            var result = ColorConverter.CmykToRgb(new CMYK(65, 0, 40, 30));
            Assert.AreEqual(new RGB(62, 178, 107), result);
        }

        [Test]
        public void CmykToHex()
        {
            var result = ColorConverter.CmykToHex(new CMYK(2, 0, 31, 9));
            Assert.AreEqual(new HEX("#E3E8A0"), result);
        }

        [Test]
        public void CmykToHsv()
        {
            var result = ColorConverter.CmykToHsv(new CMYK(56, 0, 34, 32));
            Assert.AreEqual(new HSV(144, 56, 68), result);
        }

        [Test]
        public void CmykToHsl()
        {
            var result = ColorConverter.CmykToHsl(new CMYK(10, 10, 10, 10));
            Assert.AreEqual(new HSL(0, 0, 81), result);
        }
        
        [Test]
        public void CmykToXyz()
        {
            var result = ColorConverter.CmykToXyz(new CMYK(10, 10, 20, 20));
            Assert.AreEqual(new XYZ(43.51851344932272, 47.11567032831833, 41.45089374761614), result);
        }

        [Test]
        public void HsvToRgb()
        {
            var result = ColorConverter.HsvToRgb(new HSV(240, 80, 64));
            Assert.AreEqual(new RGB(32, 32, 162), result);

            result = ColorConverter.HsvToRgb(new HSV(270, 100, 100));
            Assert.AreEqual(new RGB(128, 0, 255), result);
        }

        [Test]
        public void HsvToRgbBlack()
        {
            var result = ColorConverter.HsvToRgb(new HSV(0, 0, 0));
            Assert.AreEqual(new RGB(0, 0, 0), result);
        }

        [Test]
        public void HsvToRgbWhite()
        {
            var result = ColorConverter.HsvToRgb(new HSV(0, 0, 100));
            Assert.AreEqual(new RGB(255, 255, 255), result);
        }


        [Test]
        public void HsvToHex()
        {
            var result = ColorConverter.HsvToHex(new HSV(240, 80, 64));
            Assert.AreEqual(new HEX("2020A2"), result);
        }

        [Test]
        public void HsvToCmyk()
        {
            var result = ColorConverter.HsvToCmyk(new HSV(240, 80, 64));
            Assert.AreEqual(new CMYK(80, 80, 0, 36), result);
        }

        [Test]
        public void HsvToHsl()
        {
            var result = ColorConverter.HsvToHsl(new HSV(240, 80, 64));
            Assert.AreEqual(new HSL(240, 67, 38), result);
        }
        
        [Test]
        public void HsvToXyz()
        {
            var result = ColorConverter.HsvToXyz(new HSV(100, 20, 100));
            Assert.AreEqual(
                new XYZ(76.47787698308086, 91.25178542741659, 70.70928495701926),
                result);
        }

        [Test]
        public void HslToRgb()
        {
            var result = ColorConverter.HslToRgb(new HSL(201, 78, 20));
            Assert.AreEqual(new RGB(11, 63, 91), result);
        }

        [Test]
        public void HslToRgbBlack()
        {
            var result = ColorConverter.HslToRgb(new HSL(0, 0, 0));
            Assert.AreEqual(new RGB(0, 0, 0), result);
        }

        [Test]
        public void HslToRgbWhite()
        {
            var result = ColorConverter.HslToRgb(new HSL(0, 0, 100));
            Assert.AreEqual(new RGB(255, 255, 255), result);
        }


        [Test]
        public void HslToHex()
        {
            var result = ColorConverter.HslToHex(new HSL(260, 77, 31));
            Assert.AreEqual(new HEX("#3B128C"), result);
        }

        [Test]
        public void HslToCmyk()
        {
            var result = ColorConverter.HslToCmyk(new HSL(336, 70, 30));
            Assert.AreEqual(new CMYK(0, 82, 49, 49), result);
        }

        [Test]
        public void HslToHsv()
        {
            var result = ColorConverter.HslToHsv(new HSL(338, 56, 18));
            Assert.AreEqual(new HSV(338, 72, 28), result);
        }

        [Test]
        public void HslToXyz()
        {
            var result = ColorConverter.HslToXyz(new HSL(50, 60, 80));
            Assert.AreEqual(
                new XYZ(68.4594297801599, 73.99060685808122, 50.208580024011965),
                result);
        }

        [Test]
        public void XyzToRgb()
        {
            var result = ColorConverter.XyzToRgb(
                new XYZ(0.43011701684271597, 0.5867562215079294, 0.37774575807786603));
            Assert.AreEqual(new RGB(10, 20, 10), result);
        }

        [Test]
        public void XyzToHex()
        {
            var result = ColorConverter.XyzToHex(
                new XYZ(5.699791412405596, 9.958316792578774, 3.135110923508634));
            Assert.AreEqual(new HEX("226622"), result);
        }

        [Test]
        public void XyzToCmyk()
        {
            var result = ColorConverter.XyzToCmyk(new XYZ(30, 30, 30));
            Assert.AreEqual(new CMYK(0, 10, 12, 36), result);
        }

        [Test]
        public void XyzToHsv()
        {
            var result = ColorConverter.XyzToHsv(new XYZ(10, 10, 10));
            Assert.AreEqual(new HSV(10, 13, 39), result);
        }

        [Test]
        public void XyzToHsl()
        {
            var result = ColorConverter.XyzToHsl(new XYZ(20, 20, 22));
            Assert.AreEqual(new HSL(344, 4, 50), result);
        }
    }
}