namespace CATS_Interview.Model
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int OperatorId { get; set; }
        public string Title { get; set; }
        public string Initial { get; set; }
        public string Surname { get; set; }
        public byte ContactPositionId { get; set; }
        public string Email { get; set; }

        public virtual ContactPosition ContactPosition { get; set; }
    }
}