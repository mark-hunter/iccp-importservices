using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Entity;

namespace Ag.Biosecurity.ImportServices.Model.R1.Artifacts;

/// <summary>
/// The Certificate resource encapsulates a formal statement of compliance, achievement or 
/// capability. It may include a media (a physical artifact) which will be referenced/included
/// as an 
/// </summary>
public class Certificate : Document
{
    public Reference<EntityRole>? Issuer { get; set; }
    public Reference<EntityRole>? CertifyingAuthority { get; set; }
    public CodeableConcept? CertificateType { get; set; }
    public CodeableConcept? CertificateSubject { get; set; }

    public Certificate() : base()
    {
      ResourceType = GetType().Name;
    }
}
