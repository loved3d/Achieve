﻿using AchieveCommon;
using AchieveDALFactory;
using AchieveEntity;
using AchieveInterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchieveBLL
{
    public class Sys_ModuleButtonBLL
    {
        ISys_ModuleButtonDAL dal = DALFactory.GetModuleButtonDAL();

        /// <summary>
        /// 获取菜单
        /// </summary>
        public List<Sys_ModuleButton> GetAllModule()
        {
            return dal.GetAllModule();
        }
        /// <summary>
        /// 获取所有菜单
        /// </summary>
        /// <returns></returns>
        public List<Sys_ModuleButton> GetList(string id="")
        {
            return dal.GetList(id);
        }

        public Sys_ModuleButton GetForm(string id)
        {
            return dal.GetForm(id);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        public bool Add(Sys_ModuleButton obj, string[] disstr = null)
        {
            return dal.Add(obj, disstr);
        }
        public bool Delete(string idstr)
        {
            return dal.Delete(idstr);
        }
        public bool Update(Sys_ModuleButton obj, string[] disablestr = null)
        {
            return dal.Update(obj, disablestr);
        }

        public List<Sys_ModuleButton> GetButtonList(string roleid)
        {
            return dal.GetButtonList(roleid);
        }
    }
}
