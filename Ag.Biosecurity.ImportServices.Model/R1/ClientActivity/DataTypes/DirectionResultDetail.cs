using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;

/// <summary>
/// The DirectionResultDetail datatype captures the result for a given Direction or DirectionTargetDetail.
/// </summary>
public class DirectionResultDetail : DataTypeMetadata
{
    DirectionResultType? ResultType { get; set; }
    string? ResultDescription { get; set; }
}