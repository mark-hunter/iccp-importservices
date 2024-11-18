using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// ExplicitPermission: Encapsulates a set of actions that may be applied to data that is explicitly specified
/// in the ResourceTypes attribute. If no resources are specified, then it is assumed that this Permission is 
/// invalid (or has no outcome).
/// </summary>
public class ExplicitPermission
{
    /// <summary>
    /// PermittedActions: A set of "verbs" or "actions" that can be applied to the resources/classes/attributes that
    /// are explicitly identified in the ResourceTypes attribute.
    /// </summary>
    public List<CodeableConcept> PermittedActions { get; set; }
    /// <summary>
    /// ResourceTypes: A set of Resource names and/or Attribute names (expressed as Class.Attribute) to which the
    /// set of permitted actions are applicable. 
    /// </summary>
    public List<string> ResourceTypes { get; set; }
    
    public ExplicitPermission()
    {
        PermittedActions = new List<CodeableConcept>();
        ResourceTypes = new List<string>();
    }
}