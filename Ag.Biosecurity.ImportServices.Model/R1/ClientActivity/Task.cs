using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Base;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;
using Ag.Biosecurity.ImportServices.Model.R1.Operations.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

/// <summary>
/// A Task is a well-defined parcel of work that is to be completed by an Internal or External (to the Department)
/// Entity or EntityRole.
/// </summary>
public class Task : ClientActivityBaseResource
{

    /// <summary>
    /// The OperationalCaseActivities links the Task to the (internal) software defined case management services
    /// associated with processing various departmental activities.
    /// </summary>
    public List<Reference<ImportCaseActivity>> OperationalCaseActivities { get; set; } // References to the Operations::ImportCaseActivity resources

    /// <summary>
    /// The TaskDetails contains a list of TaskQualifiers which are used to customise the task archetype (TaskDefinition)
    /// for this specific instance.
    /// </summary>
    public List<TaskDetail> TaskDetails { get; set; }
    public List<Reference<Appointment>> Appointments { get; set; }
    public List<TaskRelationship> AssociatedTasks { get; set; }
    
    /// <summary>
    /// The FulfillerType defines the type of Entity or EntityRole that the task needs to be fulfilled by.
    /// </summary>
    public CodeableConcept? FulfillerType { get; set; }
    /// <summary>
    /// The Fulfiller links to the actual Entity or EntityRole that fulfilled the task.
    /// </summary>
    public Reference<EntityRole>? Fulfiller { get; set; }
    /// <summary>
    /// The Owner attribute links the Task to the identified Owner of the Task.
    /// </summary>
    public Reference<EntityRole>? TaskOwner { get; set; }
    public TaskPriorityType? TaskPriority { get; set; }
    public TaskCategoryType? TaskCategory { get; set; }
    
    
    public Task() : base()
    {
        ResourceType = GetType().Name;
        OperationalCaseActivities = new List<Reference<ImportCaseActivity>>();
        TaskDetails = new List<TaskDetail>();
        Appointments = new List<Reference<Appointment>>();
        AssociatedTasks = new List<TaskRelationship>();
    }
}