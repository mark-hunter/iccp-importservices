using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.ReferenceArchitypes.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity.DataTypes;

/// <summary>
/// The DirectionTargetDetail links a Direction to the Container and/or ImportDeclarationLineItem (Entry Line) for
/// which the Declaration is required.
/// </summary>
public class DirectionTargetDetail : DataTypeMetadata
{
    public DirectionLevelType? DirectionLevel { get; set; }
    public DirectionResultDetail? DirectionResult { get; set; }
    public Reference<BaseResource>? DirectionTarget { get; set; }

    public DirectionTargetDetail() : base()
    {
    }
    
    
}