﻿namespace Crispy.Abstractions
{
    using JetBrains.Annotations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICrispyEnviromentService
    {
        Task<CrispyEnvironmentInfoResponse> GetInfoAsync([NotNull]Guid id);
        Task<CrispyEnvironment> AddAsync([NotNull]CrispyEnvironmentAddtionContext context);
        Task<CrispyEnvironment> UpdateAsync([NotNull]CrispyEnvironmentUpdateContext context);
        Task IncludeGlobalConfigAsync([NotNull]Guid id, bool include);
        Task EncryptAsync([NotNull]Guid id, bool encryption);
        Task EnableAsync([NotNull]Guid id, bool enabler);
        Task DeleteAsync([NotNull]Guid id);
    }
}
