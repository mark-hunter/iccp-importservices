namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;
/// <summary>
/// The Attachment datatype is for containing or referencing attachments - additional data content defined in 
/// other formats. The most common use of this type is to include images or reports in some report format 
/// such as PDF. However, it can be used for any data that has a MIME type.
/// </summary>
public class Attachment : DataTypeMetadata
{
    /// </summary>
    /// The Title attribute is a label to be used in-place of the data.
    /// <summary>
    public string? Title { get; set; }
    /// </summary>
    /// The ContentType attribute is typically defined as a MIME-type and describes the content type of the Attachment.
    /// <summary>
    public CodeableConcept? ContentType { get; set; }
    /// <summary>
    /// The ContentData attributes provides a mechanism to capture the content "inline" of the Attachment (sizing
    /// issues not-withstanding).
    /// </summary>
    public byte[]? ContentData{ get; set; }
    /// <summary>
    /// The ContentSize attribute details the number of bytes of content (if URI provided)
    /// </summary>
    public int? ContentSize{ get; set; }
    /// <summary>
    /// The ContentCreationDate of the content (if known)
    /// </summary>
    public DateTime? ContentCreationDate{ get; set; }
    /// <summary>
    /// The ContentUpdateDate of the content (if known)
    /// </summary>
    public DateTime? ContentUpdateDate{ get; set; }
    /// <summary>
    /// The ContentReceiveDate of the content as received by the system (if known)
    /// </summary>
    public DateTime? ContentReceiveDate{ get; set; }
    /// <summary>
    /// The ContentLanguage of the content if known.
    /// </summary>
    public CodeableConcept? ContentLanguage{ get; set; }
    /// <summary>
    /// The ContentLocation of the content if stored externally.
    /// </summary>
    public Uri? ContentLocation{ get; set; }

}