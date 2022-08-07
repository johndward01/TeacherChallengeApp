using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherChallengeLibrary;

public class DoApiCallEventArgs : EventArgs
{
    public string AlertMessage { get; set; } = "";
    public StatusCode StatusCode { get; set; } = StatusCode.Trace;
}
