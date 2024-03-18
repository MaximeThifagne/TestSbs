// See https://aka.ms/new-console-template for more information

using ConsoleApplication;

var request = new SendMessageRequest<string>
{
    Payload = "test",
    EventCode = "MerchantOrderAuthorized",
    QueueName = "izberg_merchant_order_authorized" 
};
var serviceBusService = new ServiceBusService();

await serviceBusService.SendMessageAsync(request);