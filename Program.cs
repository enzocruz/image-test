// See https://aka.ms/new-console-template for more information

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

using Helper;
Console.WriteLine("Hello, World!");
string imagesFolderPath = "/Users/lorenzodelacruz/Test-Images";
string TestFolder = "/Users/lorenzodelacruz/Test-Image-Ouput";
var filesInDirectory = new DirectoryInfo(imagesFolderPath).GetFiles("*.*",
                                         SearchOption.AllDirectories);
foreach (var file in filesInDirectory)
{
    //Test-Image-Ouput

    List<string> fileExt = new List<string>(){
        "png","jpg","jpeg","jfif","bm","bmp","dip"
    };

    if (fileExt.Contains(file.Extension.ToLower().Replace(".", "")))
    {
        // Console.WriteLine("Processing " + file.FullName);
        var image = Image.Load(file.FullName);
        int rotate_angle_start = 30;
        ImageHelper.Rotate(image, (float)40, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);
        ImageHelper.Flip(image, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);
        /*for (int x = rotate_angle_start; x <= 360; x = x + 30)
        {
            ImageHelper.Rotate(image, (float)x, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);

        }
        for (int x = 1; x <= 5; x++)
        {
            // ImageHelper.Brightness(image, (float)x, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);

        }*/
        // ImageHelper.Black(image, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);
        //ImageHelper.Grayscale(image, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);
        //ImageHelper.Resize(image, 40, 40, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);
        //ImageHelper.Rotate(image, (float)90, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension, "rotate", false);
        //ImageHelper.Crop(image, 50, 100, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);
        /* for (int x = 1; x <= 5; x++)
         {
             ImageHelper.ColorBlind(image, x, Path.GetFileNameWithoutExtension(file.Name), TestFolder, file.Extension);

         }*/
    }
}

/*string imagePath = "/Users/lorenzodelacruz/Documents/Test-Images/IMG_3280.JPG";
string outputPath = "/Users/lorenzodelacruz/Documents/Test-Images/" + Guid.NewGuid() + ".jpg";
const int size = 150;
const int quality = 75;*/

//Configuration.Default.AddImageFormat(new JpegFormat());
//var image = Image.Load(imagePath);

//mage.Mutate(f => f.Brightness(10));
//image.Mutate(f => f.Rotate(180));
//image.Save(outputPath);
/*using (var input = File.OpenRead(imagePath))
{
    using (var output = File.OpenWrite(outputPath))
    {
      
        /*.Resize(new ResizeOptions
        {
            Size = new Size(size, size),
            Mode = ResizeMode.Max
        });
    image.ExifProfile = null;
    image.Quality = quality;
    image.Save(output);
    }
}*/