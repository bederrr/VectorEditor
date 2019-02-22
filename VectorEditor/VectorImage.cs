using System.Collections.Generic;

namespace VectorEditor
{
    /// <summary>
    /// Базовый класс векторного изображения
    /// </summary>
    public class VectorImage
    {
        public int Width
        {
            get; set;
        } 

        public int Height
        {
            get; set;
        }

        public List<AbstractVectorObject> VectorObjects
        {
            get { return _VectorObjects; }
            set { _VectorObjects = value; }
        }

        public VectorImage()
        {
            _VectorObjects = new List<AbstractVectorObject>();
            Width = 0;
            Height = 0;
        }

        public void AddObject(AbstractVectorObject vectorObject)
        {
            _VectorObjects.Add(vectorObject);
        }

        public void DeleteLastObject()
        {
            int lastIndex = _VectorObjects.Count - 1;
            if (lastIndex >= 0)
            {
                _VectorObjects.RemoveAt(lastIndex);
            }
        }

        public void Draw(System.Drawing.Graphics graphicsObject)
        {
            foreach (AbstractVectorObject vectorObject in _VectorObjects)
            {
                vectorObject.Draw(graphicsObject);
            }
        }

        private List<AbstractVectorObject> _VectorObjects;
    }
}
