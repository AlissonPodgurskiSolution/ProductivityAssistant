public class ProductivityAssistant
{
    private readonly TaskOrganizer _taskOrganizer;

    public ProductivityAssistant(string apiKey)
    {
        _taskOrganizer = new TaskOrganizer(apiKey);
    }

    public async Task Run()
    {
        string taskList = "1. Complete project report\n2. Attend team meeting\n3. Respond to client emails\n4. Plan next week's schedule";
        string organizedTasks = await _taskOrganizer.OrganizeTasksAsync(taskList);
        Console.WriteLine($"Organized Tasks: {organizedTasks}\n\n");

        string priorityList = await _taskOrganizer.PrioritizeTasksAsync(organizedTasks);
        Console.WriteLine($"Priority List: {priorityList}\n\n");

        string taskDetails = "1. Complete project report - High importance, deadline tomorrow\n2. Attend team meeting - Medium importance, scheduled for 3 PM\n3. Respond to client emails - High importance, response needed by end of day\n4. Plan next week's schedule - Low importance, can be done anytime";
        string productivityTips = await _taskOrganizer.GetProductivityTipsAsync(taskDetails);
        Console.WriteLine($"Productivity Tips: {productivityTips}\n\n");
    }
}
