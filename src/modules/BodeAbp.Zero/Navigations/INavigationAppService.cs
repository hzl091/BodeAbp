﻿using Abp.Application.Services;
using System.ComponentModel;
using Abp.Application.Services.Dto;
using BodeAbp.Zero.Navigations.Dtos;
using System.Threading.Tasks;

namespace BodeAbp.Zero.Navigations
{
	/// <summary>
    ///  导航信息 服务
    /// </summary>
	[Description("导航信息接口")]
    public interface INavigationAppService : IApplicationService
    {
        #region 导航信息

        /// <summary>
        /// 获取 导航信息分页
        /// </summary>
        /// <returns></returns>
        Task<NavigationListOutput[]> GetAllNavigations();



        /// <summary>
        /// 添加 导航信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateNavigation(NavigationInput input);

        /// <summary>
        /// 更新 导航信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateNavigation(NavigationInput input);
		

        /// <summary>
        /// 删除 导航信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteNavigation(IdInput input);


        /// <summary>
        /// 菜单升序
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task NavigationUp(IdInput input);

        /// <summary>
        /// 菜单降序
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task NavigationDown(IdInput input);

        #endregion
    }
}
