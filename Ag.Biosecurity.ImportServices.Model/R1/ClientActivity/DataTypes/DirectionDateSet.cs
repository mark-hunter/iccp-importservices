using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;

public class DirectionDateSet : DataTypeMetadata
{
    public Identifier? Id { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? FollowUpDate { get; set; }
    public DateTime? SystemCalculatedDueDate { get; set; }
    public DateTime? InitiatingDate {get; set;}
    public DateTime? CompletionDate {get; set;}

    public DirectionDateSet(): base()
    {

    }
}