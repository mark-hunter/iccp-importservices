using System.Text.Json.Serialization;
using Ag.Biosecurity.ImportServices.Model.R1.Base.Exceptions;

namespace Ag.Biosecurity.ImportServices.Model.R1.Base.Datatypes;

public abstract class ValueDataType : Coding
{
    protected static bool EqualOperator(ValueDataType left, ValueDataType right)
    {
        if (left is null ^ right is null)
        {
            return false;
        }

        return left?.Equals(right!) != false;
    }

    protected static bool NotEqualOperator(ValueDataType left, ValueDataType right)
    {
        return !(EqualOperator(left, right));
    }

    protected abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }

        var other = (ValueDataType)obj;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        var hash = new HashCode();

        foreach (var component in GetEqualityComponents())
        {
            hash.Add(component);
        }

        return hash.ToHashCode();
    }

    [JsonIgnore]
    public CodeableConcept AsCodeableConcept
    {
        get {
            Coding coding = new Coding();
            coding.Code = Code;
            coding.LongCode = LongCode;
            coding.Text = Text;
            coding.CodeSystem = CodeSystem;
            coding.CodeVersion = CodeVersion;
            coding.LegacyGuid = LegacyGuid;
            CodeableConcept codeableConcept = new CodeableConcept();
            codeableConcept.Codings.Add(coding);
            if(string.IsNullOrEmpty(Name))
            {
                codeableConcept.Value = Code;
            }
            else
            {
                codeableConcept.Value = Name;
            }
            if(string.IsNullOrEmpty(Text))
            {
                codeableConcept.DisplayText = Code;
            }
            else 
            {
                codeableConcept.DisplayText = Text;
            }
            return(codeableConcept);
        }
        set {
            if(value.Codings.Count < 1){
                throw new UnsupportedCodeableConceptException("No Codings in CodeableConcept");
            }
            Coding coding = value.Codings[0];
            Code = coding.Code;
            LongCode = coding.LongCode;
            Text = coding.Text;
            CodeSystem = coding.CodeSystem;
            CodeVersion = coding.CodeVersion;
            LegacyGuid = coding.LegacyGuid;
            Name = coding.Name;
        }
    }
}