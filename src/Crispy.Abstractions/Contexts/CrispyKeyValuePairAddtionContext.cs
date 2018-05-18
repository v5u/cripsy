﻿namespace Crispy.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using ModelRules = CrispyConstants.ModelRules.KeyValuePair;

    public class CrispyKeyValuePairAddtionContext
    {
        public Guid? EnvironmentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "配置的 Key 为空")]
        //[Range(1, ModelRules.KeyMaxLength, ErrorMessage = "配置的 Key 长度应为 1 - 50")]
        [MinLength(1, ErrorMessage = "配置的 Key 长度应大于 1 ")]
        [MaxLength(ModelRules.KeyMaxLength, ErrorMessage = "配置的 Key 长度应小于等于 50")]
        public string Key { get; set; }

        //[Range(0, ModelRules.ValueMaxLength, ErrorMessage = "配置的 Value 长度应为 0 - 1280")]
        [MinLength(1, ErrorMessage = "配置的 Value 长度应大于 1 ")]
        [MaxLength(ModelRules.ValueMaxLength, ErrorMessage = "配置的 Value 长度应小于等于 1280")]
        public string Value { get; set; }

        public CrispyKeyValueValueType ValueType { get; set; }

        //[Range(0, ModelRules.DescriptionMaxLength, ErrorMessage = "配置的描述长度应为 1 - 100")]
        [MinLength(1, ErrorMessage = "配置的描述长度应大于 1 ")]
        [MaxLength(ModelRules.DescriptionMaxLength, ErrorMessage = "配置的描述长度应小于等于 1280")]
        public string Description { get; set; }
    }
}
