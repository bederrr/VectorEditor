namespace VectorEditor
{
    /// <summary>
    /// Абстрактный класс векторного инстумента объекта полилинии
    /// </summary>
    abstract class AbstractVectorToolForPolyObject : AbstractVectorTool
    {
        protected override bool _CheckNeedForCompletion()
        {
            // Инструменты не содержат условия для завершения работы, основанные на внутреннем состоянии
            // Их обработку может завершить только нажатие ENTER или ESCAPE
            return false;
        }

        public override void ProcessEnter()
        {
            if (_ClickedPoints.Count >= 3)
            {
                _Complete();
            }
        }
    }
}
