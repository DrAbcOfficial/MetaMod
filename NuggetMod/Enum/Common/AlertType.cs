namespace NuggetMod.Enum.Common;

/// <summary>
/// Defines alert message types for the game engine
/// </summary>
public enum AlertType
{
    /// <summary>
    /// Notice message
    /// </summary>
    at_notice,
    
    /// <summary>
    /// Console message (same as at_notice, but forces a ConPrintf, not a message box)
    /// </summary>
    at_console,
    
    /// <summary>
    /// AI console message (same as at_console, but only shown if developer level is 2)
    /// </summary>
    at_aiconsole,
    
    /// <summary>
    /// Warning message
    /// </summary>
    at_warning,
    
    /// <summary>
    /// Error message
    /// </summary>
    at_error,
    
    /// <summary>
    /// Logged message (server print to console, only in multiplayer games)
    /// </summary>
    at_logged
}
