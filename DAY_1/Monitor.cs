namespace DAY_1
{
    class Monitor
    {
        public string Firm;
        public string Type;
        public float Diag;
        public Monitor() { }
        public Monitor(string Firm, string Type, float Diag)
        {
            this.Firm = Firm;
            this.Type = Type;
            this.Diag = Diag;
        }
    }
}