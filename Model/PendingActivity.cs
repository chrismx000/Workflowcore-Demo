using System;

namespace WorkflowCore.Test.Model
{
    public class PendingActivity
    {
        public string Token { get; set; }
        public string ActivityName { get; set; }
        public object Parameters { get; set; }
        public DateTime TokenExpiry { get; set; }

    }
}
