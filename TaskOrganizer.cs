using OpenAI.Chat;

public class TaskOrganizer
{
    private readonly ChatClient _chatClient;

    public TaskOrganizer(string apiKey)
    {
        _chatClient = new(model: "gpt-4o", apiKey);
    }

    public async Task<string> OrganizeTasksAsync(string taskList)
    {

        var prompt = $"Organize the following tasks by category and importance:\n\n{taskList}";
        var completion = await _chatClient.CompleteChatAsync(prompt);
        return completion.Value.ToString();
    }

    public async Task<string> PrioritizeTasksAsync(string organizedTasks)
    {
        var prompt = $"Based on the following organized tasks, suggest a priority list:\n\n{organizedTasks}";
        var completion = await _chatClient.CompleteChatAsync(prompt);
        return completion.Value.ToString();
    }

    public async Task<string> GetProductivityTipsAsync(string taskDetails)
    {
        var prompt = $"Based on the following task details, provide personalized productivity tips:\n\n{taskDetails}";
        var completion = await _chatClient.CompleteChatAsync(prompt);
        return completion.Value.ToString();
    }
}
