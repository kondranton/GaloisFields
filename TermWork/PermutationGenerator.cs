using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportingLib
{
    public class PermutationGenerator
    {

        private int[] _p;
        private int _permutationLength;
        private int _inversions;
        private Pairs _pairs1;
        private Pairs _pairs2;
        private int[] _indexArray;

        private void _swapValues(int a, int b, int[] array)
        {
            int c = array[a];
            array[a] = array[b];
            array[b] = c;
        }
        private bool _inOrder(int left, int right)
        {
            return left < right;
        }
        private int[] _iterate()
        {
            if (_p == null)
            {
                _initializePermutation();
                _updatePermutation();
                return _p;
            }//There is no permutation yet

                //Previous permutation exists
                for (int i = _indexArray.Length - 1; i > 0; i--)
                {
                    if (_inOrder(_indexArray[i - 1], _indexArray[i]))
                    {
                        int tearingNumberIndex = i-1;

                        //Reorder the tail
                        Array.Sort(_indexArray, tearingNumberIndex + 1, _indexArray.Length - tearingNumberIndex - 1);

                        //Search for the number to swap with tearing number
                        for (int j = tearingNumberIndex; j < _indexArray.Length; j++)
                        {
                            //The number should be greater than tearing
                            if (_inOrder(_indexArray[tearingNumberIndex], _indexArray[j]))
                            {
                                _swapValues(tearingNumberIndex, j, _indexArray);
                                break;
                            }
                        }
                        _updatePermutation();
                        return _p;
                    }
                }
                    int inversionIndex = _nextInversionIndex();
                    if (_inversions == 2 << (_permutationLength / 2 - 1))
                        return null; //There is no suitable permutations left

                    _pairs1.SwapValuesAtIndex(inversionIndex);
                    _resetIndexArray();
                    _updatePermutation();
                    return _p;
        }
        private int _nextInversionIndex()
        {
            int previousInversions = _inversions++;
            return _indexOfFlag(_inversions, previousInversions);
        }
        private int _indexOfFlag(int minuend, int subtrahend)
        {
            for (int i = 0; i < 16; i++)
            {
                if (_flagAtPosition(i, minuend))
                    if (!_flagAtPosition(i, subtrahend))
                        return i;
            }
            return -1;
        }
        private bool _flagAtPosition(int position, int flagKeeper)
        {
            if ((flagKeeper | (1 << position)) == flagKeeper)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void _updatePermutation()
        {
            for (int i = 0; i < _pairs1.Length; i++)
            {
                _p[_pairs1[_indexArray[i]].Item1] = (int)_pairs2[i].Item1;
                _p[_pairs1[_indexArray[i]].Item2] = (int)_pairs2[i].Item2;
            }
        }
        private void _initializePermutation()
        {
            _p = new int[_permutationLength + 1];
            for (int i = 1; i < _p.Length; i++) _p[i] = i;
            _resetIndexArray();
        }
        private void _resetIndexArray()
        {
            for (int i = 0; i < _indexArray.Length; i++) _indexArray[i] = i;
        }
        public int[] NextPermutation()
        {
            return _iterate();
        }
       
        public PermutationGenerator( int permutationLength , Pairs pairs1, Pairs pairs2)
        {
            _pairs1 = pairs1;
            _pairs2 = pairs2;
            _indexArray = new int[pairs1.Length];
            _inversions = 0;
            this._permutationLength = permutationLength;
        }
    }
}
