namespace Ss.RealEstate.Model
{
    public class DesireScoreModel
    {
        public string ResAddress { get; set; }
        public string Price { get; set; }
        public string HOA { get; set; }
        public string Zestimate { get; set; }
        public string HomeType { get; set; }
        public string ZRent { get; set; }
        public string YearBuilt { get; set; }
        public string LotSize { get; set; }
        public string FinishedSize { get; set; }
        public string Bathrooms { get; set; }
        public string Bedrooms { get; set; }
        public string HomeDetailsLink { get; set; }

        public string Score { get; set; }
        public string ErrorMsg { get; set; }
    }
}