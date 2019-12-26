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
    /// TokensResponseSentences
    /// </summary>
    [DataContract]
    public partial class TokensResponseSentences :  IEquatable<TokensResponseSentences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensResponseSentences" /> class.
        /// </summary>
        /// <param name="tokens">Sentence tokens.</param>
        public TokensResponseSentences(List<TokensResponseTokens> tokens = default(List<TokensResponseTokens>))
        {
            this.Tokens = tokens;
        }
        
        /// <summary>
        /// Sentence tokens
        /// </summary>
        /// <value>Sentence tokens</value>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public List<TokensResponseTokens> Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokensResponseSentences {\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(input as TokensResponseSentences);
        }

        /// <summary>
        /// Returns true if TokensResponseSentences instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensResponseSentences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensResponseSentences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
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
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
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
