using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
namespace Helper
{
    public class ImageHelper
    {
        public static void Rotate(Image image, float angle, string fileName, string outputPath, string ext, string prefix = "rotate", bool greyScale = true)
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, angle, fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);

            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Rotate(angle));
            if (greyScale)
                image.Mutate(f => f.Grayscale());
            Console.WriteLine("Rotated: " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Brightness(Image image, float brightness, string fileName, string outputPath, string ext, string prefix = "brightness")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, brightness, fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);

            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Brightness(brightness));
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Contrast(Image image, float contrast, string fileName, string outputPath, string ext, string prefix = "contras")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, contrast, fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);

            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Contrast(contrast));
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Crop(Image image, int width, int height, string fileName, string outputPath, string ext, string prefix = "crop")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, width + "x" + height, fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);
            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Crop(width, height));
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Black(Image image, string fileName, string outputPath, string ext, string prefix = "Black&White")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, "", fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);

            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.BlackWhite());

            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }

        public static void ColorBlind(Image image, int CBMode, string fileName, string outputPath, string ext, string prefix = "ColorBlind")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, CBMode, fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);
            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.ColorBlindness(ColorBlindnessMode.Achromatopsia));
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Resize(Image image, int x, int y, string fileName, string outputPath, string ext, string prefix = "ColorBlind")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, x + "X" + y, fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);
            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Resize(x, y));
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Grayscale(Image image, string fileName, string outputPath, string ext, string prefix = "grey")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, "", fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);
            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Grayscale());
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
        public static void Flip(Image image, string fileName, string outputPath, string ext, FlipMode flipMode = FlipMode.Vertical, string prefix = "flip")
        {
            string outputFileName = string.Format("{0}_{1}_{2}_{3}{4}", prefix, "", fileName.ToLower(),
            DateTime.Now.ToString("yyyMMdd"), ext);
            string outputFilePath = Path.Combine(outputPath, outputFileName);
            image.Mutate(f => f.Flip(flipMode));
            Console.WriteLine(prefix + " : " + outputFilePath);
            image.Save(outputFilePath);
        }
    }

}