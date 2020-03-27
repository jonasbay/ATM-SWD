namespace ATM
{
    public class chainEnd : IWithdraw
    {

        private IWithdraw nexInChain;
        private int _100noteCount = 0;

        public void SetNextWithdrawChain(IWithdraw c)
        {
            nexInChain = c;
        }

        public void Withdraw(Amount request)
        {

        }
    }
}