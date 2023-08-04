
namespace h02
{
    public struct DecimalNumber
    {
        private int _number;
        public DecimalNumber(int value)
        {
            this._number = value;
        }
        public int Value
        {
            get { return _number; }
            set { this._number = value; }
        }
        public string ToBinary()
        {
            return Convert.ToString(_number, 2);
        }
        public string ToOctal()
        {
            return Convert.ToString(_number, 8);
        }   
        public string ToHexadecimal()
        {
            return Convert.ToString(_number, 16);
        }
    }
}