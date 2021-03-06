﻿/**************************************************************************  
*   =================================
*   CLR版本  ：4.0.30319.42000
*   命名空间 ：MedicalShredApp.Models.Chat
*   文件名称 ：ChatContentViewModel
*   =================================
*   创 建 者 ：Memoyu
*   电子邮箱 ：mmy6076@outlook.com
*   创建日期 ：2020-05-10 12:03:56
*   功能描述 ：
*   =================================
*   修 改 者 ：
*   修改日期 ：
*   修改内容 ：
*   ================================= 
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalShredApp.Models.Chat
{
    public class ChatContentViewModel : ChatContentModel
    {
        public bool IsUser { get; set; }
        public bool IsSystemMessage { get; set; }
        public string AnotherName { get; set; }
        public string UserName { get; set; }
    }
}
