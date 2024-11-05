namespace RichMan
{
    public class PlayerMoneyCount
    {
        public PlayerMoneyCount(int cash = 0, bool complete = false)
        {
            _cash = cash;
            _complete = complete;
        }

        private int _cash;
        private bool _complete;

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }

    public class PlayerData : PlayerMoneyCount
    {
        public PlayerData(string achieve, string reset, int count, bool complete = true)
        {
            _timeAcheived = achieve;
            _timeReset = reset;

            Cash = count;
            Complete = complete;
        }

        private string _timeAcheived;
        private string _timeReset;

        public string TimeAcheived
        {
            get { return _timeAcheived; }
            set { _timeAcheived = value; }
        }

        public string TimeReset
        {
            get { return _timeReset; }
            set { _timeReset = value; }
        }
    }
}
