# ColorHelper - Useful methods for work with color spaces

Supported color spaces:
- RGB
- HEX
- CMYK
- HSV
- HSL
- XYZ
- YIQ
- YUV

This library provides several useful classes:

## ColorConverter

Convert Rgb to Hex:
```
HEX hex = ColorConverter.RgbToHex(new RGB(10, 20, 30));
```

Convert Rgb to Cmyk:
```
CMYK cmyk = ColorConverter.RgbToCmyk(new RGB(10, 20, 30));
```

Convert Rgb to Hsv:
```
HSV hsv = ColorConverter.RgbToHsv(new RGB(10, 20, 30));
```

Convert Rgb to Hsl:
```
HSL hsl = ColorConverter.RgbToHsl(new RGB(10, 20, 30));
```

Convert Rgb to Xyz:
```
XYZ xyz = ColorConverter.RgbToXyz(new RGB(10, 20, 30));
```

Convert Rgb to Yiq:
```
YIQ yiq = ColorConverter.RgbToYiq(new RGB(10, 20, 30));
```

Convert Rgb to Yuv:
```
YUV yuv = ColorConverter.RgbToYuv(new RGB(10, 20, 30));
```

Convert Hex to Rgb:
```
RGB rgb = ColorConverter.HexToRgb(new HEX("#00FF00"));
```

Convert Hex to Cmyk:
```
CMYK cmyk = ColorConverter.HexToCmyk(new HEX("#00FF00"));
```

Convert Hex to Hsv:
```
HSV hsv = ColorConverter.HexToHsv(new HEX("#00FF00"));
```

Convert Hex to Hsl:
```
HSL hsl = ColorConverter.HexToHsl(new HEX("#00FF00"));
```

Convert Hex to Xyz:
```
XYZ xyz = ColorConverter.HexToXyz(new HEX("#00FF00"));
```

Convert Hex to Yiq:
```
YIQ yiq = ColorConverter.HexToYiq(new HEX("#00FF00"));
```

Convert Hex to Yuv:
```
YUV yuv = ColorConverter.HexToYuv(new HEX("#00FF00"));
```

Convert Cmyk to Rgb:
```
RGB rgb = ColorConverter.CmykToRgb(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hex:
```
HEX hex = ColorConverter.CmykToHex(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hsv:
```
HSV hsv = ColorConverter.CmykToHsv(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Hsl:
```
HSL hsl = ColorConverter.CmykToHsl(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Xyz:
```
XYZ xyz = ColorConverter.CmykToXyz(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Yiq:
```
YIQ yiq = ColorConverter.CmykToYiq(new CMYK(0, 100, 0, 100));
```

Convert Cmyk to Yuv:
```
YUV yuv = ColorConverter.CmykToYuv(new CMYK(0, 100, 0, 100));
```

Convert Hsv to Rgb:
```
RGB rgb = ColorConverter.HsvToRgb(new HSL(0, 0, 100));
```

Convert Hsv to Hex:
```
HEX hex = ColorConverter.HsvToHex(new HSL(0, 0, 100));
```

Convert Hsv to Cmyk:
```
CMYK cmyk = ColorConverter.HsvToCmyk(new HSL(0, 0, 100));
```

Convert Hsv to Hsl:
```
HSV hsv = ColorConverter.HsvToHsl(new HSL(0, 0, 100));
```

Convert Hsv to Xyz:
```
XYZ xyz = ColorConverter.HsvToXyz(new HSL(0, 0, 100));
```

Convert Hsv to Yiq:
```
YIQ yiq = ColorConverter.HsvToYiq(new HSL(0, 0, 100));
```

Convert Hsv to Yuv:
```
YUV yuv = ColorConverter.HsvToYuv(new HSL(0, 0, 100));
```

Convert Hsl to Rgb:
```
RGB rgb = ColorConverter.HslToRgb(new HSL(0, 0, 100));
```

Convert Hsl to Hex:
```
HEX hex = ColorConverter.HslToHex(new HSL(0, 0, 100));
```

Convert Hsl to Cmyk:
```
CMYK cmyk = ColorConverter.HslToCmyk(new HSL(0, 0, 100));
```

Convert Hsl to Hsv:
```
HSV hsv = ColorConverter.HslToHsv(new HSL(0, 0, 100));
```

Convert Hsl to Xyz:
```
XYZ xyz = ColorConverter.HslToXyz(new HSL(0, 0, 100));
```

Convert Hsl to Yiq:
```
YIQ yiq = ColorConverter.HslToYiq(new HSL(0, 0, 100));
```

Convert Hsl to Yuv:
```
YUV yuv = ColorConverter.HslToYuv(new HSL(0, 0, 100));
```

Convert Xyz to Rgb:
```
RGB rgb = ColorConverter.XyzToRgb(new XYZ(0, 0, 10));
```

Convert Xyz to Hex:
```
HEX hex = ColorConverter.XyzToHex(new XYZ(0, 0, 10));
```

Convert Xyz to Cmyk:
```
CMYK cmyk = ColorConverter.XyzToCmyk(new XYZ(0, 0, 10));
```

Convert Xyz to Hsv:
```
HSV hsv = ColorConverter.XyzToHsv(new XYZ(0, 0, 10));
```

Convert Xyz to Hsl:
```
HSL hsl = ColorConverter.XyzToHsl(new XYZ(0, 0, 10));
```

Convert Xyz to Yiq:
```
YIQ yiq = ColorConverter.XyzToYiq(new XYZ(0, 0, 10));
```

Convert Xyz to Yuv:
```
YUV yuv = ColorConverter.XyzToYuv(new XYZ(0, 0, 10));
```

Convert Yiq to Rgb:
```
RGB rgb = ColorConverter.YiqToRgb(new YIQ(0.1, 0.1, 0.2));
```

Convert Yiq to Hex:
```
HEX hex = ColorConverter.YiqToHex(new YIQ(0.1, 0.1, 0.2));
```

Convert Yiq to Cmyk:
```
CMYK cmyk = ColorConverter.YiqToCmyk(new YIQ(0.1, 0.1, 0.2));
```

Convert Yiq to Hsv:
```
HSV hsv = ColorConverter.YiqToHsv(new YIQ(0.1, 0.1, 0.2));
```

Convert Yiq to Hsl:
```
HSL hsl = ColorConverter.YiqToHsl(new YIQ(0.1, 0.1, 0.2));
```

Convert Yiq to Xyz:
```
YIQ yiq = ColorConverter.YiqToXyz(new YIQ(0.1, 0.1, 0.2));
```

Convert Yiq to Yuv:
```
YUV yuv = ColorConverter.YiqToYuv(new YIQ(0.1, 0.1, 0.2));
```

Convert Yuv to Rgb:
```
RGB rgb = ColorConverter.YuvToRgb(new YUV(0.1, 0.1, 0.1));
```

Convert Yuv to Hex:
```
HEX hex = ColorConverter.YuvToHex(new YUV(0.1, 0.1, 0.1));
```

Convert Yuv to Cmyk:
```
CMYK cmyk = ColorConverter.YuvToCmyk(new YUV(0.1, 0.1, 0.1));
```

Convert Yuv to Hsv:
```
HSV hsv = ColorConverter.YuvToHsv(new YUV(0.1, 0.1, 0.1));
```

Convert Yuv to Hsl:
```
HSL hsl = ColorConverter.YuvToHsl(new YUV(0.1, 0.1, 0.1));
```

Convert Yuv to Xyz:
```
YIQ yiq = ColorConverter.YuvToXyz(new YUV(0.1, 0.1, 0.1));
```

Convert Yuv to Yiq:
```
YIQ yiq = ColorConverter.YuvToYiq(new YUV(0.1, 0.1, 0.1));
```

## ColorComparer
```
bool result = ColorComparer.Equals(new RGB(100, 100, 100), new HEX("#FFFFFF"));
```

You can use **Equals** method with all pair color combinations.

## ColorGenerator

This class provides in this moment logic for get random colors.

Get random color:

```
RGB rgb = ColorGenerator.GetRandomColor<RGB>();
HEX hex = ColorGenerator.GetRandomColor<HEX>();
CMYK cmyk = ColorGenerator.GetRandomColor<CMYK>();
HSV hsv = ColorGenerator.GetRandomColor<HSV>();
HSL hsl = ColorGenerator.GetRandomColor<HSL>();
XYZ xyz = ColorGenerator.GetRandomColor<XYZ>();
YIQ yiq = ColorGenerator.GetRandomColor<YIQ>();
YUV yuv = ColorGenerator.GetRandomColor<YUV>();
```

Get light random color:

```
RGB rgb = ColorGenerator.GetLightRandomColor<type>();
```

Get dark random color:

```
RGB rgb = ColorGenerator.GetDarkRandomColor<type>();
```

## Enums:

- ColorName - Enum with many color names:

```
RGB rgb = ColorName.Aquamarine.ToRgb();
HEX hex = ColorName.RedPurple.ToHex();
CMYK cmyk = ColorName.SpanishRed.ToCmyk();
HSV hsv = ColorName.Coral.ToHsv();
HSL hsl = ColorName.NeonFuchsia.ToHsl();
XYZ xyz = ColorName.Raspberry.ToXyz();
YIQ yiq = ColorName.Coffee.ToYiq();
YUV yuv = ColorName.Purple.Toyuv();
```
