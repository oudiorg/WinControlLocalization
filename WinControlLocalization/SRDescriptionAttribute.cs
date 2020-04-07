using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinControlLocalization
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SRDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private bool replaced = false;

        public SRDescriptionAttribute(string description) : base(description)
        {

        }

        public override string Description
        {
            get
            {
                if (this.replaced == false)
                {
                    this.replaced = true;
                    this.DescriptionValue = SR.GetString(base.Description);
                }
                return base.Description;
            }
        }
    }
}
