using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.DepartmentOperations.ValueSets;
using Ag.Biosecurity.ImportServices.Model.R1.Security.ValueSets;

namespace Ag.Biosecurity.ImportServices.Model.R1.Security.Datatypes;

public class SecurityMarker
{
    public CodeableConcept? DataClassification { get; set; }
    public CodeableConcept? DataCompartment { get; set; }
    public CodeableConcept? DataPrivacy { get; set; }
    
    public SecurityMarker()
    {
        DataClassification = DataClassificationType.None.AsCodeableConcept;
        DataCompartment = DataCompartmentFactory.ToCodeableConcept(DataCompartmentEnum.Unknown);
        DataPrivacy = DataPrivacyFactory.ToCodeableConcept(DataPrivacyEnum.None);
    }

    public SecurityMarker(DataCompartmentEnum compartment, DataClassificationType classification,
        DataPrivacyEnum privacy)
    {
        DataClassification = classification.AsCodeableConcept;
        DataCompartment = DataCompartmentFactory.ToCodeableConcept(compartment);
        DataPrivacy = DataPrivacyFactory.ToCodeableConcept(privacy);
    }


}