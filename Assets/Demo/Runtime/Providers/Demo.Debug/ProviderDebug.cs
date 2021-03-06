﻿/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: https://ilruntime.catlib.io/
 */

using CatLib;
using Demo.API.Debug;
using Demo.Debug;

namespace Demo.Debug
{
    /// <summary>
    /// 调试服务
    /// </summary>
    public class ProviderDebug : ServiceProvider
    {
        /// <summary>
        /// 注册调试服务
        /// </summary>
        public override void Register()
        {
            App.Singleton<IDebug, UnityDebug>();
        }
    }
}