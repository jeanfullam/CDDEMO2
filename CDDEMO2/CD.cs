namespace CDClassDemo
{
    internal class CD
    {
        //private member fields
        private string _title;
        private Artist _artist;
        private int _tracks;
        private double _price;

        //public accessors & mutators
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length > 0)
                {
                    _title = value;
                }
                else
                {
                    throw new Exception("Invalid CD Title (min 1 character)");
                }
            }
        }//end of title
        public int Tracks
        {
            get { return _tracks; }
            set
            {
                if (value > 0)
                {
                    _tracks = value;
                }
                else
                {
                    throw new Exception("Invalid CD Tracks (Min 1 track)");
                }
            }
        }// end of tracks
        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 1)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("Invalid CD price (min of 1.00)");
                }
            }
        }//end of price
        public Artist Artist
        {
            get { return _artist; }
            set { _artist = value; } //we can do this as the Artist class has validation
        }//end of Artist

        //constructor
        public CD(string title, Artist artist, int tracks, double price)
        {
            Title = title;
            Artist = artist;
            Tracks = tracks;
            Price = price;
        }
        //class method
        public string CDInfo()
        {
            return $"{Title,-20} {Artist,-20} {Price,8:c}";
        }//end of CDInfo
    }
}
