using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace VectorEditor
{
    class VectorImageFileManager
    {
        /// <summary>
        /// класс для открытия векторного изображения
        /// </summary>
        public VectorImage OpenVectorImage(string path)
        {
            VectorImage image = new VectorImage();
            XmlSerializer serializer = new XmlSerializer(typeof(VectorImage));
            using (StreamReader reader = new StreamReader(path))
            {
                image = (VectorImage)serializer.Deserialize(reader);
            }
            return image;
        }

        /// <summary>
        /// Сохранение векторного изображения
        /// </summary>
        public void SaveImageAsVector(VectorImage image, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VectorImage));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, image);
            }
        }

        /// <summary>
        /// Сохранение растрового изображения
        /// </summary>
        public void SaveImageAsRaster(VectorImage image, string path)
        {
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            Graphics graphicsObject = Graphics.FromImage(bitmap);
            image.Draw(graphicsObject);
            bitmap.Save(path);
        }
    }
}
