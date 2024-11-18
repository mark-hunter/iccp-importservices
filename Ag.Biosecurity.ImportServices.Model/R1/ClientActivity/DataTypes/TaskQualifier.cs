using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;

/// <summary>
/// The TaskQualifier captures a set of modifiers (or instance details) associated with a TaskDefinition that
/// will provide information pertaining to a specific INSTANCE of a Task.
/// </summary>
public class TaskQualifier
{

    /// <summary>
    /// The Task Architype (or Definition) which is then customised/qualified by the other attributes.
    /// </summary>
    public Reference<ClientActivity.Task>? TaskDefinition { get; set; }
    
    /// <summary>
    /// A set of caveats and/or instructions that are specific to a Task instance which "qualify" the base TaskDefinition
    /// with any details needed for the specific instance.
    /// </summary>
    public Dictionary<string, string> Qualifiers { get; set; }
    
    public TaskQualifier()
    {
        Qualifiers = new Dictionary<string, string>();
    }
}