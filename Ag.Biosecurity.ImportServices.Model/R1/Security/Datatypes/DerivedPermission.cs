using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

/// <summary>
/// DerivedPermission: Encapsulates a set of actions that may be applied to data that meets ALL of the criteria specified
/// in the associated Privacy, Classification and DataCompartment markers. If not no markers are specified for an aspect,
/// then it is assumed that ALL markers for that aspect are supported.
/// </summary>
public class DerivedPermission
{
    /// <summary>
    /// PrivacyMarkers: Encapsulates a List of Privacy Markers for which the Permission is valid. If no Privacy Markers
    /// are defined, then it is assumed that ALL Privacy Markers are valid.
    /// </summary>
    public List<CodeableConcept> PrivacyMarkers { get; set; }
    /// <summary>
    /// PrivacyMarkers: Encapsulates a List of Data Classification Markers for which the Permission is valid. If no
    /// Data Classification Markers are defined, then it is assumed that ALL Privacy Markers are valid.
    /// </summary>
    public List<CodeableConcept> ClassificationMarkers { get; set; }
    /// <summary>
    /// DataCompartmentMarkers: Encapsulates the List of Data Compartments used to group resources/classes to which
    /// this Permission is valid. If no markers are included in the list, then the permission is invalid.
    /// </summary>
    public List<CodeableConcept> DataCompartmentMarkers { get; set; }
    /// <summary>
    /// PermittedActions: A set of "verbs" or "actions" that can be applied to the resources/classes/attributes that
    /// are identified by the lists of markers.
    /// </summary>
    public List<CodeableConcept> PermittedActions { get; set; }
    
    public DerivedPermission()
    {
        PrivacyMarkers = new List<CodeableConcept>();
        ClassificationMarkers = new List<CodeableConcept>();
        DataCompartmentMarkers = new List<CodeableConcept>();
        PermittedActions = new List<CodeableConcept>();
    }
}