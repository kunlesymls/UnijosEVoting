namespace UnijosEVoting.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string Gender { get; set; }
        public string MatricNo { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DeptName { get; set; }
        public bool IsEligibleToVote { get; set; }
    }
}
