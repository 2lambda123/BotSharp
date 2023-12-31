using BotSharp.Abstraction.Conversations.Models;

namespace BotSharp.Plugin.PizzaBot.Functions;

public class GetOrderStatusFn : IFunctionCallback
{
    public string Name => "get_order_status";

    public async Task<bool> Execute(RoleDialogModel message)
    {
        message.Content = "ready to deliver, will arrived in about 15 minutes.";
        message.Data = new
        {
            Status = "Ready to deliver",
            EstimatedTime = "15 minuts"
        };
        return true;
    }
}
