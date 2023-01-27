namespace hhTestMindbox
{
    public class Context
    {
        private IFigureStrategy _figure;
        public void SetStrategy(IFigureStrategy figure)
        {
            _figure = figure;
        }
        public double GetSquare()
        {
            return _figure.GetSquare();
        }
        public string GetInfo()
        {
            return _figure.GetInfo();
        }


    }
}
