using Azure.Identity;
using Azure.Messaging.ServiceBus;

namespace ConsoleApplication;

public class ServiceBusService : IServiceBusService
{
    public async Task SendMessageAsync<T>(SendMessageRequest<T> request) where T : class
    {
        Console.WriteLine("Started");
        try
        {
            var fullyQualifiedNamespace = "sb-dev-adp-spk-digital-share-01.servicebus.windows.net";
            await using var client = new ServiceBusClient(fullyQualifiedNamespace, new DefaultAzureCredential());
            var serviceBusSender = client.CreateSender("eshop_izberg_merchant_order_authorized");
            var serviceBusMessage = new ServiceBusMessage();
            await serviceBusSender.SendMessageAsync(serviceBusMessage);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Task SendMessageRequest(RawSendMessageRequest request)
    {
        throw new NotImplementedException();
    }

    public string GetQueueName(string queueName)
    {
        throw new NotImplementedException();
    }
}