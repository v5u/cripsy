﻿namespace Crispy.Abstractions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class CrispyApplication : CrispyEntityKey
    {
        public CrispyApplication() { }
        public CrispyApplication(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public bool IncludeGlobalConfig { get; set; }
        public bool Encryption { get; set; }
        public bool Enabler { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<CrispyEnvironment> Enviroments { get; set; } = new List<CrispyEnvironment>();

    }
}