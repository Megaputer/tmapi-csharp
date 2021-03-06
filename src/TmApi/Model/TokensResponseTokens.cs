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
    /// TokensResponseTokens
    /// </summary>
    [DataContract]
    public partial class TokensResponseTokens :  IEquatable<TokensResponseTokens>, IValidatableObject
    {
        /// <summary>
        /// Assigns a word to a morphological category according to each syntactic functions.
        /// </summary>
        /// <value>Assigns a word to a morphological category according to each syntactic functions.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartOfSpeechEnum
        {
            /// <summary>
            /// Enum Noun for value: Noun
            /// </summary>
            [EnumMember(Value = "Noun")]
            Noun = 1,

            /// <summary>
            /// Enum Verb for value: Verb
            /// </summary>
            [EnumMember(Value = "Verb")]
            Verb = 2,

            /// <summary>
            /// Enum Adverb for value: Adverb
            /// </summary>
            [EnumMember(Value = "Adverb")]
            Adverb = 3,

            /// <summary>
            /// Enum Adjective for value: Adjective
            /// </summary>
            [EnumMember(Value = "Adjective")]
            Adjective = 4,

            /// <summary>
            /// Enum Particle for value: Particle
            /// </summary>
            [EnumMember(Value = "Particle")]
            Particle = 5,

            /// <summary>
            /// Enum Pronoun for value: Pronoun
            /// </summary>
            [EnumMember(Value = "Pronoun")]
            Pronoun = 6,

            /// <summary>
            /// Enum Numeral for value: Numeral
            /// </summary>
            [EnumMember(Value = "Numeral")]
            Numeral = 7,

            /// <summary>
            /// Enum Special for value: Special
            /// </summary>
            [EnumMember(Value = "Special")]
            Special = 8,

            /// <summary>
            /// Enum Punctuation for value: Punctuation
            /// </summary>
            [EnumMember(Value = "Punctuation")]
            Punctuation = 9

        }

        /// <summary>
        /// Assigns a word to a morphological category according to each syntactic functions.
        /// </summary>
        /// <value>Assigns a word to a morphological category according to each syntactic functions.</value>
        [DataMember(Name="partOfSpeech", EmitDefaultValue=false)]
        public PartOfSpeechEnum? PartOfSpeech { get; set; }
        /// <summary>
        /// Indicates a way of writing a token with the previous one. It returns \&quot;1\&quot;, if tokens are written as a single token. It returns \&quot;0\&quot;, if tokens are written separately. 
        /// </summary>
        /// <value>Indicates a way of writing a token with the previous one. It returns \&quot;1\&quot;, if tokens are written as a single token. It returns \&quot;0\&quot;, if tokens are written separately. </value>
        public enum IsExtensionEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1

        }

        /// <summary>
        /// Indicates a way of writing a token with the previous one. It returns \&quot;1\&quot;, if tokens are written as a single token. It returns \&quot;0\&quot;, if tokens are written separately. 
        /// </summary>
        /// <value>Indicates a way of writing a token with the previous one. It returns \&quot;1\&quot;, if tokens are written as a single token. It returns \&quot;0\&quot;, if tokens are written separately. </value>
        [DataMember(Name="isExtension", EmitDefaultValue=false)]
        public IsExtensionEnum? IsExtension { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensResponseTokens" /> class.
        /// </summary>
        /// <param name="word">Word as in text.</param>
        /// <param name="lemma">A dictionary form of a word, e.g. given verb forms \&quot;run\&quot;, \&quot;ran\&quot; and \&quot;runs\&quot;, \&quot;run\&quot; is the lemma.</param>
        /// <param name="partOfSpeech">Assigns a word to a morphological category according to each syntactic functions..</param>
        /// <param name="modifier">One of the grammatical categories of a word, e.g. person for verbs or number for nouns. Each part of speech has its own set of modifiers.  The detailed list of parameters can be found in Help to TM API Server. .</param>
        /// <param name="isExtension">Indicates a way of writing a token with the previous one. It returns \&quot;1\&quot;, if tokens are written as a single token. It returns \&quot;0\&quot;, if tokens are written separately. .</param>
        /// <param name="position">position.</param>
        public TokensResponseTokens(string word = default(string), string lemma = default(string), PartOfSpeechEnum? partOfSpeech = default(PartOfSpeechEnum?), Object modifier = default(Object), IsExtensionEnum? isExtension = default(IsExtensionEnum?), TokensResponsePosition position = default(TokensResponsePosition))
        {
            this.Word = word;
            this.Lemma = lemma;
            this.PartOfSpeech = partOfSpeech;
            this.Modifier = modifier;
            this.IsExtension = isExtension;
            this.Position = position;
        }
        
        /// <summary>
        /// Word as in text
        /// </summary>
        /// <value>Word as in text</value>
        [DataMember(Name="word", EmitDefaultValue=false)]
        public string Word { get; set; }

        /// <summary>
        /// A dictionary form of a word, e.g. given verb forms \&quot;run\&quot;, \&quot;ran\&quot; and \&quot;runs\&quot;, \&quot;run\&quot; is the lemma
        /// </summary>
        /// <value>A dictionary form of a word, e.g. given verb forms \&quot;run\&quot;, \&quot;ran\&quot; and \&quot;runs\&quot;, \&quot;run\&quot; is the lemma</value>
        [DataMember(Name="lemma", EmitDefaultValue=false)]
        public string Lemma { get; set; }


        /// <summary>
        /// One of the grammatical categories of a word, e.g. person for verbs or number for nouns. Each part of speech has its own set of modifiers.  The detailed list of parameters can be found in Help to TM API Server. 
        /// </summary>
        /// <value>One of the grammatical categories of a word, e.g. person for verbs or number for nouns. Each part of speech has its own set of modifiers.  The detailed list of parameters can be found in Help to TM API Server. </value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        public Object Modifier { get; set; }


        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public TokensResponsePosition Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokensResponseTokens {\n");
            sb.Append("  Word: ").Append(Word).Append("\n");
            sb.Append("  Lemma: ").Append(Lemma).Append("\n");
            sb.Append("  PartOfSpeech: ").Append(PartOfSpeech).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  IsExtension: ").Append(IsExtension).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as TokensResponseTokens);
        }

        /// <summary>
        /// Returns true if TokensResponseTokens instances are equal
        /// </summary>
        /// <param name="input">Instance of TokensResponseTokens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokensResponseTokens input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Word == input.Word ||
                    (this.Word != null &&
                    this.Word.Equals(input.Word))
                ) && 
                (
                    this.Lemma == input.Lemma ||
                    (this.Lemma != null &&
                    this.Lemma.Equals(input.Lemma))
                ) && 
                (
                    this.PartOfSpeech == input.PartOfSpeech ||
                    (this.PartOfSpeech != null &&
                    this.PartOfSpeech.Equals(input.PartOfSpeech))
                ) && 
                /*(
                    this.Modifier == input.Modifier ||
                    this.Modifier != null &&
                    this.Modifier.SequenceEqual(input.Modifier)
                ) && */
                (
                    this.IsExtension == input.IsExtension ||
                    (this.IsExtension != null &&
                    this.IsExtension.Equals(input.IsExtension))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.Word != null)
                    hashCode = hashCode * 59 + this.Word.GetHashCode();
                if (this.Lemma != null)
                    hashCode = hashCode * 59 + this.Lemma.GetHashCode();
                if (this.PartOfSpeech != null)
                    hashCode = hashCode * 59 + this.PartOfSpeech.GetHashCode();
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.IsExtension != null)
                    hashCode = hashCode * 59 + this.IsExtension.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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
