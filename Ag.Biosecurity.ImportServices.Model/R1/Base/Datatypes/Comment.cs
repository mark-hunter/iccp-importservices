namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

public class Comment : DataTypeMetadata
{
    public string? CommentData { get; set; }
    public string? AuthoredBy { get; set; }

    public Comment() : base()
    {

    }
}