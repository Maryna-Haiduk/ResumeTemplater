namespace ResumeTemplater
{
    public class Job
    {
        public string Title { get; set; }
        public List<string> Descriptions { get; set; }
        public string Years { get; set; }

        public Job(string title, string years, List<string> Description) 
        {
            Title = title;
            Years = years;
            Descriptions = Description;
        }
    }
}
