using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingSkills_Model.Log
{
    public class ReturnMsg: IModel.ILog
    {
        //状态
        public int Status { get; set; }
        //提示信息
        public string msg { get; set; }
    }
}
