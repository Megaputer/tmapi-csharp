/* 
 * Megaputer Text Mining API
 *
 * Megaputer Text Mining API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TmApi.Client.OpenAPIDateConverter;

namespace TmApi.Model
{
    /// <summary>
    /// Documents
    /// </summary>
    [DataContract]
    public partial class Documents :  IEquatable<Documents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Documents" /> class.
        /// </summary>
        /// <param name="files">files.</param>
        public Documents(List<Document> files = default(List<Document>))
        {
            this.Files = files;
        }
        
        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<Document> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Documents {\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Documents);
        }

        /// <summary>
        /// Returns true if Documents instances are equal
        /// </summary>
        /// <param name="input">Instance of Documents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Documents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}