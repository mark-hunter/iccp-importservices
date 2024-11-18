using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Base;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;
using Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

/// <summary>
/// The Appointment object represents both an established (confirmed) appointment,
/// as well as a request for an appointment. It contains details about the Entities
/// (Client, ServiceProvider, etc.) involved into the appointment activity, any location
/// details, temporal information and identifies any services involved.
/// </summary>
public class Appointment : ClientActivityBaseResource
{
    
    public List<Reference<Task>> AssociatedTasks { get; set; }
    public DateTime? StartDateTime { get; set; }
    public DateTime? EndDateTime { get; set; }
    public int? Duration { get; set; }
    public List<EntityRole> Participants { get; set; }
    public CodeableConcept? MeetingReason { get; set; }
    public CodeableConcept? MeetingType { get; set; }
    public Location? MeetingLocation { get; set; }
    
    public Appointment()
    {
        ResourceType = GetType().Name;
        SecurityMarker appointmentSecurityMarker = new SecurityMarker(DataCompartmentEnum.ClientActivityResourceCompartment, DataClassificationType.Organisational, DataPrivacyEnum.Public);
        Meta.SecurityMarkers.Add(appointmentSecurityMarker);
        Participants = new List<EntityRole>();
        AssociatedTasks = new List<Reference<Task>>();
    }


}