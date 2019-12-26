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
    /// AsyncTaskResponse
    /// </summary>
    [DataContract]
    public partial class AsyncTaskResponse :  IEquatable<AsyncTaskResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTaskResponse" /> class.
        /// </summary>
        /// <param name="taskId">Identifier of the newly created task, which has been started on the server..</param>
        public AsyncTaskResponse(string taskId = default(string))
        {
            this.TaskId = taskId;
        }
        
        /// <summary>
        /// Identifier of the newly created task, which has been started on the server.
        /// </summary>
        /// <value>Identifier of the newly created task, which has been started on the server.</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncTaskResponse {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
            return this.Equals(input as AsyncTaskResponse);
        }

        /// <summary>
        /// Returns true if AsyncTaskResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AsyncTaskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
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
