using System.Collections.Generic;

namespace TestFlow
{
    public class Calculator
    {
        private IList<int> _listeValeurs;
        private int _result;

        public Calculator()
        {
            _listeValeurs = new List<int>();
            _result = 0;
        }

        public void SetInput(int value)
        {
            _listeValeurs.Add(value);
        }

        public void Add()
        {
            foreach (var value in _listeValeurs)
            {
                _result += value;
            }
        }

        public int GetResult()
        {
            return _result;
        }
    }
}