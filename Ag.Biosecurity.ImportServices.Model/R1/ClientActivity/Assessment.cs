using Ag.Biosecurity.ImportServices.Model.R1.Base;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
using Ag.Biosecurity.ImportServices.Model.R1.Regulatory;

namespace Ag.Biosecurity.ImportServices.Model.R1.ClientActivity;

public class Assessment : ClientActivity.Task
{
    /// <summary>
    /// The AssessmentSubject typically points to either an Entity (Person, Organisation), EntityRole
    /// (TreatmentProvider, Broker, etc.) or ImportDeclarationEntry
    /// </summary>
    public Reference<BaseResource>? AssessmentSubject { get; set; }
    /// <summary>
    /// The AssessmentType provides a broad grouping of the type of Assessment being performed. 
    /// </summary>
    public CodeableConcept? AssessmentType { get; set; }
    /// <summary>
    /// The AssessmentSpeciality provides a fine-grain detail of the type of Assessment being performed. 
    /// </summary>
    public CodeableConcept? AssessmentSpeciality { get; set; }
    /// <summary>
    /// The AssessedApplications links to all the Application resources that relate to the assessment process.
    /// </summary>
    public List<Reference<Application>> AssessedApplications { get; set; }
    /// <summary>
    /// The IdentifiedPolicy links to any identified Policy or Regulatory information as well as Legal details.
    /// </summary>
    public List<Reference<Policy>> IdentifiedPolicy { get; set; }
    /// <summary>
    /// The RelatedConcerns links to any identified Concerns that have been identified prior to or as part of the
    /// Assessment activity.
    /// </summary>
    public List<Reference<Concern>> RelatedConcerns { get; set; }
    /// <summary>
    /// The RelatedRisks links to any identified Risks that have been identified prior to or as part of the
    /// Assessment activity.
    /// </summary>
    public List<Reference<Risk>> RelatedRisks { get; set; }
    /// <summary>
    /// The Findings links to any Finding resources that have been generated as part of the
    /// Assessment activity.
    /// </summary>
    public List<Reference<Finding>> Findings { get; set; }
    
    public Assessment() : base()
    {
        ResourceType = GetType().Name;
        AssessedApplications = new List<Reference<Application>>();
        IdentifiedPolicy = new List<Reference<Policy>>();
        RelatedConcerns = new List<Reference<Concern>>();
        RelatedRisks = new List<Reference<Risk>>();
        Findings = new List<Reference<Finding>>();
    }
}