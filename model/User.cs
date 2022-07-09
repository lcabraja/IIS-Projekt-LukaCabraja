using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace model
{
    [DataContract]
    public class User
    {
        public static readonly string RNG = "<element name=\"User\" xmlns=\"http://relaxng.org/ns/structure/1.0\" datatypeLibrary=\"http://www.w3.org/2001/XMLSchema-datatypes\" ns=\"http://schemas.datacontract.org/2004/07/model\"><element name=\"ID\"><text /></element><element name=\"Username\"><text /></element><element name=\"PasswordHash\"><text /></element><element name=\"Images\"><zeroOrMore><element name=\"Image\"><element name=\"ResourceTitle\"><text /></element><element name=\"ResourceURL\"><text /></element><element name=\"IsFavorite\"><text /></element></element></zeroOrMore></element></element>";
        public static readonly string XSD = "<xs:schema attributeFormDefault=\"unqualified\" elementFormDefault=\"qualified\" targetNamespace=\"http://schemas.datacontract.org/2004/07/model\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\"><xs:element name=\"User\"><xs:complexType><xs:sequence><xs:element type=\"xs:string\" name=\"ID\"/><xs:element type=\"xs:string\" name=\"Username\"/><xs:element type=\"xs:string\" name=\"PasswordHash\"/><xs:element name=\"Images\"><xs:complexType><xs:sequence><xs:element name=\"Image\" maxOccurs=\"unbounded\" minOccurs=\"0\"><xs:complexType><xs:sequence><xs:element type=\"xs:string\" name=\"ResourceTitle\"/><xs:element type=\"xs:string\" name=\"ResourceURL\"/><xs:element type=\"xs:string\" name=\"IsFavorite\"/></xs:sequence></xs:complexType></xs:element></xs:sequence></xs:complexType></xs:element></xs:sequence></xs:complexType></xs:element></xs:schema>";

        [DataMember(Order = 0)]
        public string ID { get; set; }
        [DataMember(Order = 1)]
        public string Username { get; set; }
        [DataMember(Order = 2)]
        public string PasswordHash { get; set; }
        [DataMember(Order = 3)]
        public List<Image> Images { get; set; }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is User user)
            {
                return ID.Equals(user.ID);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() + 1 * 42;
        }
        public override string ToString()
        {
            var s = Images.Count > 1 ? "s" : "";
            return $"@{ID} {Username} [{Images.Count} Image{s}]";
        }
    }
}
