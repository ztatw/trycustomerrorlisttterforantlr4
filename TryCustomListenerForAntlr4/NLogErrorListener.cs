using Antlr4.StringTemplate;
using Antlr4.StringTemplate.Misc;
using NLog;

namespace TryCustomListenerForAntlr4;

public class NLogErrorListener: ITemplateErrorListener
{
    private readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    public void CompiletimeError(TemplateMessage msg)
    {
        Logger.Error(msg.ToString());
    }

    public void RuntimeError(TemplateMessage msg)
    {
        Logger.Error(msg.ToString());
    }

    public void IOError(TemplateMessage msg)
    {
        Logger.Error(msg.ToString());
    }

    public void InternalError(TemplateMessage msg)
    {
        Logger.Error(msg.ToString());
    }
}