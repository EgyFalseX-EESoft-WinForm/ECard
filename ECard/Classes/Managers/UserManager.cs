using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ECard.Classes.Managers
{
    public static class UserManager
    {
        private readonly static Datasource.dsDataTableAdapters.UsersTableAdapter adpUser = new Datasource.dsDataTableAdapters.UsersTableAdapter();
        private readonly static Datasource.dsDataTableAdapters.RoleDetialTableAdapter adpRoleDetail = new Datasource.dsDataTableAdapters.RoleDetialTableAdapter();

        public static Datasource.dsData.UsersRow UserInfo { get; set; }
        public static Datasource.dsData.RoleDetialDataTable RoleDetial = new Datasource.dsData.RoleDetialDataTable();
        public static bool LoadUserInfo(string username, string password)
        {
            Datasource.dsData.UsersDataTable tbl = adpUser.GetDataByLogin(username, password);
            if (tbl.Count > 0)
            {
                UserInfo = (Datasource.dsData.UsersRow)tbl.Rows[0];
                adpRoleDetail.FillByUserId(RoleDetial, UserInfo.UserID);
                return true;
            }
            else
                return false;
        }
    }
}
