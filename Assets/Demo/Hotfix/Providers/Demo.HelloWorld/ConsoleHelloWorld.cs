/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: https://ilruntime.catlib.io/
 */

using Demo.API.Debug;
using Hotfix.API.HelloWorld;

namespace Hotfix.HelloWorld
{
    /// <summary>
    /// 热更新 Hello World 实现
    /// </summary>
    public class ConsoleHelloWorld : IHelloWorld
    {
        private IDebug Debug { get; set; }

        public ConsoleHelloWorld(IDebug debug)
        {
            Debug = debug;
        }

        /// <inheritdoc />
        public void Say()
        {
            Debug.Log("hello world");
        }
    }
}