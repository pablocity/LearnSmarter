using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace LearnSmarter.Mobile.Core.Models
{
    public enum Priority
    {
        [Description("Bardzo ważne")]
        Supreme,
        [Description("Ważne")]
        Important,
        [Description("Średnia ważność")]
        Average,
        [Description("Niski priorytet")]
        Low
    }
}
