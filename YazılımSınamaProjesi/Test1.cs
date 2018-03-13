namespace YazılımSınamaProjesi
{
    public class Test1
    {
        public bool IsNumeric(string text)
        {
            foreach (char chr in text)
            {
                if (!char.IsDigit(chr)) {
                    return false;

                }
                
            }
            return true;
        }
        public int FiyatDogruMu(string s)
        {
            int i = 0;
            if (IsNumeric(s))
            {
                i=1;
            }
            else if (s==" ")
            {
                i = 0;
            }
            else
            {
                i = 2;
            }

            return i;
        }
    }
}