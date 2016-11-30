// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a backup schedule. Describes how often should be the
    /// backup performed and what should be the retention policy.
    /// </summary>
    public partial class BackupSchedule
    {
        /// <summary>
        /// Initializes a new instance of the BackupSchedule class.
        /// </summary>
        public BackupSchedule() { }

        /// <summary>
        /// Initializes a new instance of the BackupSchedule class.
        /// </summary>
        public BackupSchedule(FrequencyUnit frequencyUnit, int? frequencyInterval = default(int?), bool? keepAtLeastOneBackup = default(bool?), int? retentionPeriodInDays = default(int?), DateTime? startTime = default(DateTime?), DateTime? lastExecutionTime = default(DateTime?))
        {
            FrequencyInterval = frequencyInterval;
            FrequencyUnit = frequencyUnit;
            KeepAtLeastOneBackup = keepAtLeastOneBackup;
            RetentionPeriodInDays = retentionPeriodInDays;
            StartTime = startTime;
            LastExecutionTime = lastExecutionTime;
        }

        /// <summary>
        /// How often should be the backup executed (e.g. for weekly backup,
        /// this should be set to 7 and FrequencyUnit should be set to Day)
        /// </summary>
        [JsonProperty(PropertyName = "frequencyInterval")]
        public int? FrequencyInterval { get; set; }

        /// <summary>
        /// How often should be the backup executed (e.g. for weekly backup,
        /// this should be set to Day and FrequencyInterval should be set to
        /// 7). Possible values include: 'Day', 'Hour'
        /// </summary>
        [JsonProperty(PropertyName = "frequencyUnit")]
        public FrequencyUnit FrequencyUnit { get; set; }

        /// <summary>
        /// True if the retention policy should always keep at least one
        /// backup in the storage account, regardless how old it is; false
        /// otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "keepAtLeastOneBackup")]
        public bool? KeepAtLeastOneBackup { get; set; }

        /// <summary>
        /// After how many days backups should be deleted
        /// </summary>
        [JsonProperty(PropertyName = "retentionPeriodInDays")]
        public int? RetentionPeriodInDays { get; set; }

        /// <summary>
        /// When the schedule should start working
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The last time when this schedule was triggered
        /// </summary>
        [JsonProperty(PropertyName = "lastExecutionTime")]
        public DateTime? LastExecutionTime { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
