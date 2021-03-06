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
    /// TotalLimitConstantResponse
    /// </summary>
    [DataContract]
    public partial class TotalLimitConstantResponse :  IEquatable<TotalLimitConstantResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalLimitConstantResponse" /> class.
        /// </summary>
        /// <param name="nTULimit">The maximum number of text units that can be processed in all time.</param>
        /// <param name="nTU">Counter of text units that have been already processed.</param>
        public TotalLimitConstantResponse(int? nTULimit = default(int?), int? nTU = default(int?))
        {
            this.NTULimit = nTULimit;
            this.NTU = nTU;
        }
        
        /// <summary>
        /// The maximum number of text units that can be processed in all time
        /// </summary>
        /// <value>The maximum number of text units that can be processed in all time</value>
        [DataMember(Name="NTULimit", EmitDefaultValue=false)]
        public int? NTULimit { get; set; }

        /// <summary>
        /// Counter of text units that have been already processed
        /// </summary>
        /// <value>Counter of text units that have been already processed</value>
        [DataMember(Name="NTU", EmitDefaultValue=false)]
        public int? NTU { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalLimitConstantResponse {\n");
            sb.Append("  NTULimit: ").Append(NTULimit).Append("\n");
            sb.Append("  NTU: ").Append(NTU).Append("\n");
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
            return this.Equals(input as TotalLimitConstantResponse);
        }

        /// <summary>
        /// Returns true if TotalLimitConstantResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalLimitConstantResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalLimitConstantResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NTULimit == input.NTULimit ||
                    (this.NTULimit != null &&
                    this.NTULimit.Equals(input.NTULimit))
                ) && 
                (
                    this.NTU == input.NTU ||
                    (this.NTU != null &&
                    this.NTU.Equals(input.NTU))
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
                if (this.NTULimit != null)
                    hashCode = hashCode * 59 + this.NTULimit.GetHashCode();
                if (this.NTU != null)
                    hashCode = hashCode * 59 + this.NTU.GetHashCode();
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
