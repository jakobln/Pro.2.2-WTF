namespace WTF
{
    public class MysticNumbers
    {
        #region Methods
        public int ThreeNumbers(int a, int b, int c)
        {
            return TwoNumbers(TwoNumbers(a, b),c);

            /*int result1;

            if (b > a)
            {
                result1 = b;
                if (c > b)
                {
                    result1 = c;
                }
            }
            else
            {
                result1 = a;
                if (c > a)
                {
                    result1 = c;
                }
            }

            return result1;*/
        } 
        public int TwoNumbers(int a, int b)
        {
            int result2;

            if (b > a)
            {
                result2 = b;
            }
            else
            {
                result2 = a;
            }

            return result2;
        }
        public int FourNumbers(int a, int b, int c, int d)
        {
            return TwoNumbers(TwoNumbers(a,b),TwoNumbers(c,d));
        }
        #endregion
    }
}