namespace UWP_Demo.CS
{
    public class Student
    {
        public string rollNumber { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return rollNumber + " - " + name;
        }
    }
}