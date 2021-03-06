﻿using System.ComponentModel;

namespace Newbe.Mahua.Apis
{
    /// <summary>
    /// 管理员拒绝入群申请
    /// </summary>
    [Description("管理员拒绝入群申请")]
    public class RejectGroupJoiningRequestApiMahuaCommand : ApiMahuaCommand
    {
        public string GroupJoiningRequestId { get; set; }

        public string ToGroup { get; set; }

        public string FromQq { get; set; }

        public string Reason { get; set; }
    }
}
