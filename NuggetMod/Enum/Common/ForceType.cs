namespace NuggetMod.Enum.Common;

/// <summary>
/// Defines file consistency enforcement types for client-server synchronization
/// </summary>
public enum ForceType
{
    /// <summary>
    /// File on client must exactly match server's file
    /// </summary>
    force_exactfile,
    
    /// <summary>
    /// For model files only, the geometry must fit in the same bounding box
    /// </summary>
    force_model_samebounds,
    
    /// <summary>
    /// For model files only, the geometry must fit in the specified bounding box
    /// </summary>
    force_model_specifybounds,
    
    /// <summary>
    /// For Steam model files only, the geometry must fit in the specified bounding box (if the file is available)
    /// </summary>
    force_model_specifybounds_if_avail,
}
