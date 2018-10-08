using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingSkills_Model
{
    public class UserInfo:IModel.IUser
    {
        #region 实现接口
        //唯一识别码
        public string userUniqueId { get; set; }
        //账户名
        public string userId { get; set; }
        //密码
        public string userPwd { get; set; }
        //姓名
        public string userName { get; set; }
        //性别 0:男 1:女
        public int userSex { get; set; }
        //出生日期
        public DateTime userBirthday { get; set; }
        //身份证号
        public string userIDCardNo { get; set; } 
        #endregion

    }
}
