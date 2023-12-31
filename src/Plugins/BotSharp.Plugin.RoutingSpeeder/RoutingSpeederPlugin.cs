using BotSharp.Abstraction.Conversations;
using BotSharp.Abstraction.MLTasks;
using BotSharp.Abstraction.Plugins;
using BotSharp.Plugin.RoutingSpeeder.Settings;
using BotSharp.Plugin.RoutingSpeeder.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BotSharp.Plugin.RoutingSpeeder;

public class RoutingSpeederPlugin : IBotSharpPlugin
{
    public void RegisterDI(IServiceCollection services, IConfiguration config)
    {
        var settings = new RouterSpeederSettings();
        config.Bind("RouterSpeeder", settings);
        services.AddSingleton(x => settings);

        services.AddSingleton<ClassifierSetting>();

        services.AddScoped<IConversationHook, RoutingConversationHook>();
        services.AddSingleton<IntentClassifier>();
    }
}
