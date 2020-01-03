namespace DigitalPiggy
{
    // define the delegate for the event handler
    public delegate void piggyBalanceHandler(int balance);

    public class Piggy
    {
        // declare the differents events to be handled
        public event piggyBalanceHandler balanceUpdate;
        public event piggyBalanceHandler balanceGoalReached;

        /// <summary>
        /// Initializes the balance at 0
        /// </summary>
        private int balance = 0;

        public int Balance
        {
            get { return balance; }
            set
            {
                balance += value;
                // fire the first event when the value changes
                this.balanceUpdate(balance);
                // create the rules to fire the second event
                if (balance >= 500)
                    this.balanceGoalReached(balance);
            }
        }
    }
}
