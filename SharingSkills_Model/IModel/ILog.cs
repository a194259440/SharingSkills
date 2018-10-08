using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingSkills_Model.IModel
{
    interface ILog
    {
        //状态
        int Status { get; set; }
        //提示信息
        string msg { get; set; }
    }
}
