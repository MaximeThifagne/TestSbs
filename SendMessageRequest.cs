using Newtonsoft.Json;

namespace ConsoleApplication;

public record SendMessageRequest<T> where T : class
{
    public required string QueueName { get; set; }

    public required T Payload { get; set; }

    public required string EventCode { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}