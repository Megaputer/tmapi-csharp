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
    /// FactsResponsePositions
    /// </summary>
    [DataContract]
    public partial class FactsResponsePositions :  IEquatable<FactsResponsePositions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FactsResponsePositions" /> class.
        /// </summary>
        /// <param name="sentence">Sentence index.</param>
        /// <param name="begin">Index of first token of fact.</param>
        /// <param name="length">Number of tokens in fact.</param>
        public FactsResponsePositions(int? sentence = default(int?), int? begin = default(int?), int? length = default(int?))
        {
            this.Sentence = sentence;
            this.Begin = begin;
            this.Length = length;
        }
        
        /// <summary>
        /// Sentence index
        /// </summary>
        /// <value>Sentence index</value>
        [DataMember(Name="sentence", EmitDefaultValue=false)]
        public int? Sentence { get; set; }

        /// <summary>
        /// Index of first token of fact
        /// </summary>
        /// <value>Index of first token of fact</value>
        [DataMember(Name="begin", EmitDefaultValue=false)]
        public int? Begin { get; set; }

        /// <summary>
        /// Number of tokens in fact
        /// </summary>
        /// <value>Number of tokens in fact</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FactsResponsePositions {\n");
            sb.Append("  Sentence: ").Append(Sentence).Append("\n");
            sb.Append("  Begin: ").Append(Begin).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
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
            return this.Equals(input as FactsResponsePositions);
        }

        /// <summary>
        /// Returns true if FactsResponsePositions instances are equal
        /// </summary>
        /// <param name="input">Instance of FactsResponsePositions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FactsResponsePositions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sentence == input.Sentence ||
                    (this.Sentence != null &&
                    this.Sentence.Equals(input.Sentence))
                ) && 
                (
                    this.Begin == input.Begin ||
                    (this.Begin != null &&
                    this.Begin.Equals(input.Begin))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
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
                if (this.Sentence != null)
                    hashCode = hashCode * 59 + this.Sentence.GetHashCode();
                if (this.Begin != null)
                    hashCode = hashCode * 59 + this.Begin.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
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
