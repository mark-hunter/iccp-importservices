namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;

public class TaskDetail
{
    /// <summary>
    /// The TaskQualifiers contains the details which customise the associated TaskDefinition for this specific
    /// Task instance.
    /// </summary>
    public List<TaskQualifier> TaskQualifiers { get; set; }

    public TaskDetail()
    {
        TaskQualifiers = new List<TaskQualifier>();
    }
}