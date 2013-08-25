using System;
using Jd.Utility;

namespace CodeUnion.CodeGenerator.Data
{
    [Serializable]
    public class Column
    {
        private string alias;
        private string description;

        public string Alias
        {
            get
            {
                if (string.IsNullOrEmpty(this.alias))
                {
                    return this.Name.ToPascal();
                }
                return this.alias;
            }
            set
            {
                this.alias = value;
            }
        }

        public string CamelAlias
        {
            get
            {
                return this.Alias.ToCamel();
            }
        }

        public string DefaultValue
        {
            get; 
            set;
        }

        public string Description
        {
            get; 
            set;
        }

        public long? Length
        {
            get; 
            set;
        }

        public string Name
        {
            get; 
            set;
        }

        public bool Nullable
        {
            get; 
            set;
        }

        public bool Primary
        {
            get; 
            set;
        }

        public long Sequence
        {
            get; 
            set;
        }

        public string Type
        {
            get; set;
        }
    }
}
