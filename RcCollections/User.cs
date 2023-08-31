namespace RcCollections
{
    internal class User
    {
        public required string Name { get; set; }

        public int? Age { get; set; }

        public override bool Equals(object obj!!) => Equals(obj as User);

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Age);
        }

        private bool Equals(User that)
        {
            if (that == null)
            {
                return false;
            }
            return Equals(Name, that.Name) && Age == that.Age;
        }
    }
}
