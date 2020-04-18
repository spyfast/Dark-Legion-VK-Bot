using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFloods.API.Chat
{
    public struct ChatConfig
    {
        public string chatTarget { get; set; }
        public string nameTo { get; set; }
        public bool removeAvatar { get; set; }
        public ChatConfig(string chatTarget, string nameTo, bool removeAvatar)
        {
            this.chatTarget = chatTarget;
            this.nameTo = nameTo;
            this.removeAvatar = removeAvatar;
        }
    }
}
