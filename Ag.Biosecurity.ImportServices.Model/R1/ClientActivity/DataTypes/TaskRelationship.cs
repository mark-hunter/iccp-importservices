using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Task = Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.Task;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;

public class TaskRelationship
{
    public Reference<Task>? RelatedTask { get; set; }
    public CodeableConcept? RelationshipType { get; set; }
}