namespace ConsoleApplication;

public interface IServiceBusService
{
    Task SendMessageAsync<T>(SendMessageRequest<T> request) where T : class;
    Task SendMessageRequest(RawSendMessageRequest request);
    string GetQueueName(string queueName);
}

