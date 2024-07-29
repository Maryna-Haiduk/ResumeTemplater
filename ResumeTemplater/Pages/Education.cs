namespace ResumeTemplater.Pages
{
	public class Education
	{
		public string Name { get; set; }	
		public string Description { get; set; }
		public Education(string name, string description) 
		{
			Name = name;
			Description = description;
		}
	}
}
