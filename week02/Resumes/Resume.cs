public class Resume
{
    //Person's name
    public string _name;

    //list to hold Job objects
    public List<Job> _jobs = new List<Job>();

    //method to display the resume
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.Dispaly(); //calls the display method for each job
        }
    }
}