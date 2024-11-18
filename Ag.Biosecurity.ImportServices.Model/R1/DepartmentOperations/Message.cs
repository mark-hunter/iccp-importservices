using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.DataTypes;

namespace Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations;

public class Message : BaseResource
{
    public BaseResource? messageContent { get; set; }
    public DateTime? messageReceiveDateTime { get; set; }
    public DateTime? messageSendDateTime { get; set; }
    public ComponentID? messageComponentID { get; set; }
    public ComponentID? targetComponentID { get; set; }
    public CodeableConcept messageType { get; set; }
}