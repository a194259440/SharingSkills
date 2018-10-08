using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingSkills_Model.IModel
{
    interface IUser
    {
        //唯一识别码
        string userUniqueId { get; set; }
        //账户名
        string userId { get; set; }
        //密码
        string userPwd { get; set; }
        //姓名
        string userName { get; set; }
        //性别 0:男 1:女
        int userSex { get; set; }
        //出生日期
        DateTime userBirthday { get; set; }
        //身份证号
        string userIDCardNo { get; set; }

    }
}
