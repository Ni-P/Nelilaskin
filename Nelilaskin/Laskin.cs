using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelilaskin
{
    enum Operations { NONE, ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION };


    class Laskin {

        private double _result;
        private Operations _currentOp;
        private string _firstNumber;
        private string _secondNumber;
        private double _firstDouble;
        private double _secondDouble;
        public Boolean isFloating;
        
        public Laskin() {
            _result = 0;
            _currentOp = 0;
            _firstNumber = String.Empty;
            _firstDouble = 0;
            _secondNumber = String.Empty;
            _secondDouble = 0;
            isFloating = true; // this is redundant currently but must be true
        }

        public void ClearAll() {
            _firstNumber = String.Empty;
            _firstDouble = 0;
            _secondNumber = String.Empty;
            _secondDouble = 0;
            _currentOp = 0;
        
        }

        public Boolean SetOperation(Operations op)
        {
            if (_firstNumber.EndsWith(",")) // expecting number next
            {
                return false;
            }
            else
            {
                if(_secondNumber != String.Empty)
                {
                    return Calculate();
                }
                else
                {
                    _currentOp = op;
                    return true;
                }

            }

        }

        public Boolean AddDigit(string digit)
        {
            if(_currentOp == 0) // still entering first number
            {
                if(digit == ",")
                {
                    if (_firstNumber.Contains(",")) return false;
                    _firstNumber += ",";
                    _firstDouble = Double.Parse(_firstNumber+"0");
                    return true;
                } else
                {
                    _firstNumber += digit;
                    _firstDouble = Double.Parse(_firstNumber);
                    return true;
                }
            } else // operation set and entering second number
            {
                if (digit == ",")
                {
                    if (_secondNumber.Contains(",")) return false;
                    _secondNumber += ",";
                    _secondDouble = Double.Parse(_secondNumber+"0");
                    return true;
                } else
                {
                    _secondNumber += digit;
                    _secondDouble = Double.Parse(_secondNumber);
                    return true;
                }
            }

        }

        public Boolean Calculate()
        {
            if(_firstNumber != String.Empty && _secondNumber != String.Empty && _currentOp != Operations.NONE)
            {
                switch(_currentOp)
                {
                    case Operations.ADDITION:
                        if(isFloating)
                        {
                            _firstDouble += _secondDouble;
                            _result = _firstDouble;
                            _firstNumber = _result.ToString();
                            _currentOp = 0;
                            _secondNumber = String.Empty;
                            return true;
                        }
                        //_firstNumber += _secondNumber;
                        break;
                    case Operations.SUBTRACTION:
                        if (isFloating)
                        {
                            _firstDouble -= _secondDouble;
                            _result = _firstDouble;
                            _firstNumber = _result.ToString();
                            _currentOp = 0;
                            _secondNumber = String.Empty;
                            return true;
                        }

                        //_firstNumber -= _secondNumber;
                        break;

                    case Operations.MULTIPLICATION:
                        if (isFloating)
                        {
                            _firstDouble *= _secondDouble;
                            _result = _firstDouble;
                            _firstNumber = _result.ToString();
                            _currentOp = 0;
                            _secondNumber = String.Empty;
                            return true;
                        }
                        //_firstNumber *= _secondNumber;
                        break;
                    case Operations.DIVISION:
                        if (isFloating)
                        {
                            if(_secondDouble == 0)
                            {
                                return false;
                            } else
                            {
                                _firstDouble /= _secondDouble;
                                _result = _firstDouble;
                                _firstNumber = _result.ToString();
                                _currentOp = 0;
                                _secondNumber = String.Empty;
                                return true;

                            }
                        }
                        break;

                    default:
                        _currentOp = 0;
                        break;
                }
            }


            return false;
        }

        public string GetResult()
        {

            return _result.ToString();
        } 

        public Boolean UndoEntry()
        {
            if(_secondNumber.Equals(String.Empty)) // at entering second value
            {
                if(_currentOp != 0) // if op set do nothing
                { 
                    return false;
                }
                else if(_firstNumber.Equals("0"))
                {
                    return false;
                } else
                {
                    _firstNumber = _firstNumber.Remove(_firstNumber.Length-1);
                    if (_firstNumber.Length == 0) _firstNumber = "0";
                    _firstDouble = Double.Parse(_firstNumber);
                    return true;
                }
            } else // at entering first value
            {
                if(_secondNumber.Equals("0")) {
                    return false;
                }
                else
                {
                    _secondNumber = _secondNumber.Remove(_secondNumber.Length - 1);
                    if (_secondNumber.Length == 0) _secondNumber = "0";
                    _secondDouble = Double.Parse(_secondNumber);
                    return true;
                }
            }

        }
        
    }
}
