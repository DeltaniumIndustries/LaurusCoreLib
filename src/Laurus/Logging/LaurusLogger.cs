using UnityEngine;

public class LL
{
    public static void Info(string msg, LogCategory catgeory)
    {
        if (!ConfigHandler.GLOBAL_LOGGING_ENABLED)
        {
            return;
        }
        if (!string.IsNullOrEmpty(msg))
        {
            var prefixText = "[Laurus]" + catgeory != null ? "[" + catgeory.ToString().ToUpper() + "]" : "" + " ";
            var modifiedS = prefixText + msg;
            XRL.Messages.MessageQueue.AddPlayerMessage(modifiedS);
            Debug.LogError(modifiedS);
        }
        else
        {
            Debug.LogWarning("[Laurus] Attempted to log an empty or null message.");
        }
    }
}
