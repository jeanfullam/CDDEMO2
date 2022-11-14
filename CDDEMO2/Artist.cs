
namespace CDClassDemo
{
    internal class Artist
    {
        //private member fields
        private string _firstname;
        private string _lastname;

        //public accessors & mutators
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if (value.Length > 0)
                {
                    _firstname = value;
                }
                else
                {
                    throw new Exception("Invalid Firstname (min 1 character)");
                }
            }
        }//end of firstname

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (value.Length > 0)
                {
                    _lastname = value;
                }
                else
                {
                    throw new Exception("Invalid Lastname (min 1 character)");
                }
            }
        }//end of lastname

        //Constructor
        public Artist(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        //class Method
        public override string ToString()
        {
            return $"{Lastname}, {Firstname}";
        }
    }
}
